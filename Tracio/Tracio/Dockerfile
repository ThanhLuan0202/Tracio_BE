# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy toàn bộ solution & restore packages
COPY ["Tracio.API/Tracio.API.csproj", "Tracio.API/"]
COPY ["Tracio.Data/Tracio.Data.csproj", "Tracio.Data/"]
COPY ["Tracio.Service/Tracio.Service.csproj", "Tracio.Service/"]
RUN dotnet restore "Tracio.API/Tracio.API.csproj"

# Copy toàn bộ source code vào container
COPY . .

# Build project
RUN dotnet publish "Tracio.API/Tracio.API.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose cổng API (mặc định .NET chạy trên cổng 8080)
EXPOSE 8080

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "Tracio.API.dll"]
