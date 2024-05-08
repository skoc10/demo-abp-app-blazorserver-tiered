param ($version='latest')

$currentFolder = $PSScriptRoot
$slnFolder = Join-Path $currentFolder "../../"

Write-Host "********* BUILDING DbMigrator *********" -ForegroundColor Green
$dbMigratorFolder = Join-Path $slnFolder "src/demoabpapp.blazorservertiered.DbMigrator"
Set-Location $dbMigratorFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t demoabpapp/blazorservertiered-db-migrator:$version .

Write-Host "********* BUILDING Blazor Application *********" -ForegroundColor Green
$blazorFolder = Join-Path $slnFolder "src/demoabpapp.blazorservertiered.Blazor"
Set-Location $blazorFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t demoabpapp/blazorservertiered-blazor:$version .


$authServerAppFolder = Join-Path $slnFolder "src/demoabpapp.blazorservertiered.AuthServer"
Set-Location $authServerAppFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t demoabpapp/blazorservertiered-authserver:$version .

Write-Host "********* BUILDING Api.Host Application *********" -ForegroundColor Green
$hostFolder = Join-Path $slnFolder "src/demoabpapp.blazorservertiered.HttpApi.Host"
Set-Location $hostFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t demoabpapp/blazorservertiered-api:$version .

### ALL COMPLETED
Write-Host "COMPLETED" -ForegroundColor Green
Set-Location $currentFolder