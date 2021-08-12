$version = minver -t v -d preview #2>&1 | %{ "$_" }
$v = $version.Split('-')[0]
Write-Output "V: $version $v"