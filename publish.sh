dotnet publish nylium.Launch -c Release -r win-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r osx-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-musl-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-arm -p:PublishSingleFile=true --self-contained false
dotnet publish nylium.Launch -c Release -r linux-arm64 -p:PublishSingleFile=true --self-contained false