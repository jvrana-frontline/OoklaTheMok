# OoklaTheMok
To make it easy, the app assumes a SQL Server database on localhost with the tables in it using integrated security.

Usage:
```
OoklaTheMok.exe <table>
```
Where <table> is the table that you want to generate the API for.  
Example: 
```
OoklaTheMok.exe tbl_Purposes
```
This will create a folder structure on your c:\ drive:
```
  C:\Ookla
  ├── Purpose
      ├── AutoMapper
      │   └── Profiles
      |       └── PurposeMapProfile.cs
      ├── Controllers
      |   └── PurposeController.cs
      ├── Entities
      |   └── Purpose.cs
      ├── EntityMaps
      |   └── PurposeMap.cs
      ├── Services
      │   └── Interfaces
      |   |   └── IPurposeService.cs
      |   └── PurposeService.cs    
      ├── Tests
      │   └── Controller
      |   |   └── PurposeControllerTests.cs
      │   └── Services
      |   |   └── PurposeServiceTests.cs
      ├── ViewModels
      |   └── PurposeModel.cs   
      └── AdditionalLines.cs
``` 
* With the exception of the Test Folder, all of the remaining folders can be merged into the pg-msvc-plm-eem-api\src\FL.PG.PLM_EEM_API folder.
* The folders in test should be merged into pg-msvc-plm-eem-api\tests\FL.PG.PLM_EEM_API.Tests
* The AdditionalLines.cs file will contain the lines that need to be added to Startup.cs and PlmContext.cs
```
Add to appropriate sections of PlmContext.cs:

        DbSet<Purpose> Purposes { get; set; }
        modelBuilder.ApplyConfiguration(new PurposeMap());
        public virtual DbSet<Purpose> Purposes { get; set; }


Add to appropriate sections of Startup.cs:

        services.AddScoped<IPurposeService, PurposeService>();
```
