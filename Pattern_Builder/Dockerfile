FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pattern_Builder.csproj", "./"]
RUN dotnet restore "Pattern_Builder.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Pattern_Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pattern_Builder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pattern_Builder.dll"]
