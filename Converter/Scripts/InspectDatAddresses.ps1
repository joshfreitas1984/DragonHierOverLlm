<#
.SYNOPSIS
  One-off diagnostic: dumps which PE section a set of Ghidra DAT_<hex> addresses fall into, and
  the raw 8-byte slot value at each, to figure out why StringMapExtractor's .data-section scan
  (usageType==5 kIl2CppMetadataUsageStringLiteral) misses them.

.DESCRIPTION
  Not part of the Converter pipeline - a read-only investigation script. Run manually:
    pwsh -File Scripts/InspectDatAddresses.ps1 -BinaryPath "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan\GameAssembly.dll"

  Background: DAT_181d72c58 etc. are Ghidra's naming for a virtual address (imageBase + RVA).
  StringMapExtractor only scans the ".data" section for 8-byte slots whose lower 32 bits encode
  usageType(bits 31..29)==5 + sourceIndex(bits 28..0) into global-metadata.dat's stringLiterals
  table. These 21 addresses (from CustomDifficultyData.cctor) are never resolved by that scan, so
  this script checks: (a) which section each address actually lives in, and (b) what the raw 8-byte
  slot decodes to under the same usageType/sourceIndex bit-split, to see whether it's a section
  mismatch or an encoding mismatch.
#>
param(
    [Parameter(Mandatory = $true)]
    [string]$BinaryPath,

    [string]$MetadataPath,

    [string[]]$Addresses = @(
        "0x181d72c58", "0x181d74ea8", "0x181d81368", "0x181d53970", "0x181d998a8",
        "0x181d97410", "0x181d97498", "0x181d8fdc0", "0x181d59df0", "0x181d71e58",
        "0x181d898c0", "0x181d77e48", "0x181d9dc08", "0x181d96d38", "0x181d8bd50",
        "0x181d77348", "0x181d56200", "0x181d56180", "0x181d56100", "0x181d56280",
        "0x181d56300"
    )
)

if (-not (Test-Path $BinaryPath)) {
    Write-Error "Binary not found: $BinaryPath"
    exit 1
}

$bytes = [System.IO.File]::ReadAllBytes($BinaryPath)

# ── Parse global-metadata.dat's string literal table (mirrors StringMapExtractor's step 2) ──
$stringLiterals = $null
$strCount = 0
$metaVersion = 0
if ($MetadataPath -and (Test-Path $MetadataPath)) {
    $meta = [System.IO.File]::ReadAllBytes($MetadataPath)
    $sanity = [BitConverter]::ToUInt32($meta, 0)
    $expectedSanity = [Convert]::ToUInt32("FAB11BAF", 16)
    if ($sanity -ne $expectedSanity) {
        Write-Warning "global-metadata.dat sanity check failed (got 0x$($sanity.ToString('X')))"
    }
    else {
        $metaVersion = [BitConverter]::ToInt32($meta, 4)
        $slOff = [BitConverter]::ToInt32($meta, 0x08)
        $slSize = [BitConverter]::ToInt32($meta, 0x0C)
        $slDataOff = [BitConverter]::ToInt32($meta, 0x10)
        $strCount = [int]($slSize / 8)
        Write-Host "Metadata string literal count: $strCount"
        $stringLiterals = New-Object string[] $strCount
        for ($i = 0; $i -lt $strCount; $i++) {
            $ent = $slOff + $i * 8
            $len = [BitConverter]::ToInt32($meta, $ent)
            $dataIdx = [BitConverter]::ToInt32($meta, $ent + 4)
            if ($len -le 0 -or $len -gt 65536 -or ($slDataOff + $dataIdx + $len) -gt $meta.Length) {
                $stringLiterals[$i] = ""
                continue
            }
            $stringLiterals[$i] = [System.Text.Encoding]::UTF8.GetString($meta, $slDataOff + $dataIdx, $len)
        }
    }
    Write-Host ""
}

