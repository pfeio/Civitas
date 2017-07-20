#Dockerfile that launches the Civitas web api based on 
FROM microsoft/dotnet:1.1-sdk
#FROM microsoft/aspnetcore:1.1
LABEL maintainer="Pedro Feio <pfeio@live.com>"
ARG port=5001
ARG host=localhost
#ARG microservicesname=report -----acho que isto nao vai ser preciso
# WORKDIR /dotnetapp
# COPY out .
# #RUN ["dotnet", "restore"]
# RUN ["dotnet", "publish",".\Civitas.WebAPICore.csproj -v:d"]
# EXPOSE ${port}
# ENTRYPOINT ["dotnet", "Civitas.WebAPICore.dll","--server.urls=http://${host}:${port}/"]


WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Release -o out
EXPOSE ${port}
ENTRYPOINT ["dotnet", "out/Civitas.WebAPICore.dll"] 

#,"--server.urls=http://${host}:${port}/"]
