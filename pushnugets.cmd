@echo on

".nuget/nuget.exe" push bin\nuget\debug\AdvancedREI.Restier.*.nupkg  -Source https://www.nuget.org/api/v2/package
".nuget/nuget.exe" push bin\nuget\debug\AdvancedREI.Restier.Core.*.nupkg  -Source https://www.nuget.org/api/v2/package
".nuget/nuget.exe" push bin\nuget\debug\AdvancedREI.Restier.Providers.EntityFramework.*.nupkg  -Source https://www.nuget.org/api/v2/package
".nuget/nuget.exe" push bin\nuget\debug\AdvancedREI.Restier.Publishers.OData.*.nupkg  -Source https://www.nuget.org/api/v2/package
pause