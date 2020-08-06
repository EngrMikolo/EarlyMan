# ![EarlyMan](logo.png)

EarlyMan Inc serves as a portfolio website. It tries as much as possible to adhere to best practices.

This codebase was created for the purpose of encouraging the sale of local artwork(my other passion ). It is a fullstack application built with ASP.NET Core( with Feature orientation) including CRUD operations, authentication, routing, deployment, security, pagination, unit-testing e.t.c.(coming-soon)

## How it works

This is using ASP.NET Core with:
[Entity Framework Core](https://docs.microsoft.com/en-us/ef/) on SQLite for demo purposes. Can easily be anything else EF Core supports. Open to porting to other ORMs/DBs, but EFCore is used because of it'S good interop with VS2019.

## Getting started

Install the .NET Core SDK(2.0)[https://dotnet.microsoft.com/download/dotnet-core/2.0](https://dotnet.microsoft.com/download/dotnet-core/2.0)
Using libman found in the VS19 IDE install

Bootstrap(Search for twitter-bootstrap): or use this direct link and add it to the wwwRoot folder [https://getbootstrap.com/docs/4.0/getting-started/download/](https://getbootstrap.com/docs/4.0/getting-started/download/)

Font-awesome(latest-version using libman): [https://fontawesome.com/download](https://fontawesome.com/download)

## Local building

- It's just another C# file!   `dotnet run -p build/build.csproj`
