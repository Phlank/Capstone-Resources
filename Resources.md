# Capstone Resources from your Assigned Favorite Mentor

- [Capstone Resources from your Assigned Favorite Mentor](#capstone-resources-from-your-assigned-favorite-mentor)
  - [C# resources](#c-resources)
    - [Visual Studio Community](#visual-studio-community)
    - [C# Programming Guide](#c-programming-guide)
    - [MVC Pattern - Model, View, Controllers](#mvc-pattern---model-view-controllers)
    - [Building a REST API in C# with ASP.NET Core](#building-a-rest-api-in-c-with-aspnet-core)
    - [Creating a Web App with ASP.NET Core MVC](#creating-a-web-app-with-aspnet-core-mvc)
    - [Dependency Injection Pattern](#dependency-injection-pattern)
  - [Databases](#databases)
    - [Database Basics](#database-basics)
    - [PostgreSQL](#postgresql)
      - [pgAdmin](#pgadmin)
    - [SQL Server](#sql-server)
      - [SQL Server Management Studio (SSMS)](#sql-server-management-studio-ssms)
    - [Entity Framework Core](#entity-framework-core)
  - [NuGet and Libraries](#nuget-and-libraries)
    - [Useful libraries](#useful-libraries)
  - [Other Stuff](#other-stuff)

## C# resources

### Visual Studio Community

https://visualstudio.microsoft.com/vs/community/

Visual Studio is great for working with C#, and it has been used by .NET and ASP.NET Core users for as long as it's been around. Because of this, there are many features that will make programming in Visual Studio feel really simple. I'd recommend it above VS Code specifically for C#.

### C# Programming Guide

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/

This section of documentation has style conventions, information on asynchronous programming in C#, use of attributes, LINQ (Language-integrated query, basically writing a database query in C#), lambda expressions (extremely useful), detailed information about scopes, types, generics, namespaces, and interfaces in C#. Use the sidebar and start reading and you'll have a lot of things in your brain in an hour or two.

### MVC Pattern - Model, View, Controllers

https://dotnet.microsoft.com/apps/aspnet/mvc

You have probably heard of model-view separation during your time in school, and this is an especially important principle in applications that will become as large as your capstone. The MVC pattern is a massive boon to this. Control your database with internal models, control what gets exposed to your users through view models, design a view to deliver the view model in a proper format, and use a controller to transfer data between the internal models and view models. MVC is hands-down one of the best ways to stay organized and is a great way to organize the view-side of a project and connect it with the model-side.

### Building a REST API in C# with ASP.NET Core

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio

Long tutorial, but really awesome. Make sure to read up on MVC before this, as it uses the principles of MVC throughout. This talks about connecting web endpoints that you've designed to the data access layer, typically implemented as a database. While you can't quite see an API endpoint like you can a website, you should really think of it like the 'view' part of MVC. It's what applications will see when they access your web server.

### Creating a Web App with ASP.NET Core MVC

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.1

Nearly the same thing as the REST API, but this time it's deploying a web page. You will notice many things are identical between the two, and that should demonstrate how similar the backend for each is when you set everything up correctly.

### Dependency Injection Pattern

Dependency injection is a design pattern that lets you change different parts of your program without needing to change other parts of your program. Basically, it makes your system more modular, and allows project-specific configuration. You can later go and change the implementation of your system in a single place and it will change throughout your entire project using a service provider and service collections.

- [Dependency Injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1)
- [Dependency Injection in .NET](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)

## Databases

Before I give any more resources about database types, I want to give a broad warning: MySQL isn't very good. It can't do as much as some other DBMS can. Don't choose it because it shows up on Google. I promise it's worth it to use something else, and large-scale applications often depend on functionality that is more difficult to implement in MySQL.

I would recommend choosing between SQL Server and PostgreSQL. If you are building a mobile application, look into SQLite. It's a very lightweight implementation for a SQL database, and it's the item of choice for every mobile app.

I personally enjoy PostgreSQL the most, but admittedly I've worked with it more than SQL Server, so I would be lying if I said I wasn't biased.

### Database Basics

- [What is a database?](https://www.youtube.com/watch?v=_Q07-8e3UbI) isn't a super in-depth video, but if you need to get a super general and quick intro, it's not bad.
- [Database Tutorial for Beginners](https://www.youtube.com/watch?v=wR0jg0eQsZA) specifically outlines the need and usage of a table. It doesn't describe SQL, but it describes the high-level concept of mixing information from multiple tables. It's followed up by more concepts in Lucidchart's online tutorials. Take a look through these, especially if you haven't taken a databases class yet.

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

Read and browse the MVC link above before getting here. Have you ever been worried about messing something up when defining all of your tables in a database? Worried you're going to blow things to bits by muddling up all of your foreign keys? That's a thing of the past. Entity Framework gives you a way to make structural changes to the database through code changes. It also gives you an easy way to access your database tables through code. This is the best way to work with databases in C# and anyone who says otherwise is a *ding*-**a**-*ling*. It supports both PostgreSQL and SQL Server databases.

## NuGet and Libraries

https://www.nuget.org/

NuGet is the package manager for .NET. The NuGet client tools provide the ability to produce and consume packages.

### Useful libraries

This isn't a comprehensive list, but many of these may come into play in your capstone project.

- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) is an amazing library for serializing and deserializing JSON objects into models.
- [Microsoft.Extensions.Logging](https://www.nuget.org/packages/Microsoft.Extensions.Logging/5.0.0-rc.1.20451.14) because you may want to be able to have some reasonable text in your error messages that get thrown back to you. Logging levels go a long way towards this over just `Console.WriteLine()`.
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/5.0.0-rc.1.20451.14) is the go-to library for dependency injection.
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.0-rc.1.20451.13) is God's gift to C# developers in the digital age.
- [Microsoft.AspNet.Mvc](https://www.nuget.org/packages/Microsoft.AspNet.Mvc/) is the library for using the MVC design pattern in ASP.NET.
- [Microsoft.AspNet.WebApi](https://www.nuget.org/packages/Microsoft.AspNet.WebApi/) is the library for designing a web-facing REST API.
- [Moq](https://www.nuget.org/packages/Moq/) is a great mocking library for unit tests.

## Other Stuff

Good luck with your projects this year. As I've said before, I'm always here if you need me. Work together, and work hard. Set high expectations for yourselves through this project and make it your first priority when it comes to your workload this semester. Your capstone will define your education at BSU, and it is the best time to push yourself to become the programmer that you want to be. The capstone project will be going on your resume, it is what you will talk about in interviews, and it is a way to find an employer.
