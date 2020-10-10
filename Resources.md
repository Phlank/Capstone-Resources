# Capstone Resources from your Assigned Favorite Mentor

## C# resources

### Visual Studio Community

https://visualstudio.microsoft.com/vs/community/

Visual Studio is great for working with C#, and it has been used by .NET and .NET Core users for as long as it's been around. Because of this, there are many features that will make programming in Visual Studio feel really simple. I'd recommend it above VS Code.

### C# Programming Guide

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/

This section of documentation has style conventions, information on asynchronous programming in C#, use of attributes, LINQ (Language-integrated query, basically writing a database query in C#), lambda expressions (extremely useful), detailed information about scopes, types, generics, namespaces, and interfaces in C#. Use the sidebar and start reading and you'll have a lot of things in your brain in an hour or two.

### MVC Pattern - Model, View, Controllers

https://dotnet.microsoft.com/apps/aspnet/mvc

You have probably heard of model-view separation during your time in school, and this is an especially important principle in applications that will become as large as your capstone. The MVC pattern is a massive boon to this. Control your database with internal models, control what gets exposed to your users through view models, design a view to deliver the view model in a proper format, and use a controller to transfer data between the internal models and view models. MVC is hands-down one of the best ways to stay organized and is a great way to organize the view-side of a project and connect it with the model-side.

### Building a REST API in C# with .NET Core

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio

Long tutorial, but really awesome. Make sure to read up on MVC before this, as it uses the principles of MVC throughout. This talks about connecting web endpoints that you've designed to the data access layer, typically implemented as a database. While you can't quite see an API endpoint like you can a website, you should really think of it like the 'view' part of MVC. It's what applications will see when they access your web server.

### Creating a Web App with ASP.NET Core MVC

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.1

Nearly the same thing as the REST API, but this time it's deploying a web page. You will notice many things are identical between the two, and that should demonstrate how similar the backend for each is when you set everything up correctly.

## Databases

Before I give any more resources about database types, I want to give a broad warning: MySQL isn't very good. It has a lot of blind spots. Don't choose it because it shows up on Google.

I would recommend choosing between SQL Server and PostgreSQL. If you are building a mobile application, look into SQLite. It's a very lightweight implementation for a SQL database, and it's the item of choice for every mobile app.

I personally enjoy PostgreSQL the most, but admittedly I've worked with it more than SQL Server, so I would be lying if I said I wasn't biased.

### What is a database?

https://www.youtube.com/watch?v=_Q07-8e3UbI

It's not a crazy in-depth video, but if you need to get a general intro to databases, this is a decent video.

### PostgreSQL

https://www.postgresql.org/

Download links, etc. Read a guide to install it and make sure you remember your admin username and password.

#### pgAdmin

https://www.pgadmin.org/

You really don't want to look at your database through the terminal or powershell. Trust me. Just don't. Use a program to look through your tables instead. ["We're not cavemen! We have technology." - Patrick Star](https://www.youtube.com/watch?v=2_0BrcV-Txo)

### SQL Server

https://www.microsoft.com/en-us/sql-server/sql-server-2019

If you go to downloads, there are developer and express versions that are both free. You'd want to pick one of those.

#### SQL Server Management Studio (SSMS)

https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15

It's pgAdmin for SQL Server. Admittedly it has a much larger range of functionality, but I don't expect the extra functionality to be too useful for you. Most of your updates to your database should be done through Entity Framework. Speaking of which...

### Entity Framework Core

https://docs.microsoft.com/en-us/ef/core/

Read and browse the MVC link above before getting here. Have you ever been worried about messing something up when defining all of your tables in a database? Worried you're going to blow things to bits by muddling up all of your foreign keys? That's a thing of the past. Entity Framework gives you a way to make structural changes to the database through code changes. It also gives you an easy way to access your database tables through code. This is the best way to work with databases in C# and anyone who says otherwise is a dingaling. It supports both PostgreSQL and SQL Server databases.

## Other Stuff

Good luck with your projects this year. As I've said before, I'm always here if you need me. Work together, and work hard. Set high expectations for yourselves through this project and make it your first priority when it comes to your workload this semester. Your capstone will define your education at BSU, and it is the best time to push yourself to become the programmer that you want to be. The capstone project will be going on your resume, it is what you will talk about in interviews, and it is a way to find a potential employer.
