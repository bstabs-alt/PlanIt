@echo off

if "%1" == "test" (
  dotnet test PlanIt.Tests.sln
) else if "%1" == "app" (
  dotnet run --project PlanIt.ConsoleApp\PlanIt.ConsoleApp.csproj
) else (
  echo Usage: run.bat [test|app]
)