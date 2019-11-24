FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build

# Copy csproj and restore as distinct layers
WORKDIR ./
COPY *.sln .
COPY sfcc-cli-tools/*.csproj ./sfcc-cli-tools/
WORKDIR ./sfcc-cli-tools/

RUN dotnet restore

# Copy everything else and build
COPY aspnetapp/. ./aspnetapp/
WORKDIR /app/aspnetapp
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine AS runtime
WORKDIR /sfcc-cli-tools
COPY --from=build /app/aspnetapp/out ./
ENTRYPOINT ["dotnet", "aspnetapp.dll"]