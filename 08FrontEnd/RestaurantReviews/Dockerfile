# Base image to build our image off of
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Setting the work directory to run subsequent add, copy, cmd, run, etc. commands from in our IMAGE
WORKDIR /app

# Copying csproj and sln files over from our source code to image
COPY *.sln ./
COPY BL/*.csproj ./BL/
COPY DL/*.csproj ./DL/
COPY Models/*.csproj ./Models/
COPY Tests/*.csproj ./Tests/
COPY WebAPI/*.csproj ./WebAPI/

# Before moving further, let's check our sln is able to restore all its dependencies
RUN dotnet restore

COPY . ./

RUN dotnet publish WebAPI -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS run

WORKDIR /app

COPY --from=build /app/publish ./

CMD [ "dotnet", "WebAPI.dll" ]