$currentFolder = $PSScriptRoot

$slnFolder = Join-Path $currentFolder "../"
$certsFolder = Join-Path $currentFolder "certs"

If(!(Test-Path -Path $certsFolder))
{
    New-Item -ItemType Directory -Force -Path $certsFolder
    if(!(Test-Path -Path (Join-Path $certsFolder "localhost.pfx") -PathType Leaf)){
        Set-Location $certsFolder
        dotnet dev-certs https -v -ep localhost.pfx -p f0442807-3ebc-4e31-a839-e3a32a483f17 -t        
    }
}

Set-Location $currentFolder
docker-compose up -d