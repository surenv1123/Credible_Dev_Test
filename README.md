# Credible Developer Test Web Application Project

Creating an ASP.net MVC application that calls to a database to bring back all Clients, client courses, and users taking the courses.

> An end-user can see a list of clients.
> Selecting a client should call to get list of courses for the selected client.
> Selecting a course should bring up list of users registered to the course.
* Display user id, first name, last name, registration date.

> Enable paging on the list of user registrations – 25 rows per page.
> Allow sorting by all fields on the list of user registrations
> Allow filtering based upon registration date on the list of user registrations

## Getting Started

After cloning or downloading the sample you should be able to run it using Visual Studio 2017 and an existing database server: credible.database.windows.net
*Used Asp.net MVC, C#, SQL, Javascript 
*Used Jquery Datatable for Displaying data . it has build in pagination ,sorting & filering features.

### Prerequisites

Visual Studio 2017
credible.database.windows.net

### Installing

No installation required

## How to Use

* Download and open with visual studio 2017
* Debug with any browser, the output will be ~u_portal/Index, which will display list of clients 
https://github.com/surenv1123/Credible_Dev_test/blob/master/Images/Portal_Info.PNG
* selecting any client(portal_nm), will display one popup with list of courses for the selected client.
https://github.com/surenv1123/Credible_Dev_test/blob/master/Images/Course_Info.PNG
* selecting any Course(cource_portal_nm), will display one popup with list of users registered to the course.
https://github.com/surenv1123/Credible_Dev_test/blob/master/Images/Reg_User_Info.PNG







