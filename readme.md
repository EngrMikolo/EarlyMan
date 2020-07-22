# ![EarlyMan](logo.png)

EarlyMan Inc serves as a portfolio website. It tries as much as possible to adhere to best practices.


This codebase was created for the purpose of encouraging the sale of local artwork(my other passion ). It is a fullstack application built with ASP.NET Core( with Feature orientation) including CRUD operations, authentication, routing, deployment, security, pagination, unit-testing e.t.c.

## How it works

This is using ASP.NET Core with:

- CQRS and [MediatR](https://github.com/jbogard/MediatR)
  - [Simplifying Development and Separating Concerns with MediatR](https://blogs.msdn.microsoft.com/cdndevs/2016/01/26/simplifying-development-and-separating-concerns-with-mediatr/)
  - [CQRS with MediatR and AutoMapper](https://lostechies.com/jimmybogard/2015/05/05/cqrs-with-mediatr-and-automapper/)
  - [Thin Controllers with CQRS and MediatR](https://codeopinion.com/thin-controllers-cqrs-mediatr/)
- [AutoMapper](http://automapper.org)
- [Fluent Validation](https://github.com/JeremySkinner/FluentValidation)
- Feature folders and vertical slices
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/) on SQLite for demo purposes. Can easily be anything else EF Core supports. Open to porting to other ORMs/DBs.
- Built-in Swagger via [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [Bullseye](https://github.com/adamralph/bullseye) for building!
- JWT authentication using [ASP.NET Core JWT Bearer Authentication](https://github.com/aspnet/Security/tree/master/src/Microsoft.AspNetCore.Authentication.JwtBearer).

This basic architecture is based on this reference architecture: [https://github.com/jbogard/ContosoUniversityCore](https://github.com/jbogard/ContosoUniversityCore)

## Getting started

Install the .NET Core SDK(2.0) and lots of documentation: [https://dotnet.microsoft.com/download/dotnet-core/2.0](https://dotnet.microsoft.com/download/dotnet-core/2.0)

Documentation for ASP.NET Core: [https://docs.microsoft.com/en-us/aspnet/core/](https://docs.microsoft.com/en-us/aspnet/core/)

Using libman found in the VS19 IDE install
Bootstrap(Search for twitter-bootstrap): or use this direct link and add it to the wwwRoot folder [https://getbootstrap.com/docs/4.0/getting-started/download/](https://getbootstrap.com/docs/4.0/getting-started/download/)

Font-awesome(latest-version using libman): [https://fontawesome.com/download](https://fontawesome.com/download)

## Local building

- It's just another C# file!   `dotnet run -p build/build.csproj` on power shell
