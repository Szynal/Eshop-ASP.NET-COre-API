#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Eshop ASP.NET COre API/Eshop ASP.NET COre API.csproj", "Eshop ASP.NET COre API/"]
RUN dotnet restore "Eshop ASP.NET COre API/Eshop ASP.NET COre API.csproj"
COPY . .
WORKDIR "/src/Eshop ASP.NET COre API"
RUN dotnet build "Eshop ASP.NET COre API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Eshop ASP.NET COre API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Eshop ASP.NET COre API.dll"]