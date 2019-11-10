FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build

# Copy csproj and restore as distinct layers
WORKDIR ./
COPY sfcc-cli-tools/*.csproj ./sfcc-cli-tools/
WORKDIR ./sfcc-cli-tools/

RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:2.2
WORKDIR /sfcc-cli-tools
COPY --from=build /sfcc-cli-tools/out ./
ENTRYPOINT ["dotnet", "sfccclitools.dll"]