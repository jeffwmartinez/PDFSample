FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-20H2
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
