copy .\Iyzipay\bin\Release\Iyzipay.dll .\Iyzipay\build\net45\Iyzipay.dll /Y

cd Iyzipay\build
del *.nupkg
nuget pack Iyzipay.nuspec

pause