
# **Flight Management System**

A FMS inspired by the **Qatar Airways** color palletes and its posters/visuals.
<br/>
This Project consists of **Two Projects**:
1. Aviate **(Backend)**
2. FMS **(UI)**

### **Note:**
To open the project in **Visual Studio**,
open the **Solution File** in **FMS** project.
It will connect to **Aviate** itself.



## Table of Contents

1. [Introduction](#introduction)
2. [Build](#build)
3. [DataBase Construction](#dbconstruction)
4. [Authors](#authors)
## **Introduction**
It's an End of Semester project for the course ***Database Design***
. It uses ***[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)*** as the **ORM** and **[LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)** (Language Integrated Query) for Database CRUD. UI is built using **[WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-8.0)** for .NET and an Open-Source UI Components Library **[ReaLTaiizor](https://github.com/Taiizor/ReaLTaiizor)**.
<br/>
Some of the **features** of the projects are:
<br/>
1. Image Upload **(See @"/Aviate/Utils/Imaging.cs").**
2. E-mailing for sign-up OTP **(See @"/Aviate/Utils/Email.cs").**
3. Live Auditing of Actions on Database **(See @"/Aviate/Services/NotficationPoolingService").**
4. Flight Rescheduling Notification to passengers **(See @"/Aviate/Services/NotficationPoolingService").**
5. Application is majorly **[Asynchronous](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)**.

<p align="center">
<img src="https://skillicons.dev/icons?i=git,visualstudio,dotnet,cs,materialui" />
</p>

## **Build**
### **Note:** 
Set **FMS** project as the ***Starting Project***.
</br>
</br>
![Set FMS as startup project](images/SetAsStartup.gif)
<br/>
Screen Capture Using **[ShareX](https://getsharex.com/)**
<hr></hr>
</br>

**Visual Studio** is automatically going to
to manage all of the listed dependencies
</br>
</br>
***[/images/depts.png]***
<br/>
![Aviate Dependencies](/Images/depts.png)
</br>

***Otherwise*** install them manually one-by-one using ***Nuget Package Manager***.
</br>
</br>
***[/Images/Nuget.gif]***
![Nuget Package Manager](/Images/Nuget.gif)

## **DBConstruction**
This Project uses an ORM ***[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)*** to handle the database part. In my case, I connected to **Oracle 11g** database, but you can connect any to any database just change the settings in **[@"Aviate/dbcontext/dbcontext.cs"]**
***OnConfiguring*** functions and change the connection string and version accordingly.

**To construct the Database** take a look at Migrations in ***[@"Aviate/Migrations"]***. **Delete** the migrations and create from scratch. Only the **NotificationContext** and **AviateContext** needs migrations.

***Copy the following commands one-by-one and run them on Visual Studio - Package Manager Console***

```powershell
add-migration -Context NotificationContext AnyNameForMigration
```

```powershell
add-migration -Context AviateContext AnyNameForMigration
```

**Applying**


```powershell
update-database -Context NotificationContext
```

```powershell
update-database -Context AviateContext
```

**NOTE**: If you are specifically working with ***Oracle 11g***
you are likely to get this error:
<p style="color:tomato;font-weight:bold">ORA-02000: missing ALWAYS keyword</p>
</br>

***[images/addMigration.gif]***
![Always Keyword Error demonstration](images/addMigration.gif)


### **Solution**
<hr>
Just remove a line in the migration file that adds **Always identity** to the id of the table. **(If you do this then you have to have a custom mechanism to assign ids to every record that you enter. I have it in the @"/Aviate/CRUD/CRUD.cs")**.

***[/images/AlwaysError.gif]***
![Remove Annotation](/images/AlwaysError.gif)

## **Authors**

This Project is created by [Shayan Zawar](https://github.com/SHAYANZAWAR).
