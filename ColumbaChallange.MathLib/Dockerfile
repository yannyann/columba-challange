
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env

WORKDIR /app

#Copy csproj and restore as distinct layers
COPY . ./

RUN dotnet restore

WORKDIR /app/ColumbaChallange.MathLib.Tests

ENTRYPOINT ["dotnet", "test", "ColumbaChallange.MathLib.Tests.csproj"]

