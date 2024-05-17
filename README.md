# haqa-sec

This guide explains how to deploy the Docker image ayalasap/haqa-sec-ha on both Linux and Windows machines.

Prerequisites
Ensure Docker is installed on your machine:
  For Linux, follow the Docker documentation.
  For Windows, install Docker Desktop.

Pull the Docker image from Docker Hub (https://hub.docker.com/r/ayalasap/haqa-sec-ha):  
  docker pull ayalasap/haqa-sec-ha
  
Start a Docker container based on the image:
  docker run -d -p 8080:80 ayalasap/haqa-sec-ha
  
Access the application:
  Open a web browser and go to http://localhost:8080/Networks
