#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish AspNetCoreMvc.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS = "http://*:4500"
ENTRYPOINT ["dotnet", "AspNetCoreMvc.dll"]