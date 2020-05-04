#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/azure-functions/dotnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TestSqlClientFunction/TestSqlClientFunction.csproj", "TestSqlClientFunction/"]
RUN dotnet restore "TestSqlClientFunction/TestSqlClientFunction.csproj"
COPY . .
WORKDIR "/src/TestSqlClientFunction"
RUN dotnet build "TestSqlClientFunction.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestSqlClientFunction.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/app