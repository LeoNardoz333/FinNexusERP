# FinNexusERP
A modern Enterprise Resource Planning (ERP) system built with the latest Microsoft technologies and enterprise software development practices.
The primary goal of this project is to demonstrate how to design, develop, and maintain a scalable, secure, and modular business application using the .NET ecosystem. Rather than focusing only on features, this repository emphasizes clean architecture, maintainability, and real-world development patterns.

    Status: Under active development.

# Features
The project is being incrementally developed following an agile approach.
Current and planned modules include:
- Authentication and Authorization
- User and Role Management
- Dashboard
- Customer Management
- Supplier Management
- Product Catalog
- Inventory Management
- Sales
- Purchases
- Invoicing
- Accounts Receivable
- Accounts Payable
- Treasury
- Reporting (PDF and Excel)
- Audit Logs
- Notifications
- Banking Integrations

# Architecture
This solution follows modern enterprise architecture principles, including:
- Clean Architecture
- CQRS (Command Query Responsibility Segregation)
- Dependency Injection
- Repository Pattern
- SOLID principles
- Modular Design

# Technology Stack
**Backend:**
- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- MediatR
- FluentValidation
- ASP.NET Core Identity
- JWT Authentication

**Frontend:**
- Blazor Web App
- MudBlazor

**Reporting:**
- QuestPDF
- EPPlus

**DevOps:**
- Docker for containerization
- Azure
- GitHub Actions for CI/CD

# Solution Structure
src/
    FinNexus.Domain
    FinNexus.Application
    FinNexus.Infrastructure
    FinNexus.API
    FinNexus.Web

# Project Responsibilities
- **FinNexus.Domain**: Contains the core business logic, entities, and domain services
- **FinNexus.Application**: Contains application services, CQRS handlers, commands, queries, and DTOs
- **FinNexus.Infrastructure**: Contains data access, external service integrations, and repository implementations
- **FinNexus.API**: Exposes RESTful APIs for the frontend and external clients
- **FinNexus.Web**: Contains the Blazor Web App for user interaction

# Getting Started
**Prerequisites:**
- .NET 9 SDK
- SQL Server (or any compatible database)
- Docker (optional, for containerization)
- Git

1. Clone the repository:
   ```bash
   git clone https://github.com/LeoNardoz333/FinNexusERP.git
   ```

2. Build the solution:
   ```bash
   cd FinNexusERP
   dotnet build
   ```

3. Run the API project:
   ```bash
   dotnet run src/FinNexus.API
   ```

4. Run the Web project:
   ```bash
   dotnet run src/FinNexus.Web
   ```

# Roadmap
- ![Inicializate solution](docs/vertical-strike.svg)
- Configure Clean Architecture
- Implement Authentication
- User Management
- Dashboard
- Customer Management
- Supplier Management
- Inventory Module
- Sales Module
- Purchasing Module
- Invoicing
- Financial Module
- PDF Reporting
- Excel Export
- Audit Logging
- Banking Integration
- Docker Support
- Azure Deployment
- CI/CD Pipeline

# Contributing
This project is primarily intended as a portfolio and learning project.
Suggestions, issues, and pull requests are welcome.

# License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details