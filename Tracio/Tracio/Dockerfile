# Base image cho runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build image với SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy file .csproj trước để cache dependencies
COPY ["Tracio.API/Tracio.API.csproj", "Tracio.API/"]
COPY ["Tracio.Data/Tracio.Data.csproj", "Tracio.Data/"]
COPY ["Tracio.Service/Tracio.Service.csproj", "Tracio.Service/"]

# Khôi phục dependencies
RUN dotnet restore "Tracio.API/Tracio.API.csproj"

# Copy toàn bộ source code
COPY . .

# Chuyển vào thư mục API và build
WORKDIR "/src/Tracio.API"
RUN dotnet publish -c Release -o /app/publish

# Image cuối cùng
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Tracio.API.dll"]
