# Todoapi

### Prerequisites
```
Visual Studio Code
C# for Visual Studio Code (latest version)
.NET 8.0 SDK
```
>> The Visual Studio Code instructions use the .NET CLI for ASP.NET Core development functions such as project creation. You can follow these instructions on macOS, Linux, or Windows and with any code editor. Minor changes may be required if you use something other than Visual Studio Code.

### .Net Core 8.0.0 Create WebAPI from vscode
``` 
> dotnet new webapi --use-controllers -o TodoApi
> cd TodoApi
> dotnet add package Microsoft.EntityFrameworkCore.InMemory
> dotnet dev-certs https --trust
```

### Scaffold a controller
```
> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> dotnet tool uninstall -g dotnet-aspnet-codegenerator
> dotnet tool install -g dotnet-aspnet-codegenerator
> dotnet tool update -g dotnet-aspnet-codegenerator
```

### MySql Package
```
> dotnet add package Pomelo.EntityFrameworkCore.MySql
```

### Install Entity Framework

```
> dotnet add package Microsoft.EntityFrameworkCore.Tools
> dotnet tool install --global dotnet-ef
```

### Database migration
```
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

### Run WebAPI Application
```
> dotnet run --launch-profile https
```