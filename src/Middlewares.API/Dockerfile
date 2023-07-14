#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Middlewares.API/Middlewares.API.csproj", "Middlewares.API/"]
RUN dotnet restore "Middlewares.API/Middlewares.API.csproj"
COPY . .
WORKDIR "/src/Middlewares.API"
RUN dotnet build "Middlewares.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Middlewares.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Middlewares.API.dll"]