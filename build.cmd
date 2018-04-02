dotnet build -c Release ./Iyzipay

echo --------------------
echo Running NET45 Tests
echo --------------------

dotnet test -c Release ./Iyzipay.Tests -f net45

echo --------------------
echo Running NETCORE2 Tests
echo --------------------

dotnet test -c Release ./Iyzipay.Tests -f netcoreapp2.0

echo --------------------
echo Running NETCORE1 Tests
echo --------------------

dotnet test -c Release ./Iyzipay.Tests -f netcoreapp1.1

dotnet pack -c Release ./Iyzipay