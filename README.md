# ef-core-api
Entity Framework Core Api Database

- start with template

```
dotnet new webapi
```

- add EF core nuget package

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

- initiate database with In-Memory database

```
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

- adding [models](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-3.1&tabs=visual-studio#the-data-model)
  - many to many relationships defined in lookup tables with naming convention Nav1(s)Nav2(s).cs for the rosters

- install scaffolding packages

```
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.0.0
dotnet add package Microsoft.Extensions.Logging.Debug

dotnet tool install --global dotnet-aspnet-codegenerator --version 3.0.0
```

- run aspnet-codegenerator tool to scaffold razor pages, context, add context to DI in startup, add db conn string to appsettings.json

```
```