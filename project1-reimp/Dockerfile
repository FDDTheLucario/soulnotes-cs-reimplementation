FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["project1-reimp/project1-reimp.csproj", "project1-reimp/"]
RUN dotnet restore "project1-reimp/project1-reimp.csproj"
COPY . .
WORKDIR "/src/project1-reimp"
RUN dotnet build "project1-reimp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "project1-reimp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "project1-reimp.dll"]
