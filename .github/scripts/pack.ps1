$Arguments = "-Version" , $env:VERSION,
"-Symbols" , "-SymbolPackageFormat" , "snupkg"

nuget pack .\JANL\JANL.nuspec @Arguments
nuget pack .\JANL.WinForms\JANL.WinForms.nuspec @Arguments
nuget pack .\JANL.WinForms\JANL.Office.nuspec @Arguments