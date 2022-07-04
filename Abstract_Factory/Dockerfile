FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Abstract_Factory.csproj", "./"]
RUN dotnet restore "Abstract_Factory.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Abstract_Factory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Abstract_Factory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Abstract_Factory.dll"]
