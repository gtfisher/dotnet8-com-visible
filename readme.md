com visible dotnet8

example built following:
https://learn.microsoft.com/en-us/dotnet/core/native-interop/expose-components-to-com

got to the point of regsitrering the class (`regsvr32 dotnet8-com-visible.comhost.dll`)

built the mainifest added <EnableRegFreeCom>true</EnableRegFreeCom> to .csproj, then `dotnet build`

Now build the tlb

https://learn.microsoft.com/en-us/windows/win32/midl/com-dcom-and-type-libraries#type-library



