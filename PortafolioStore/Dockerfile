# Usa la imagen base de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia los archivos del proyecto y restaura dependencias
COPY *.csproj .
RUN dotnet restore

# Copia el resto del código y compila
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Usa la imagen de tiempo de ejecución de .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia los archivos publicados desde la etapa de compilación
COPY --from=build /app/publish .

# Expone el puerto que usa tu aplicación (normalmente 80 o 5000)
EXPOSE 80

# Define el comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "PortafolioStore.dll"]