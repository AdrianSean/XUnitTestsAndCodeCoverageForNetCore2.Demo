*****
xUnit
*****
MS Docs: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
Exception testing: https://hadihariri.com/2008/10/17/testing-exceptions-with-xunit/


*************
Code Coverage
*************
Coverlet: https://github.com/tonerdo/coverlet
Fixes for TFS: https://medium.com/@DomBurf/performing-code-coverage-for-net-core-2-0-applications-7280dd2af22b
More info: https://tattoocoder.com/cross-platform-code-coverage-arrives-for-net-core/


Running code coverage in cmd line
*********************************
C:\<PATH TO YOUR .NET CORE SOLUTION>\Application.UnitTests>dotnet test "Application.UnitTests.csproj" /p:CollectCoverage=true


Coverlet.msbuild is the nuget to install in the unit test project.

Unit testing best practices: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
