# Dr. Sillystringz's Factory

#### A slick little web app for the sly manager to use to manage his engineers and all his evil machines

#### By Tim Roth

## Description

This Epicodus project creates a C# MVC web app (for a fun, fictional factory) that is connected to a database to allow the factory manager to add engineers and machines and manage the relationships between them to track engineer-qualified machine repairs effectively.

## User Actions

* View splash page with a welcome message, lists of all current engineers and machines, and links to view standalone machine and engineer lists
* Select `See all machines` link to view the current list of engineers
* Select `Add New Machine` link to add a new machine to the list
* Submitting new machine redirects user to the `Machines` index page
* Selecting an individual machine shows a list of all engineers who can service the machine
* Selecting `See all engineers` on `Index` or `Engineer` page shows all engineers (with clickable detail links) at the factory
* Selecting `Add Engineer` link directs user to a form to add an engineer
* Submitting new engineer redirects user to `Engineer` index page
* `Machine` index page shows all machines and their designated engineer(s)
* Selecting an individual engineer shows a list of all machines serviced by that engineer
* Selecting `Edit Machine` or `Edit Engineer` allows user to add new or additional pairings for that machine or engineer
* Deleting a machine from an engineer or an engineer from a machine does not delete the anything other than the association between the two

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
* A code editor–we prefer [VS Code](https://code.visualstudio.com/)
* [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)

### Installation

1. Open terminal on your machine
2. Clone the repository: `git clone https://github.com/phantomcurve/Factory.Solution.git`
3. Navigate to the `\Factory` directory
4. Open with your preferred text editor to view the code

### appsettings.json configuration

1. Navigate to `\Factory` directory in VSCode
2. Create a file in this directory called `appsettings.json`
3. In this file add the following: 
``{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=[YOUR PASSWORD HERE & DELETE THESE SQUARE BRACKETS!];"
  }
}``

### Run the Program – using .NET EF Core Code-First Setup

1. Make sure you have navigated to the `\Factory` directory
2. Make sure you have the MySql Workbench application open and that the server is running
3. Run `dotnet restore`
4. Run `dotnet build`
5. Run `dotnet ef database update`
6. Start the program with `dotnet run`
7. Open http://localhost:5000/ in your preferred browser

### Manual MySQL and MySQL Workbench Configuration (if you like working harder, not smarter)
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
9. Navigate to Factory.Solution folder and select `tim_roth.sql`
10. With the `Default Schema to be Imported To` dropdown menu, select `New`
11. Name your new schema `factory` and click `ok`
12. Click `Start Import` at bottom right of navigator window

## Known Bugs

* User can add multiple join relationships between engineers and machines

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