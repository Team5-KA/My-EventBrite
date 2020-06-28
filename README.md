# MyEventBrite

### Table of Contents
- [Description](#description)
- [Requirements](#requirements)
- [How to use](#how-to-use)
- [Technology Stack](#technology-stack)
- [Authors](#authors)
- [Thank you](#thank-you)

## Description
#### Final Product
Our end goal is to build a web application similar to www.EventBrite.com that allows a user to organize events by creating online invitations, processing payments and track event related data. 
It also allows users to view and/or sign up for events. We plan to use various Microservices such as Catalog and SignUp to build the Application. We plan to host the application on Docker containers.

#### Phase 1 Current Phase
For Assignment 3a our goal is to build a back-end Events Catalog Service with seeded test data stored on local SQL database that lets the user test API options. The output is a key-value pair in JSON format. 
Examples include viewing picture associated to an event picture number or viewing event details by location or type of event.

## Requirements
Software to be installed to run or test the application
- Visual Studio 2019 
- Postman https://www.getpostman.com/

## How to use
#### Demo
Here's a YouTube link showing a demo of the project:
https://www.youtube.com/watch?v=wXy-2fKhtzA

#### Steps
1. Download or Clone the project from the Github and open in Visual Studio.
2. In Visual Studio "Package Manager Console" window, use the command "Add-Migration" (give a name for the Migration e.g. Add-Migration Initial).
3. Run using "IIS express". 
(Caution - Re-running the application will give error because Ids will be reproduced and will not match with referenced Ids. 
Therefore close out of the application and reopen, delete the Eventdb (if it exists) from "Sql Server Object Explorer" and the "Migration" folder (if it exists) from the Solution and follow steps 2 and 3 above.)
4. Open the Postman App to test the API's below.

#### APIs to test
##### 1. [Pic controller](https://localhost:44397/api/pic/4)

##### 2. [Event Controller](https://localhost:44397/api/Event/eventitems?pageIndex=0&pageSize=5)

##### 3. [Filter using page reference](https://localhost:44397/api/Event/EventLocations?pageIndex=0&pageSize=2)

##### 4. [Filter using event type, category and subcategory](https://localhost:44397/api/Event/eventitems/type/1/category/1/subCategory/4?pageIndex=0&pageSize=1)

##### 5. [Filter using location and event type, category, subcategory](https://localhost:44397/api/Event/items/location/2/type/1/category/1/subCategory/4?pageIndex=0&pageSize=1)

## Technology Stack
The technology stack used to build the application includes:
- Windows 10 Professional or better
- Visual Studio 2019 Community Edition or better
- C#
- .Net Core
- Docker Desktop
- Nuget Packages v.3.1.5: 
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Relational
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
- For testing the App: Postman https://www.getpostman.com/

## Authors
*** Tapasya Khatri *** Adarsha Kuthuru *** Hrudya Nair *** Vidhya Sambandan ***

## Thank You
We'd like to thank our instructor, Kal and all the TA's at KalAcademy for their excellent guidance and support. 







