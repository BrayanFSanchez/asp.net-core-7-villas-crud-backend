## Project Name
Welcome to my ASP.NET Core Web API backend project called villas-backend.

## Description
It is a RESTful Web API in ASP.NET Core (net7.0) with a SQL Server database, to effectively consume the services in a web application.

## Installation
1. Clone the repository: https://github.com/BrayanFSanchez/asp.net-core-7-villas-crud-backend.git
2. Make sure you have the .NET Core SDK installed on your machine.
3. Download and install SQL Server LocalDB or SQL Server Express.

## Configuration
1. Open the appsettings.json file located at the root of the project and add the connection string to the database.
2. Run the migrations to create the database.

## Usage
To start the server, run the following command:
dotnet run

## Project structure
The folder structure you mentioned (Controllers, Models, Data, Migrations, Repository) follows an organization based on the Model-Controller pattern (MVC). In this pattern, the models represent the data and are located in the "models" folder. Controllers, located in the "controllers" folder, take care of the business logic and handle user requests. Although not explicitly mentioned, the MVC structure also includes the view, which handles the presentation of data to the user. The modularized and organized structure of the Model-Controller pattern allows for easier project development and maintenance.

## APIs and endpoints
APIs represent sets of endpoints that provide functionality and enable communication with server. Each API focuses on a specific domain of the application. Each API has designated endpoints, which are the paths through which that functionality is accessed.

![crud-villas-swagger](https://github.com/BrayanFSanchez/asp.net-core-7-villas-crud-backend/assets/49698030/d9d830fc-1d7c-4da5-8335-c92da98d9b73)

### Create a new Villa
* Endpoint: POST /api/villas
* Description: This endpoint allows you to create a new villa entry in the database. You can send a JSON object containing the necessary information for the villa, such as name, location, amenities, and any other relevant details.

### Get All Villas
* Endpoint: GET /api/villas
* Description: This endpoint retrieves a list of all the villas currently stored in the database. It returns an array of JSON objects, each representing a villa with its associated information.

### Get a Single Villa
* Endpoint: GET /api/villas/{id}
* Description: This endpoint allows you to retrieve detailed information about a specific villa by providing its unique identifier (id) as part of the URL.

### Update a Villa
* Endpoint: PUT /api/villas/{id}
* Description: This endpoint enables you to update the information of an existing villa. You need to specify the unique id of the villa in the URL and send a JSON object with the updated data in the request body.

### Delete a Villa
* Endpoint: DELETE /api/villas/{id}
* Description: This endpoint allows you to remove a villa from the database based on its unique identifier (id). After successful deletion, the villa's information will no longer be available in the system.

## Packages
* AutoMapper (v12.0.1): AutoMapper is a library that simplifies object-to-object mapping in an ASP.NET Core application. It automates the process of converting data between model classes and entities, saving time and reducing repetitive code.

* AutoMapper.Extensions.Microsoft.DependencyInjection (v12.0.1): This package is an extension for AutoMapper that facilitates its integration with the ASP.NET Core dependency injection system. It streamlines the configuration of AutoMapper in the application and allows its use throughout the lifetime of dependencies.

* Microsoft.AspNetCore.JsonPatch (v7.0.3): JsonPatch is an implementation of the "Patch" standard for partial update operations in RESTful APIs. With this package, you can apply partial changes to JSON objects received in HTTP PATCH requests, which is useful for updating only certain fields of a resource.

* Microsoft.AspNetCore.Mvc.NewtonsoftJson (v7.0.3): This package provides support for Newtonsoft.Json in ASP.NET Core MVC. Newtonsoft.Json is a popular and powerful library for serializing and deserializing JSON objects. By using this package, you can customize the JSON serialization behavior in your application.

* Microsoft.AspNetCore.OpenApi (v7.0.3): This package adds support for OpenAPI and Swagger in ASP.NET Core. OpenAPI is a specification that describes and documents RESTful APIs, and Swagger is a tool that uses this specification to generate interactive API documentation. With this package, you can automatically generate detailed documentation and an interactive interface for your API.

* Microsoft.EntityFrameworkCore.SqlServer (v7.0.3): Microsoft.EntityFrameworkCore.SqlServer is the database provider for SQL Server in Entity Framework Core. This package enables you to use Entity Framework Core to interact with a SQL Server database in your ASP.NET Core application.

* Microsoft.EntityFrameworkCore.Tools (v7.0.3): Microsoft.EntityFrameworkCore.Tools provides additional tools for working with Entity Framework Core, such as database migrations. It simplifies the creation, application, and rollback of migrations to keep the database schema in sync with the application's data model.
