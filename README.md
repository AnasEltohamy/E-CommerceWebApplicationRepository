# E-Commerce Web Application

## Project Overview

The **E-Commerce Web Application** is a company management system built to organize internal departments and manage employees within each department.

The core features of the application include:

- Creating and managing departments within the company.
- Adding, updating, and deleting employees under specific departments.
- Each employee is directly linked to a department to ensure organized data.
- Full CRUD (Create, Read, Update, Delete) operations for both departments and employees.

This system helps companies maintain structured records and facilitates efficient employee and department tracking.

---

## Features

- Department Management (Add, Edit, Delete)
- Employee Management (Add, Edit, Delete)
- Department-wise employee listing
- Clean and responsive user interface
- Built with scalable architecture to support future enhancements

---

## Prerequisites

To run the project successfully, make sure the following tools are installed in your environment:

- Visual Studio 2022 or later, with:
  - ASP.NET Core support  
  - Entity Framework Core  
  - NuGet Package Manager

- Microsoft SQL Server  
  It is recommended to use SQL Server Management Studio (SSMS) for easier database management.

---

## How to Run the Project

1. **Restore the Database**  
   - Locate the backup file named: `database_backup.bak`  
   - Restore it using SQL Server.

2. **Configure the Database Connection**

- In the project's configuration file (`appsettings.json`), set the server name to:  
  `" your server name"` (indicating the local SQL Server instance).  
- Alternatively, you can also manually change the server name inside **SQL Server** to `"."` to ensure proper connectivity.


3. **Open the Project**  
   - Launch Visual Studio and open the solution file.  
   - Wait a few seconds for NuGet packages to restore automatically.

4. **Run the Application**  
   - Press F5 or click Run to launch the application.

5. **Log in and Use the System**  
   You can either:
   - Register a new account through the registration page.  
   - Or use the pre-configured test account:
     - Email: `anas@gmail.com`  
     - Password: `Eelu20-00236`

---

## Important Notes

- Ensure that SQL Server is running before launching the application.
- The database must be restored before attempting to log in or use the system.

---

## Technical Details :

- The project is built using ASP.NET MVC/Core, and follows Clean Architecture principles, implementing:
  - Repository Pattern
  - Unit of Work Pattern

- Facial recognition algorithms are integrated into the system logic to analyze and match facial features with previously stored images, enabling accurate identity detection for children.
