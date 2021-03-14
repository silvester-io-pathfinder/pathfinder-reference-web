FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build

USER root

ARG artifactoryUsername
ARG artifactoryPassword

WORKDIR /build
COPY Sources Sources/

RUN dotnet nuget add source https://silvester.jfrog.io/artifactory/api/nuget/silvester-nuget  -n Artifactory --username $artifactoryUsername --password $artifactoryPassword

RUN dotnet restore ./Sources/Silvester.Pathfinder.Official.Web.sln 
RUN dotnet test ./Sources/Silvester.Pathfinder.Official.Web.sln 
RUN dotnet publish ./Sources/Silvester.Pathfinder.Official.Web.sln -c Release -o /build/publish


FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS release

EXPOSE 80
WORKDIR /app
COPY --from=build /build/publish ./

CMD ["dotnet", "Silvester.Pathfinder.Official.Web.dll"]