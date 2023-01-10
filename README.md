# TestImageApp
Frontend: Angular 15
Backend: ASP.Net Core 3
Database: MS SQL Server (LocalDB)

Note:
create a database named "ImageDatabase" in SQL Server (LocalDB).
to open sql server localdb, use server name = (LocalDB)\MSSQLLocalDB in SSMS.
open project and open nuget package manager console in Visual Studio 
and run "update-database -context ImageDBContext" command to create database table.
run the project.

open the ClientApp folder, open cmd, run npm install then npm start to run angular project
update baseURL:string = "https://localhost:44313" in file.service.ts according to your asp.net api url (iis url)
