dotnet tool install -g minver-cli --version 2.5.0
$version = minver -t v -d preview
# $number = $version.Split('-')[0]
Write-Output "VERSION=$version"
"VERSION=$version" >> $env:GITHUB_ENV
Write-Output "{name}={$version}" >> $GITHUB_OUTPUT

$Path = '.\JANL.WinForms\JANL.WinForms.nuspec'
$File = Get-Content $Path
$File = $File.Replace('id="Virenbar.JANL" version="2.0.0"', "id=`"Virenbar.JANL`" version=`"${version}`"")
Set-Content $Path $File