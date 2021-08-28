dotnet publish --no-restore Starfield.Launch -c Release -r win-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish --no-restore Starfield.Launch -c Release -r osx-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish --no-restore Starfield.Launch -c Release -r linux-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish --no-restore Starfield.Launch -c Release -r linux-musl-x64 -p:PublishSingleFile=true --self-contained false
dotnet publish --no-restore Starfield.Launch -c Release -r linux-arm -p:PublishSingleFile=true --self-contained false
dotnet publish --no-restore Starfield.Launch -c Release -r linux-arm64 -p:PublishSingleFile=true --self-contained false
7z a Starfield.Launch/bin/Release/net5.0/win-x64.zip ./Starfield.Launch/bin/Release/net5.0/win-x64/publish/*
7z a Starfield.Launch/bin/Release/net5.0/osx-x64.zip ./Starfield.Launch/bin/Release/net5.0/osx-x64/publish/*
7z a Starfield.Launch/bin/Release/net5.0/linux-x64.zip ./Starfield.Launch/bin/Release/net5.0/linux-x64/publish/*
7z a Starfield.Launch/bin/Release/net5.0/linux-musl-x64.zip ./Starfield.Launch/bin/Release/net5.0/linux-musl-x64/publish/*
7z a Starfield.Launch/bin/Release/net5.0/linux-arm.zip ./Starfield.Launch/bin/Release/net5.0/linux-arm/publish/*
7z a Starfield.Launch/bin/Release/net5.0/linux-arm64.zip ./Starfield.Launch/bin/Release/net5.0/linux-arm64/publish/*
