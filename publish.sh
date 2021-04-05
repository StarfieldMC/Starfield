dotnet publish nylium.Launch -c Release -r win-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r osx-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-musl-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-arm -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-arm64 -p:PublishSingleFile=true --self-contained false
7z a nylium.Launch/bin/Release/net5.0/win-x64.zip ./nylium.Launch/bin/Release/net5.0/win-x64/publish/*
7z a nylium.Launch/bin/Release/net5.0/osx-x64.zip ./nylium.Launch/bin/Release/net5.0/osx-x64/publish/*
7z a nylium.Launch/bin/Release/net5.0/linux-x64.zip ./nylium.Launch/bin/Release/net5.0/linux-x64/publish/*
7z a nylium.Launch/bin/Release/net5.0/linux-musl-x64.zip ./nylium.Launch/bin/Release/net5.0/linux-musl-x64/publish/*
7z a nylium.Launch/bin/Release/net5.0/linux-arm.zip ./nylium.Launch/bin/Release/net5.0/linux-arm/publish/*
7z a nylium.Launch/bin/Release/net5.0/linux-arm64.zip ./nylium.Launch/bin/Release/net5.0/linux-arm64/publish/*
