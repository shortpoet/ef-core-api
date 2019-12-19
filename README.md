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

- adding models
- many to many relationships defined in lookup tables with naming convention Nav1(s)Nav2(s).cs for the rosters