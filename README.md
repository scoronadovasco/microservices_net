# Microservices .NET Project

## Description
This project is a microservices-based architecture built using .NET. It leverages Docker for containerization and includes MongoDB as the database service. The project is designed to be modular, scalable, and easy to deploy.

## Features
- Microservices architecture
- MongoDB integration
- Dockerized environment
- Health checks for services

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed
- [Docker](https://www.docker.com/) installed and running
- Docker Compose installed

## Getting Started

### Clone the Repository
```bash
git clone https://github.com/scoronadovasco/microservices_net.git
cd microservices_net
```

### Build the Project
```bash
dotnet build
```

### Run the Application
Start the services using Docker Compose:
```bash
docker-compose up -d
```

### Verify MongoDB
You can verify that MongoDB is running by connecting to it:
```bash
docker exec -it mongodb mongosh
```

### Stop the Application
To stop and remove the running containers:
```bash
docker-compose down
```

## Project Structure
```
/home/crocs/microservices_net
├── docker-compose.yml   # Docker Compose configuration
├── .gitignore           # Git ignore rules
├── README.md            # Project documentation
├── Projects/            # Source code for microservices
```

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.