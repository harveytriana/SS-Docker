FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# For native dependences
RUN apt-get update -y && apt-get install python3 libatomic1 -y && dotnet workload install wasm-tools

WORKDIR /src
COPY *.csproj .
RUN dotnet workload restore
COPY . .
RUN dotnet build BlazorSS.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish BlazorSS.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf

# ------------------------------------------------------
# create image
# docker build -t blazor-wa-ss .

# starting a container
# docker run -d -p 5200:8080 --name blazor-wa-ss blazor-wa-ss
