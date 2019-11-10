FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build
WORKDIR ./

# copy csproj and restore as distinct layers
COPY sfcc-cli-tools/*.csproj ./sfcc-cli-tools/
WORKDIR ./sfcc-cli-tools
RUN dotnet restore

# copy and publish app and libraries
WORKDIR ./
COPY sfcc-cli-tools/. ./sfcc-cli-tools/
WORKDIR /sfcc-cli-tools
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/runtime:3.0-alpine AS runtime
WORKDIR /sfcc-cli-tools
COPY --from=build /sfcc-cli-tools/out ./
ENTRYPOINT ["dotnet", "dotnetapp.dll"]