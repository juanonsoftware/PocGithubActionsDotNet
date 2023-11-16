# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .

# copy everything else and build app
COPY . .

# delete bin & obj folders
RUN find -type d -name bin -prune -exec rm -rf {} \; 
RUN find -type d -name obj -prune -exec rm -rf {} \;

RUN dotnet restore
WORKDIR /source/SampleWebApplication
RUN dotnet publish -c Release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "SampleWebApplication.dll"]
