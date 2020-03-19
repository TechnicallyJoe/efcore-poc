# efcore POC

Based on https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli

To set up this poc do the following:

Assuming you are standing in the root of the project folder.

1. Run `dotnet restore .\src\movies.sln`
2. Run `docker-compose up -d`
3. Wait about 2 minutes for MSSSQL to start up
4. Run the following script:
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate --project .\src\movies.core\movies.core.csproj
dotnet ef database update --project .\src\movies.core\movies.core.csproj
```
5. Run `dotnet run --project .\src\movies.core\movies.core.csproj`