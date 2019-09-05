# Animal Shelter

#### _Animal shelter application that allows for the creation of animals in an API using MVC for CRUD - August 2019_

#### _By **Erik Irgens**_

## Description

This application was intended to learn more closely the details of how to separate an MVC and an API application to work together dependantly, with the MVC making full CRUD calls to the API in the backend. For now, this application takes the form of an animal shelter where you may create new animals.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User can create a new animal in the MVC and have it populate the API** | New animal creation | API is updated with user's information  |
| **User should be able to delete, edit, and view details of each animal** | Animal is clicked | Animal details will appear in the correct path  |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/erik-t-irgens/AnimalShelter_Mvc-API
    ```
2. Run each application in their root directories (MVC and API directories)
    ```
    $ dotnet run
    ```
3. Visit the MVC localhost:5000/
    ```
    localhost:5000/
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#/.NET, ASP.NET Core 2.2, MVC/API architecture, Linq

## Support and contact details

_Please contact Erik Irgens with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Erik Irgens_**
