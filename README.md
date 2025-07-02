# Contact Book

This is a Windows Forms application written in C#.  
It allows users to manage contacts with the following fields:

- First name
- Last name
- Phone number
- Email

## Purpose

The purpose of this project was to learn how to:

- Build a graphical user interface using WinForms
- Structure a C# project with reusable classes
- Connect to a PostgreSQL database from C#
- Store and retrieve real data using SQL
- Deploy a functional app with persistent storage

This project served as a practical exercise in integrating database operations into a real-world application.

## Features

- Custom layout with rounded window corners and no system border
- Add, search and delete contacts via graphical interface
- PostgreSQL database integration for persistent storage
- Load all contacts on application startup
- Clean separation of UI and data access

## Technologies

- .NET WinForms (.NET 6+)
- C#
- PostgreSQL
- Npgsql (ADO.NET provider for PostgreSQL)

## Getting Started

1. Install PostgreSQL and create a database named `kontaktbuch`
2. Execute the following SQL statement to create the table:

```sql
CREATE TABLE kontakte (
    id SERIAL PRIMARY KEY,
    name TEXT NOT NULL,
    lastname TEXT,
    phone TEXT,
    email TEXT
);
