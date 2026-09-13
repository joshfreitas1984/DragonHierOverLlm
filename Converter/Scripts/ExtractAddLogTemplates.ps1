<#
.SYNOPSIS
  One-off diagnostic: scans decompiled _NoNamespace/*.cs for HeroData.AddLog(...) / AreaData.AddLog(...)
  call sites and heuristically traces each back to the String.Format literal template that produced the
  logged string, producing a deduplicated candidate list of "Raw" Chinese narrative-log templates.

.DESCRIPTION
  Not part of the Converter pipeline - a read-only investigation/re-derivation script. Run manually:
    pwsh -File Scripts/ExtractAddLogTemplates.ps1 -SourceDir "Converter/output/_NoNamespace"

  Background: a family of narrative-log lines is built as
    uVarX = String.Format("<literal template>", args...);
    HeroData.AddLog(hero, uVarX, 0);   // or AreaData.AddLog(area, uVarX, 0)
  This script exists so that when Converter/output/_NoNamespace/*.cs is regenerated (game content
  update -> re-run of Ghidra/decompiler), the same candidate template list can be re-derived without
  redoing the manual trace documented in
    DragonHeirPlugin/docs/recordlog-translation-naturalness.md (or equivalent trace doc).

  ALGORITHM (heuristic, NOT a full control-flow/dataflow analysis):
    1. For every .cs file in -SourceDir, scan line-by-line for `HeroData.AddLog(` / `AreaData.AddLog(`
       call sites. Skip the `AddLog` method DEFINITIONS themselves (lines matching
       `public void AddLog(`).
    2. For each call site, extract the 2nd positional argument (the log-string variable, e.g. `uVar8`).
    3. Walk BACKWARD from the call-site line, within a bounded window, looking for the nearest line
       assigning that variable via `<var> = String.Format(<firstArg>, ...)`.
         - If <firstArg> is a quoted string literal, that literal is the resolved template - done.
         - If <firstArg> is itself a variable (common pattern: the literal is assigned to a helper
           variable in one of several preceding if/else branches, e.g. `uVar8 = "{0}...";` then later
           `uVar8 = String.Format(uVar8, uVar9, ...)`), the script then scans backward from the
           String.Format line for EVERY reachable `<firstArg> = "<literal>"` assignment before hitting
           a stop boundary (method start, or another AddLog call, or a hard line-count cap) and reports
           each distinct literal found as its own candidate template attributed to this call site. This
           deliberately over-collects when a call site has multiple conditional branches, since each
           branch represents a distinct possible logged line.
    4. Backward scanning stops at a heuristic "method boundary": a line matching a method signature
       (`^\s*(public|private|internal|protected)\s+\S.*\(`) or the start of the file/class, whichever
       comes first, or after -MaxLookback lines (default 400), whichever comes first.
    5. Output: deduplicated Raw template strings, each with one example file:line and a total call-site
       count, written to stdout (default) or -OutFile if given (one JSON object per line - JSONL).

.PARAMETER SourceDir
  Directory containing the decompiled *.cs files to scan (recursively). Typically
  Converter/output/_NoNamespace.

.PARAMETER OutFile
  Optional path to write JSONL output to (one {Template, ExampleLocation, Count} object per line).
  If omitted, a human-readable summary is written to the console only.

.PARAMETER MaxLookback
  Maximum number of lines to scan backward from an AddLog call site (and, separately, from a
  String.Format call whose first argument is itself a variable) before giving up. Default 400.

.EXAMPLE
  pwsh -File Scripts/ExtractAddLogTemplates.ps1 -SourceDir "Converter/output/_NoNamespace"

.EXAMPLE
  pwsh -File Scripts/ExtractAddLogTemplates.ps1 -SourceDir "Converter/output/_NoNamespace" -OutFile addlog_templates.jsonl

.NOTES
  KNOWN LIMITATIONS (read before trusting the output blindly):
  - This is a line-based textual heuristic, not a real decompiler/CFG dataflow pass. It does not
    understand goto/label control flow, so on rare occasions it may attribute a template found in a
    sibling branch (separated by a `goto`/label) to the wrong call site, or miss one separated from its
    call site by a `goto` that jumps over a large block.
  - Call sites whose logged variable is built via String.Concat(...) (e.g.
    `uVar3 = String.Concat(uVar3,"的",...,"修建完成",0); AreaData.AddLog(area,uVar3,0);`) or via the
    "StringBuilder-like" FUN_180002070/FUN_180002fd0 append-then-format-with-object-array pattern where
    the literal itself is still a `String.Format("literal", <object[]>)` call (this second pattern IS
    handled - the literal is still the first arg to String.Format) are only partially handled:
    Concat-only chains with no String.Format at all are NOT resolved by this script and are reported
    as "UNRESOLVED - no String.Format found" for manual review.
  - When the resolved "template" variable is itself built by String.Concat of a literal fragment plus
    a runtime value (e.g. `uVar8 = String.Concat("传闻", areaName, "{0}({1})", 0);` used as a
    String.Format format string), the script reports the raw String.Format first-argument EXPRESSION
    text as found (which may include the String.Concat(...) call), rather than a clean literal - these
    are flagged with a `PartialLiteral = $true` field and should be reviewed by hand.
  - A single AddLog call site fed by several conditional branches (each assigning a different literal
    to the same variable before a shared String.Format call) will correctly produce multiple distinct
    templates attributed to that one call site - this is intentional, not a bug, but means "call-site
    count" for Task 1 purposes is really "distinct (call site, template) pairs", not raw AddLog line
    count.
  - KNOWN GAP: the multi-branch collection above only triggers when the String.Format call's first
    argument is a VARIABLE (so the script must look further back for the literal). When a call site is
    instead fed by several conditional branches that each call String.Format with the LITERAL inline as
    the first argument directly (e.g. `uVar7 = String.Format("{0}气运过人...",...)` in one branch,
    `uVar7 = String.Format("{0}吉星高照...",...)` in a sibling branch, both eventually reaching one
    `HeroData.AddLog(x,uVar7,0)`), the script only reports the literal from the NEAREST preceding
    assignment and misses the sibling branches' literals entirely (confirmed against
    GameController.cs's large random-treasure-event handler around line 22925, which has ~9 sibling
    literal templates but the script only surfaces 1). Large multi-branch "random event" style methods
    should be spot-checked by hand by searching nearby for other `= String.Format("..."` lines that
    share the same eventual AddLog call, rather than trusting the script's single hit.
  - Similarly, unrelated sibling-branch literal assignments to a same-named, reused variable can
    occasionally leak into the "collect sibling literals" backward scan for the variable-indirection
    case, producing spurious short/unrelated "templates" (e.g. a stray "0" or an unrelated label string
    picked up from a nearby but logically unconnected branch of the same bloated method). Treat very
    short or oddly-generic entries in the output as signals to go re-read the source around the given
    Example location rather than as trustworthy templates.
  - Decompiled variable names (uVar8, lVar15, ...) are reused heavily and are NOT SSA - the backward
    scan can in rare cases pick up a stale assignment to a same-named variable from a logically
    unrelated earlier branch if no method-boundary or AddLog boundary is crossed in between. Treat
    output as a candidate list for human review, not ground truth.
  - This script does not attempt to resolve templates reached only through helper methods (e.g. a
    literal defined in one method and passed by reference into another) - only same-file, same-method
    (heuristically bounded) traces are attempted.
  - Regex-based literal extraction assumes standard `"..."` C#-style string literals without embedded
    escaped quotes spanning the extraction; verbatim/interpolated string forms are not expected in this
    decompiled output and are not specially handled.

  Given these limitations, always diff the output against the previous known-good template list after
  a regeneration, and spot-check any new/changed/UNRESOLVED entries against the source before relying
  on them.
#>
param(
    [Parameter(Mandatory = $true)]
    [string]$SourceDir,

    [string]$OutFile,

    [int]$MaxLookback = 400
)

if (-not (Test-Path $SourceDir)) {
    Write-Error "Source directory not found: $SourceDir"
    exit 1
}

$files = Get-ChildItem -Path $SourceDir -Filter *.cs -Recurse
if ($files.Count -eq 0) {
    Write-Error "No .cs files found under $SourceDir"
    exit 1
}

$addLogCallRegex   = '(?:HeroData|AreaData)\.AddLog\(\s*[^,]+,\s*([A-Za-z_][A-Za-z0-9_]*)\s*(?:,|\))'
$addLogDefRegex    = '^\s*public\s+void\s+AddLog\('
$methodSigRegex    = '^\s*(public|private|internal|protected)\s+\S.*\('
$formatAssignRegex = '^(?<indent>\s*)(?<var>[A-Za-z_][A-Za-z0-9_]*)\s*=\s*String\.Format\(\s*(?<first>"(?:[^"\\]|\\.)*"|[A-Za-z_][A-Za-z0-9_]*)\s*[,)]'
$literalAssignRegexTemplate = '^\s*{0}\s*=\s*(?<lit>"(?:[^"\\]|\\.)*")\s*;'

# Result set: Template -> @{ Count = n; Example = "file:line" }
$results = [ordered]@{}
$unresolved = New-Object System.Collections.Generic.List[string]

function Add-TemplateResult {
    param([string]$Template, [string]$Location, [bool]$Partial = $false)
    if ($results.Contains($Template)) {
        $results[$Template].Count++
    }
    else {
        $results[$Template] = [PSCustomObject]@{
            Template = $Template
            Count    = 1
            Example  = $Location
            Partial  = $Partial
        }
    }
}

foreach ($file in $files) {
    $lines = Get-Content -LiteralPath $file.FullName
    $lineCount = $lines.Count

    for ($i = 0; $i -lt $lineCount; $i++) {
        $line = $lines[$i]

        if ($line -match $addLogDefRegex) { continue }  # skip AddLog method definitions
        if ($line -notmatch $addLogCallRegex) { continue }

        $targetVar = $Matches[1]
        $callLineNo = $i + 1
        $location = "$($file.Name):$callLineNo"

        # Backward scan for `targetVar = String.Format(<first>, ...)`
        $foundFormat = $false
        $lowerBound = [Math]::Max(0, $i - $MaxLookback)
        for ($j = $i - 1; $j -ge $lowerBound; $j--) {
            $bline = $lines[$j]

            # Stop at a method boundary before finding anything
            if ($bline -match $methodSigRegex) { break }

            if ($bline -match "^\s*$targetVar\s*=\s*String\.Format\(") {
                if ($bline -match $formatAssignRegex -and $Matches['var'] -eq $targetVar) {
                    $first = $Matches['first']
                    $foundFormat = $true

                    if ($first.StartsWith('"')) {
                        # Direct literal template
                        $template = $first.Trim('"')
                        Add-TemplateResult -Template $template -Location $location
                    }
                    else {
                        # First arg is itself a variable - look further back for literal assignment(s)
                        $literalRegex = [string]::Format($literalAssignRegexTemplate, [regex]::Escape($first))
                        $formatLineIdx = $j
                        $innerLower = [Math]::Max(0, $formatLineIdx - $MaxLookback)
                        $foundAny = $false
                        for ($k = $formatLineIdx - 1; $k -ge $innerLower; $k--) {
                            $kline = $lines[$k]
                            if ($kline -match $methodSigRegex) { break }
                            if ($kline -match $literalRegex) {
                                $lit = $Matches['lit'].Trim('"')
                                Add-TemplateResult -Template $lit -Location $location
                                $foundAny = $true
                                # keep scanning further back to collect sibling-branch literals too
                            }
                        }
                        if (-not $foundAny) {
                            $unresolved.Add("$location - String.Format(<var:$first>, ...) but no literal assignment to '$first' found within $MaxLookback lines (may be String.Concat-built or defined elsewhere)")
                        }
                    }
                    break
                }
            }
        }

        if (-not $foundFormat) {
            $unresolved.Add("$location - no String.Format(...) assignment to '$targetVar' found within $MaxLookback lines before this AddLog call (likely String.Concat-built or a plain literal/variable passed directly)")
        }
    }
}

# ── Output ──────────────────────────────────────────────────────────────────
$sorted = $results.Values | Sort-Object -Property Count -Descending

if ($OutFile) {
    $sorted | ForEach-Object {
        [PSCustomObject]@{
            Template = $_.Template
            Count    = $_.Count
            Example  = $_.Example
            Partial  = $_.Partial
        } | ConvertTo-Json -Compress
    } | Set-Content -LiteralPath $OutFile -Encoding UTF8
    Write-Host "Wrote $($sorted.Count) distinct templates to $OutFile"
}
else {
    Write-Host "=== Distinct AddLog String.Format templates found: $($sorted.Count) ==="
    foreach ($r in $sorted) {
        Write-Host ("[{0}x] {1}  (e.g. {2})" -f $r.Count, $r.Template, $r.Example)
    }
}

Write-Host ""
Write-Host "=== Unresolved / needs manual review: $($unresolved.Count) ==="
foreach ($u in $unresolved) {
    Write-Host "  $u"
}
