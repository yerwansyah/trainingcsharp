
todo app with jwt
----
dotnet ef migrations add "Initial Migration"
dotnet ef database update
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 5.0.11
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.11
dotnet add package Microsoft.AspNetCore.Identity.UI --version 5.0.11

https://www.browserling.com/tools/random-string
yglsfwoijugqfcstmizvdthddahqxsbm

dotnet ef migrations add "Addig authentication to our Api"
dotnet ef database update

cara buat
---
dotnet new webapi -n "TodoApp" -lang "C#" -au none
https://localhost:5001/api/todo/testrun
https://localhost:5001/WeatherForecast

dotnet ef migrations add "Initial Migration"

install
---
dotnet tool install --global dotnet-ef
jika versi 5 : https://www.nuget.org/packages/dotnet-ef/5.0.1
dotnet tool install --global dotnet-ef --version 5.0.1

dotnet add package NuGet.CommandLine.XPlat --version 5.11.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.11
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.11
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.11

database
--
dotnet ef database drop

version
--
dotnet restore
dotnet --version

run dotnet
---
dotnet run watch

cek certificate
---
dotnet dev-certs https --trust

migrasi
---
dotnet ef migrations rermove
dotnet ef migrations add "Initial Migrations"
dotnet ef migrations add InitialCreate
dotnet ef migrations add InitialCreate --output-dir Migrations
dotnet ef migrations add InitialCreate --context BlogContext --output-dir Migrations/SqlServerMigrations
dotnet ef migrations add InitialCreate --context SqliteBlogContext --output-dir Migrations/SqliteMigrations

dotnet tool update --global dotnet-ef --version 3.1.0
dotnet tool update --global dotnet-ef --version 5.0.2
dotnet tool uninstall --global dotnet-ef

-------------------------------------------------------------

My solution was to install the tool dotnet-ef from microsoft
https://www.nuget.org/packages/dotnet-ef.
It uses the same commands but no warnings.
The change is to use dotnet-ef instead of dotnet ef.

And if you already have dotnet-ef installed then use dotnet tool 
update --global dotnet-ef --version n.n.n (n.n.n your version to update to)

-------------------------------------------------------------
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools
Entity Framework Core Tools for the NuGet Package Manager Console in Visual Studio.
Enables these commonly used commands:
Add-Migration
Drop-Database
Get-DbContext
Get-Migration
Remove-Migration
Scaffold-DbContext
Script-Migration
Update-Database

https://www.nuget.org/packages/NuGet.CommandLine.XPlat/
NuGet executable wrapper for the dotnet CLI nuget functionality.

https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/
SQLite database provider for Entity Framework Core.

https://docs.microsoft.com/en-gb/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

https://stackoverflow.com/questions/41011700/how-to-generate-controller-using-dotnetcore-command-line
-------------------------------------------------------------

Table Items
-----
Id Integer
Title Text
Description Text
Done Integer

CREATE TABLE "Items" ( "Id" INTEGER NOT NULL CONSTRAINT "PK_Items" PRIMARY KEY AUTOINCREMENT, "Title" TEXT NULL, "Description" TEXT NULL, "Done" INTEGER NOT NULL )

CREATE TABLE "__EFMigrationsHistory" ( "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY, "ProductVersion" TEXT NOT NULL )