# CDNApp API

CDNApp is a simple ASP.NET Core API. This API provides endpoints for registering, updating, deleting, and retrieving user information.

## Features

- Register a new user
- Update user details
- Delete a user
- Get a list of all users

## Technologies Used

- ASP.NET Core API
- Entity Framework Core
- SQL Server
- Swagger

## Entity Framework Setup

Entity Framework Core (EF Core) is used as the ORM (Object-Relational Mapper) for this project to interact with the SQL Server database. Here's how to set up Entity Framework in your project:

1. **Install Entity Framework Core:**
   - Add the `Microsoft.EntityFrameworkCore` package to your project using NuGet Package Manager or the .NET CLI:
     ```bash
     dotnet add package Microsoft.EntityFrameworkCore
     ```

2. **Create DbContext Class:**
   - Create a class that derives from `DbContext`. This class represents your database context and defines the entities to be mapped to database tables.

3. **Configure DbContext:**
   - Configure your `DbContext` in the `Program.cs` file to inject it into your application's services. Use the `AddDbContext` method to register your DbContext with dependency injection.

4. **Connection String Setup:**
   - Set up your connection string in the `appsettings.json` file. Specify the connection string for your SQL Server database.

5. **Run Migrations:**
   - Run Entity Framework Core migrations to create and apply database schema changes. Open the Package Manager Console in Visual Studio and run the following commands:
     ```bash
     Add-Migration InitialCreate
     Update-Database
     ```

6. **Verify Database:**
   - After running migrations, verify that your database schema has been created or updated according to your DbContext configuration.

## Deployment on Render

An alternative modern cloud platform for hosting various types of applications. Heroku is no longer free as I tried

### Deployment Steps

1. **Sign Up for Render:**
   - Sign up at [Render](https://render.com/).

2. **Create a New Web Service:**
   - Log in to Render dashboard.
   - Click on "Add New" -> "Web Service".
   - Select Left panel, connect to public GitHub / GitLab

3. **Specify Build and Deployment Settings:**
   - Provide the URL of your private repository where your ASP.NET Core API project is hosted.
   - Specify the branch want to deploy.

4. **Add Database Add-On (Optional):**
   - If the ASP.NET Core API relies on a database, you can add a managed database add-on like PostgreSQL or MySQL directly from the Render dashboard.

5. **Deploy Your Service:**
   - Click on "Create Web Service" to deploy your ASP.NET Core API on Render.

6. **Access Your API:**
   - Once the deployment is complete, Render will provide you with a URL to access your API. You can use this URL to make requests to your API endpoints.

## License

This project is licensed under the MIT License.
