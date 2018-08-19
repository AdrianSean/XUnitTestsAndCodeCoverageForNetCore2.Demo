$path = Get-Location
dotnet test $path"\Application.UnitTests.csproj"  /p:CollectCoverage=true
pause