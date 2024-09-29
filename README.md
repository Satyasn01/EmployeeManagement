# Employee Management System

The Employee Management System is a web application designed to help organizations manage their employee records efficiently. It allows users to register, log in, and perform CRUD operations on employee data. This project is built using ASP.NET MVC and utilizes an Oracle Database for data management.

## Technologies Used

- **ASP.NET MVC**: For creating the server-side web application.
- **Oracle Database**: Used for storing and managing employee data.
- **Entity Framework**: ORM used for database interactions.
- **HTML/CSS**: For structuring and styling the web pages.
- **JavaScript**: Used to enhance interactivity in the web application.
- **Git**: For version control.
- **Docker**: Used for containerizing the application, ensuring consistency across various development and deployment environments.

## Features

- User authentication (Register, Login, Logout).
- CRUD operations for managing employee records.
- Responsive web design.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- .NET Framework 4.8
- Oracle Database setup with the necessary schemas

### Installing

A step-by-step series of examples that tell you how to get a development environment running:

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/employee-management-system.git
   ```
2. Navigate to the project directory:
   ```bash
   cd employee-management-system
   ```
3. Restore dependencies:
   ```bash
   nuget restore
   ```
4. Update the `Web.config` file with your Oracle database connection details.

5. Run the application:
   ```bash
   dotnet run
   ```

## Deployment

Add additional notes about how to deploy this on a live system using Docker:

```bash
docker build -t employee-management-system .
docker run -d -p 8080:80 employee-management-system
```

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

- **Your Name** - *Initial work* - [Satyasn01](https://github.com/Satyasn01))

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.txt) file for details.
