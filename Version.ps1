$version = minver -t v -d preview #2>&1 | %{ "$_" }
$number = $version.Split('-')[0]
Write-Output "V: $version $number"

$Path = '.\JANL.WinForms\JANL.WinForms.nuspec'
$File = Get-Content $Path
$File = $File.Replace('id="Virenbar.JANL" version="2.0.0"', "id=`"Virenbar.JANL`" version=`"${version}`"")
Set-Content $Path $File
