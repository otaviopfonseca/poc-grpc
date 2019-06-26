FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["POC.GRPC.Api/POC.GRPC.Api.csproj", "POC.GRPC.Api/"]
RUN dotnet restore "POC.GRPC.Api/POC.GRPC.Api.csproj"
COPY . .
WORKDIR "/src/POC.GRPC.Api"
RUN dotnet build "POC.GRPC.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POC.GRPC.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POC.GRPC.Api.dll"]