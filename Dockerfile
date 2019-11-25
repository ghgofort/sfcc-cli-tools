FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build

# Copy csproj and restore as distinct layers
WORKDIR /app
COPY *.sln .
COPY sfcc-cli-tools/*.csproj ./sfcc-cli-tools/
WORKDIR ./sfcc-cli-tools/

RUN dotnet restore

# Copy everything else and build
COPY sfcc-cli-tools/. ./sfcc-cli-tools/
WORKDIR /app/sfcc-cli-tools
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine AS runtime
WORKDIR /app
COPY --from=build /app/sfcc-cli-tools/out ./
ENTRYPOINT ["dotnet", "bash"]