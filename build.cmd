dotnet build -c Release ./Iyzipay

echo --------------------
echo Running NET45 Tests
echo --------------------

dotnet test -c Release ./Iyzipay.Tests -f net45

dotnet pack -c Release ./Iyzipay