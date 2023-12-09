FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Lab5/Lab5Folder/Lab5Folder.csproj", "src/Lab5/Lab5Folder/"]
RUN dotnet restore "src/Lab5/Lab5Folder/Lab5Folder.csproj"
COPY . .
WORKDIR "/src/src/Lab5/Lab5Folder"
RUN dotnet build "Lab5Folder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lab5Folder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lab5Folder.dll"]
