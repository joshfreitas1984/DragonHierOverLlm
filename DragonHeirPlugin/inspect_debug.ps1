$asm = [System.Reflection.Assembly]::LoadFile('G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan\BepInEx\interop\UnityEngine.CoreModule.dll')
try { $types = $asm.GetTypes() } catch [System.Reflection.ReflectionTypeLoadException] { $types = $_.Exception.Types | Where-Object { $_ -ne $null } }
$debugTypes = $types | Where-Object { $_.Name -eq 'Debug' }
$debugTypes | ForEach-Object { Write-Output "TYPE: $($_.FullName)" }
foreach ($t in $debugTypes) {
    $t.GetMethods() | Where-Object { $_.Name -like 'Log*' } | ForEach-Object {
        $ps = ($_.GetParameters() | ForEach-Object { $_.ParameterType.FullName }) -join ', '
        Write-Output "  $($_.ReturnType.Name) $($_.Name)($ps)"
    }
}
