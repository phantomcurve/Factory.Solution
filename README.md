# Dr. Sillystringz's Factory

#### A slick little web app for the sly doctor to use to manage his engineers and all his evil machines

#### By Tim Roth

## Description

This Epicodus project creates a C# MVC web app for a factory that is connected to a database to allow the factory manager to add engineers and machines and manage the relationships between them to track machine repairs effectively.

## User Actions

* View splash page with a welcome message and links to view client and stylist lists
* Select `Clients` link to view the current list of stylists
* Select `Add New Client` link to add a client to the list
* Submitting new client redirects user to the clients page
* Selecting `See All Stylists` on `Index` or `Stylist` page shows all stylists at the salon
* Selecting `Add Stylist` link directs user to a form to add a stylist
* Submitting new stylist redirects user to `Stylist` index page
* `Client` index page shows all clients and their preferred stylist
* Selecting an individual stylist shows a list of all clients belonging to that stylist

## Technologies Used

* C#
* ASP.NET&#8203; Core
* Razor
* MySQL Workbench
* Markdown
* VS Code
* Terminal
* Github

## Setup/Installation Requirements

### Prerequisites

* [.NET](https://dotnet.microsoft.com/)
* A text editor–we prefer [VS Code](https://code.visualstudio.com/)
* [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)

### Installation

1. Open terminal on your machine
2. Clone the repository: `git clone https://github.com/phantomcurve/HairSalon.Solution.git`
3. Navigate to the `\HairSalon` directory
4. Open with your preferred text editor to view the code


### MySQL  and MySQL Workbench Configuration
1. Download and install [MySQL](https://dev.mysql.com/downloads/file/?id=484914) by selecting `No thanks, just start my download`
2. Follow along with Installer until reaching `Configuration` page
3. Select `Use Legacy Password Encryption`
4. Set password as desired 
5. Click `Finish`
6. Open Terminal and enter command `echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`
7. Type `source ~/.bash_profile` to verify successful MySQL installation
8. Download and install [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)
6. Open MySQL Workbench and select Administration tab in upper left of navigator window
7. Select `Data Import/Restore` 
8. Select `Import from Self-Contained File`
9. Navigate to HairSalon.Solution folder and select tim_roth.sql
10. With the `Default Schema to be Imported To` dropopdown menu, select `New`
11. Name your new schema `hair_salon` and click `ok`
12. Click `Start Import` at bottom right of navigator window

### appsettings.json configuration

1. Navigate to `\HairSalon` directory in VSCode
2. Create a file in this directory called `appsettings.json`
3. In this file add the following: 
``{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=[YOUR PASSWORD HERE & DELETE THESE SQUARE BRACKETS!];"
  }
}``


* #### Run the Program

1. Navigate to the `\HairSalon` directory
2. Run `dotnet restore`
3. Run `dotnet build`
4. Start the program with `dotnet run`
5. Open http://localhost:5000/ in your preferred browser

## Known Bugs

* None

## Contact Information

* Tim Roth [timdroth@gmail.com](mailto:timdroth@gmail.com)

## License

* MIT License 
Copyright (C) [2021] [Tim Roth]
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.