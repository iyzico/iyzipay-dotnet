#!/usr/bin/env bash

#exit if any command fails
set -e

export FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.5/

dotnet restore Iyzipay.sln

# Linux/Darwin
OSNAME=$(uname -s)
echo "OSNAME: $OSNAME"

dotnet build ./Iyzipay.Tests/Iyzipay.Tests.csproj /p:Configuration=Release || exit 1

sudo nuget install NUnit.ConsoleRunner -OutputDirectory testrunner

echo --------------------
echo Running NET45 Tests
echo --------------------

mono ./testrunner/NUnit.ConsoleRunner.*/tools/nunit3-console.exe ./Iyzipay.Tests/bin/Release/net45/Iyzipay.Tests.dll

echo --------------------
echo Running NETCORE2 Tests
echo --------------------

dotnet test ./Iyzipay.Tests -c Release -f netcoreapp2.0

echo --------------------
echo Running NETCORE1 Tests
echo --------------------

dotnet test ./Iyzipay.Tests -c Release -f netcoreapp1.1