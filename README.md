***Hair Salon***


*Description*

A simple HairSalon website that allows the user to add the employees(stylists) and under each stylist, he can add the number clients for that particular stylist, can edit and delete them.

*Specs*

Creating a Homepage named HairSalon where an employee can add a Stylist, view all stylists.
Allow the user to add a Stylist using a form.
Once Stylist is added clients can be added to it.
Clients can be updated and deleted.


**Technologies Used**

HTML
CSS
C#
.Net Framework
MVC
Php
SQL

CREATE DATABASE saneyee_sarkar;
USE saneyee_sarkar;
CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
CREATE TABLE clients (id serial PRIMARY KEY, client_name VARCHAR(255), stylist_id INT)

*License*

Copyright (c) 2017 Saneyee Sarkar
