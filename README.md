# Deploying Haqa-sec Assignment Docker Image

This guide explains how to deploy the Docker image `ayalasap/haqa-sec-ha` on both Linux and Windows machines.

## Prerequisites

Ensure Docker is installed on your machine:
- For Linux, follow the [Docker documentation](https://docs.docker.com/get-docker/).
- For Windows, install [Docker Desktop](https://www.docker.com/products/docker-desktop).

## Pulling the Docker Image

Pull the Docker image from [Docker Hub](https://hub.docker.com/r/ayalasap/haqa-sec-ha):
```bash
docker pull ayalasap/haqa-sec-ha
```

## Running the Docker Container

Start a Docker container based on the image:
```bash
docker run -d -p 8080:80 ayalasap/haqa-sec-ha
```

## Accessing the Application

Access the application:
- Open a web browser and go to [http://localhost:8080/Networks](http://localhost:8080/Networks)
