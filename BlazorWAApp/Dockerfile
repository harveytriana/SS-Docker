# Basic guide: Containerising a Blazor WebAssembly App, Chris Sainty
# https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-webassembly-app/

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# For native dependences
RUN dotnet workload install wasm-tools

WORKDIR /src
COPY *.csproj .
RUN dotnet workload restore
COPY . .
RUN dotnet build BlazorWAApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish BlazorWAApp.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf

# ------------------------------------------------------
# create image
# docker build -t blazor-wa-ss .
# note. Use 8080 in nginx.conf, not 80 due to is net8

# starting a container
# docker run -p 8080:80 --name blazor-wa-ss blazor-wa-ss