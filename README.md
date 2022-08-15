# _{An application to keep track of the machine repairs}_

#### By _**{Liliia Kryvelova}**_

https://github.com/liliiakryvelova/Factory.git

#### _{You have to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.}_

## Technologies Used

* _ASP.NET Core MVC_
* _Razor_

## Description

* _We want to establish a many-to-many relationship between the Engineer and Machine entities where many Engineers are associated with many Machines. It means that each Engineer entity points to an Machine. When we create a many-to-many relationship between two classes, we need to include a navigation property. This is simply a property on  one class that includes a reference to a related class. Our navigation property is called JoinEntities and it is a collection of EngineerMachine._

* _Before we build our project and use Entity to create and run our migrations, we'll have to do a bit more configuration to our application. Create a file called DesignTimeDbContextFactory.cs inside of the Models folder with the specific code._

* _As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines._
* _As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it._
* _As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed._
* _As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed._
* _As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine._
* _User should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it._

## Setup/Installation Requirements

* _Clone this git on your local computer *For clonning: use button Clone -> from repository. *Copy the clone command(SSH format or HTTPS)._
* _From a terminal on your local computer, use command "cd" to find the directory where you want to clone this repository. *Type the command ($ git clone HTTPs)._
* _If you clone successfully , a new sub-directory appears on your local computer. *For working with project, run : dotnet restore._
* _In the next step, run: dotnet build._
* _For running the project, run -> dotnet run(in the cmd or terminal)._ 



## Known Bugs


## License


Copyright (c) _8-13-2022_ _Liliia Kryvelova(s)_
