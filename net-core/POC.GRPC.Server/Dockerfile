FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY POC.GRPC.Server/POC.GRPC.Server.csproj POC.GRPC.Server/
COPY POC.GRPC.Definitions/POC.GRPC.Definitions.csproj POC.GRPC.Definitions/
RUN dotnet restore POC.GRPC.Server/POC.GRPC.Server.csproj
COPY . .
WORKDIR /src/POC.GRPC.Server
RUN dotnet build POC.GRPC.Server.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish POC.GRPC.Server.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
EXPOSE 50051
ENTRYPOINT ["dotnet", "POC.GRPC.Server.dll"]
