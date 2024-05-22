dotnet tool install -g minver-cli --version 4.2.0
$version = minver -t v -d preview
$number = $version.Split('-')[0]
Write-Output "VERSION=$version"
Write-Output "V=$number"
"VERSION=$version" >> $env:GITHUB_ENV
"V=$number" >> $env:GITHUB_ENV
Write-Output "{version}={$version}" >> $GITHUB_OUTPUT

# Replace version in AssemblyInfo
$Path = '.\SharedAssemblyInfo.cs'
$File = Get-Content $Path
$File = $File.Replace('AssemblyVersion("2.0.0")', "AssemblyVersion(`"${number}`")")
Set-Content $Path $File

# Replace version in nuspec
$Path = '.\JANL.WinForms\JANL.WinForms.nuspec'
$File = Get-Content $Path
$File = $File.Replace('id="Virenbar.JANL" version="2.0.0"', "id=`"Virenbar.JANL`" version=`"${version}`"")
Set-Content $Path $File

$Path = '.\JANL.Office\JANL.Office.nuspec'
$File = Get-Content $Path
$File = $File.Replace('id="Virenbar.JANL" version="2.0.0"', "id=`"Virenbar.JANL`" version=`"${version}`"")
Set-Content $Path $File