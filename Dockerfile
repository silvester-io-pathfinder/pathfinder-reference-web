FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build

ARG artifactoryUsername
ARG artifactoryPassword

WORKDIR /build
COPY Sources Sources/

RUN dotnet nuget add source https://silvester.jfrog.io/artifactory/api/nuget/silvester-nuget  -n Artifactory --username $artifactoryUsername --password $artifactoryPassword --store-password-in-clear-text 

RUN dotnet restore ./Sources/Silvester.Pathfinder.Official.Web.sln 
RUN dotnet test ./Sources/Silvester.Pathfinder.Official.Web.sln 
RUN dotnet publish ./Sources/Silvester.Pathfinder.Official.Web.sln -c Release -o /build/publish


FROM nginx
COPY --from=build /build/publish/wwwroot /usr/share/nginx/html
COPY ./default.conf /etc/nginx/conf.d/

sed -i 's/base href=\"/\"/base href=\"/web/\"/g' /usr/share/nginx/html/index.html