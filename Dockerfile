FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env
COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

ENTRYPOINT ["dotnet", "run", "--server.urls", "https://0.0.0.0:5001"]