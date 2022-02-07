# Docker (review)

## Why did we even get here?
Diff OS, environments led to docker/containerization because in order to build/run programs, we had to have all its dependencies (environments, runtimes, libraries, anything you need to run a program without installing a bunch of software)

It takes a lot of time to manually configure everything for each machine, so it's easier to just have everything in one place

Emergence of cloud- sharing resources offered by vendors who has extra resources (ie servers, infrastructure) available made this problem particularly painful. - thus the rise of containerization / virtualization

## Where does docker fit in?
Docker is a containerization platform that allows us to containerize applications with necessary dependencies so they can run anywhere.

Virtualization: creating new OS - static resource allocation
Containerization: runs on same machine, multiple containers - dynamic resource allocation


### In order to get my P1 running on a brand new machine, I need to...
1. Install .NET SDK
2. Also install git
3. AWS Toolkit/VS/VSCode
4. Clone the project from github (our source code)
5. Docker desktop *
6. Maybe also make sure it runs/tests/compiles/acts as I intended *
7. run dotnet publish- to neatly package it to deployable artifact
8. Just run that artifact, and now my app is running!

## DockerFile
is a file that contains a set of instructions on how to create the image.
We follow the steps we would do to configure a new machine to be able to run our project- so for example
- downloading our dependencies
- grabbing our source code
- building/publishing

--> afterwards we build an image, which is a file system that contains all the things we need to run the program, from the instructions written in dockerFile.

in order to build the image from docker file, `docker build <relative-path-to-your-dockerFile>` with name, tag, etc.

