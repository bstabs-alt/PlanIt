#!/bin/bash

if [ "$1" == "test" ]; then
  dotnet test PlanIt.Tests.sln
elif [ "$1" == "app" ]; then
  dotnet run --project PlanIt.ConsoleApp/PlanIt.ConsoleApp.csproj
else
  echo "Usage: ./run.sh [test|app]"
fi