# _Find a Local Park API | an Epicodus Code Review_

#### By Zachary Green

#### _This project is a demonstration of how to build a Restful API using C# using the `dotnet new webapi` terminal command and building out the classes and controllers. This project was possible under the guidance of Epicodus https://www.epicodus.com/_

## Technologies Used

* `C#`
* `Microsoft Entity Framework`
* `ASP.NET Core MVC`
* `Postman`
* `mySQL Workbench`

## Description

_This API will let a user Get, Post, Put, Edit, Delete content related around Parks. They can create a new Park with the post method giving parameters of name, city, trails and notes. This project is just the API, so it will be needed to be added to a MVC application or tested using Postman._

## API Endpoints
<hr>
<strong>GET</strong>
<hr>
 You can get data back from your api via the localhost by using several different parameters. This api defaults with the standard index which would be `http://localhost:5000/api/Park`. This will pull up all results from the database.

 #
 However you can also search for specific results by adding a query or `?` after /Park and one of the class parameters such as: `http://localhost:5000/api/Park?city="Fortuna"`.

 #
 You can also search by 2 specific fields as well with the `&` seperating the 2 queries. So for example: `http://localhost:5000/api/Park?city="Fortuna"&Name="Rohner"`

#
<hr>
<strong>PUT</strong>
<hr>
With this feature you can edit values inside of your database. This can be easily seen inside of Postman and is useful for Modfiying a Typo or changing a field without having to delete the entry and create a new one. 

#
<hr>
<strong>POST</strong>
<hr>
This feature will let you create new content for your database. This can be easily done within `Postman` and the results can be seen inside on your Parks table in `MySQL Workbench`, `MySQL Server` or `Postman` with Postman's `GET`.

#
In `Postman`, change the `GET` drop down to `POST`, then in the first window below where your localhost address goes select the paramter for `Body` and make sure the drop down window is changed to `Json`. You will be able to create brand new entries in this window. Note that any new entry must contain all the parameters stated in the Park class within the Models folder.

#
<hr>
<strong>DELETE</strong>
<hr>
This feature will let you delete an entry or the entire database if you would like. Those result will vary on the search parameters.

#

Please be aware that IDs are unique in databases and will never be repeated, so if you delete an entry and later decide you would like to re-add them, you will need to create a new ID.

#


## Setup/Installation Requirements

<strong><em>Requirements for Running the Project</em></strong>
#

### Programs You Will Need
#

1. MySQL Server - visit https://www.mysql.com/downloads/ and download mySQL Server, follow the installation instructions for your operating system.

2. MySQL Workbench - visit https://www.mysql.com/products/workbench/ and download mySQL Workbench, follow the installation instructions for your operating system.

3. Postman - vist https://www.postman.com/downloads/ and download Postman, follow the installation instructions for your operating system.

4. VSCode - visit https://code.visualstudio.com/ and download VSCode, follow the installation instructions for your operating system.

Developer Note -- <em>You do not need to type in `$` into the terminal, the terminal starts with `$` on GitBash and `%` on Bash.</em>

* Visit https://github.com/Ultra-Zactimus/LocalParks
* Clone this repository to your desktop.
* Navigate to the top level directory in your terminal.
* Run "$ `touch appsettings.json`"
* Run "$ `code .`" to open the project in VS Code. If you do not have VS Code please visit their website: https://code.visualstudio.com/
* Add in this code to the `appsettings.json` file inside `VS Code`:

{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=find_a_park;uid=root;pwd=[YOUR_PASSWORD_HERE];"
  }
}

* Create a gitignore file. Run "$ `touch .gitignore`" on the top level of the project.
* Inside of `VS Code` type in `appsettings.json` into the gitignore file. This will keep your password safe.
* Change the password to be whatever password you will want to use with SQL.


Developer Note -- <em>You do not need the square brackets around the password field in the appsettings.json file, they are included only to demonstate where the password needs to be.</em>

* Run "$ `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`"
* Run "$ `dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0`"
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet build`" to build the project.
* Run "$ `dotnet ef migrations add Initial`"
* Run "$ `dotnet ef database update`"
* Run "$ `dotnet run`" to launch a LocalHost.
* Open Postman. The front page should have a section with a button to the left that says `GET` by defualt. This is where you will put your `localhost` address in.
* Click `SEND` to get a look at all of the data inside of the database of the API, by default there is seeded data in the `LocalParkContext.cs` file, but you can add your own data with the `POST` method.


## Known Bugs

No known bugs at this time

## Stretch Goals

* I wanted to implement Pagination and the skeleton of it is still in my code, but commented out. I was running into the problem of getting Postman to actually accept the Pagination files and it required changing a ton of code. I was afraid that it might make some of the other functionality of the default MVP not functional.

## License

MIT

Copyright © 2022 Zachary Green