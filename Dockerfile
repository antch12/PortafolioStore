# Build stage (keep this the same)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY PortafolioStore.sln .
COPY Core/*.csproj ./Core/
COPY Data/*.csproj ./Data/
COPY Methods/*.csproj ./Methods/
COPY PortafolioStore/*.csproj ./PortafolioStore/
RUN dotnet restore PortafolioStore.sln
COPY . .
WORKDIR /src/PortafolioStore
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Create directory for DataProtection keys and make it writable
RUN mkdir -p /keys && chmod 777 /keys
ENV ASPNETCORE_DATA_PROTECTION_KEYS_DIRECTORY=/keys

COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "PortafolioStore.dll"]