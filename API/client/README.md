# Full Stack To Do Application 

_Web Based To Do Application_

Create a To Do List and Mark Items Off As You Complete Them

Start Trading Today! [Link to Application](https://dmurphytodoapp.azurewebsites.net/) 


## Instructions

To Download and Run Locally

I. Clone SQL Databse Schema

1. Download PosgreSQL/PGAdmin 
2. Run the databse creation script in the `backup.sql` file in the `root` directory

II. Install Files to Run Locally

1. Clone code locally from GitHub
2. CD into `API\client` directory
3. Run `npm i` in `client` directory
4. Rename `.env_sample` to `.env` file and replace `DEVELOPMENT_CONNECTION_STRING with the connection string for your local PostgreSQL database.
5. Uncomment line 19 and comment out line 20 in `Core\DatabaseConnection.cs`
6. CD into `API` directory.
6. Run `dotnet watch run` in `API` directory to start server.
7. Open browser at `http://localhost:5000/`

### Application Screenshot
![Application Screenshot](https://github.com/danielmurphy1/csharptodo/blob/main/images/csharptodo.JPG)

## Technologies/Design

### Technology Stack

- JavaScript with React Framework, CSS with Boostrap Library - Front End Stack
- C# with ASP.NET Web Application (.NET Framework) - Backend Stack and Internal/REST API
- PostgreSQL - Database with Npgsql Nuget Package
- Microsoft Azure - Hosting platform





### Summary

This application is my second since I have begun learning C# and my first using .NET and also my first fullstack application using C#/ASP.NET Web Application. 

To create this application I continued to expand on my C# knowledge as well as learning .NET Web API from the beginning. I have created a couple of seperate To Do applications in the past; however, this is the first one that I have created using a SQL database and to have full CRUD capabilities (previously relying on local storage for data persistence).  

In creating this application I learned more about how data and requests flow between the client, server, and databse. I also learned more about how to split the backend logic between the REST API endpoint controllers and the services that each endpoint calls to perform database operations. 

As this was my first application deployed to Microsoft Azure, I also learned how that deployment process works. More importantly, I learned how to use Azure's logging to identify and fix problems during the deployment process. 

I look forward to continue my learning of C# and the .NET framework in future projects. 

### Author

- Dan Murphy, Full-Stack Developer, https://www.linkedin.com/in/daniel-murphy-055/, https://danielmurphy.dev