# ── Parse PE header ──────────────────────────────────────────────────────────
$eLfanew = [BitConverter]::ToInt32($bytes, 0x3C)
$coffOffset = $eLfanew + 4
$numberOfSections = [BitConverter]::ToUInt16($bytes, $coffOffset + 2)
$sizeOfOptionalHeader = [BitConverter]::ToUInt16($bytes, $coffOffset + 16)
$optionalHeaderOffset = $coffOffset + 20
$magic = [BitConverter]::ToUInt16($bytes, $optionalHeaderOffset)

if ($magic -eq 0x20b) {
    # PE32+ (x64)
    $imageBase = [BitConverter]::ToUInt64($bytes, $optionalHeaderOffset + 24)
}
elseif ($magic -eq 0x10b) {
    # PE32
    $imageBase = [uint64][BitConverter]::ToUInt32($bytes, $optionalHeaderOffset + 28)
}
else {
    Write-Error "Unrecognized PE optional header magic: 0x$($magic.ToString('X'))"
    exit 1
}

Write-Host "ImageBase: 0x$($imageBase.ToString('X'))"
Write-Host "Sections : $numberOfSections"
Write-Host ""

$sectionTableOffset = $optionalHeaderOffset + $sizeOfOptionalHeader
$sections = @()
for ($i = 0; $i -lt $numberOfSections; $i++) {
    $secOffset = $sectionTableOffset + ($i * 40)
    $nameBytes = $bytes[$secOffset..($secOffset + 7)]
    $name = [System.Text.Encoding]::ASCII.GetString($nameBytes).TrimEnd([char]0)
    $virtualSize = [BitConverter]::ToUInt32($bytes, $secOffset + 8)
    $virtualAddress = [BitConverter]::ToUInt32($bytes, $secOffset + 12)
    $sizeOfRawData = [BitConverter]::ToUInt32($bytes, $secOffset + 16)
    $pointerToRawData = [BitConverter]::ToUInt32($bytes, $secOffset + 20)
    $sections += [PSCustomObject]@{
        Name             = $name
        VirtualAddress   = $virtualAddress
        VirtualSize      = $virtualSize
        PointerToRawData = $pointerToRawData
        SizeOfRawData    = $sizeOfRawData
    }
}
Write-Host ""

foreach ($addrStr in $Addresses) {
    $va = [Convert]::ToUInt64($addrStr, 16)
    $rva = $va - $imageBase

    $section = $sections | Where-Object {
        $rva -ge $_.VirtualAddress -and $rva -lt ($_.VirtualAddress + [math]::Max($_.VirtualSize, $_.SizeOfRawData))
    } | Select-Object -First 1

    if ($null -eq $section) {
        Write-Host "$addrStr -> RVA=0x$($rva.ToString('X')) : NOT within any known section range"
        continue
    }

    $fileOffset = [int]($section.PointerToRawData + ($rva - $section.VirtualAddress))
    if ($fileOffset + 8 -gt $bytes.Length) {
        Write-Host "$addrStr -> section '$($section.Name)' RVA=0x$($rva.ToString('X')) : file offset out of range"
        continue
    }

    $slot = [BitConverter]::ToUInt64($bytes, $fileOffset)
    $low32 = [uint32]($slot -band 0xFFFFFFFF)
    $usageType = $low32 -shr 29
    $srcIdx = $low32 -band 0x1FFFFFFF
    if ($metaVersion -ge 27) { $srcIdx = $srcIdx -shr 1 }

    $resolved = "(no metadata loaded)"
    if ($null -ne $stringLiterals) {
        if ($srcIdx -ge $strCount) {
            $resolved = "OUT OF RANGE (strCount=$strCount)"
        }
        else {
            $resolved = "'$($stringLiterals[$srcIdx])'"
        }
    }

    Write-Host ("{0} -> section '{1}' RVA=0x{2:X} fileOffset=0x{3:X} raw8={4:X16} usageType={5} srcIdx={6} resolved={7}" -f `
            $addrStr, $section.Name, $rva, $fileOffset, $slot, $usageType, $srcIdx, $resolved)
}
