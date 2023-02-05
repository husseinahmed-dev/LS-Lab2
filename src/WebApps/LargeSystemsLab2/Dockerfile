FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["WebApps/LargeSystemsLab2/LargeSystemsLab2.csproj", "WebApps/LargeSystemsLab2/"]
RUN dotnet restore "WebApps/LargeSystemsLab2/LargeSystemsLab2.csproj"
COPY . .
WORKDIR "/src/WebApps/LargeSystemsLab2"
RUN dotnet build "LargeSystemsLab2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LargeSystemsLab2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LargeSystemsLab2.dll"]
