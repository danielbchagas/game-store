#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GameStore.Payment.Api/GameStore.Payment.Api.csproj", "GameStore.Payment.Api/"]
RUN dotnet restore "GameStore.Payment.Api/GameStore.Payment.Api.csproj"
COPY . .
WORKDIR "/src/GameStore.Payment.Api"
RUN dotnet build "GameStore.Payment.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameStore.Payment.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameStore.Payment.Api.dll"]