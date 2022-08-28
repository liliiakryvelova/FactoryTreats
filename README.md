# An application to market sweet and savory treats. This application should keep an authentication and a many-to-many relationship.  

#### By Liliia Kryvelova

https://github.com/liliiakryvelova/FactoryTreats.git

#### You have to build an MVC web application to manage their treats, and the flavors they are listed for. The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.

## Technologies Used

* _ASP.NET Core MVC_
* _Razor_

## Description

* _We want to establish a many-to-many relationship between the Treat and Flavor entities where many Treats are associated with many Flavors. It means that each Treat entity points to an Flavor. When we create a many-to-many relationship between two classes, we need to include a navigation property. This is simply a property on  one class that includes a reference to a related class. Our navigation property is called JoinEntities and it is a collection of EngineerMachine._

* _Before we build our project and use Entity to create and run our migrations, we'll have to do a bit more configuration to our application. Create a file called DesignTimeDbContextFactory.cs inside of the Models folder with the specific code._

* _A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it_
* _There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on._


## Setup/Installation Requirements

* _Clone this git on your local computer *For clonning: use button Clone -> from repository. *Copy the clone command(SSH format or HTTPS)._
* _From a terminal on your local computer, use command "cd" to find the directory where you want to clone this repository. *Type the command ($ git clone HTTPs)._
* _If you clone successfully , a new sub-directory appears on your local computer. *For working with project, run : dotnet restore._
* _In the next step, run: dotnet build._
* _For running the project, run -> dotnet run(in the cmd or terminal)._ 
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=[YOUR_PASSWORD]" } }_



## Known Bugs


## License


Copyright (c) _8-13-2022_ _Liliia Kryvelova(s)_
