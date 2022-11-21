/*Created DB*/
create database ProductsAndCategories
use ProductsAndCategories

/*Created Table of Products*/
create table Products (
	Id int primary key,
	Products_Name varchar(255)
);

/*Created Table of Category*/
create table Category (
	Id int primary key,
	Category_Name varchar(255)
);

/*Inserted Values to Products table*/
insert into Products values
(1, 'Asus vivobook pro 15 oled'),
(2, 'Lenovo Legion'),
(3, 'Macbook Air M1 2020'),
(4, 'Acer Aspire'),
(5, 'Asus Zenbook');

/*Inserted Values to Category table*/
insert into Category values
(1, 'For working'),
(2, 'For games'),
(3, 'For ordinary using'),
(4, 'For kids'),
(5, 'For designers');

/*Created table for categories of the products*/
create table CategoriesForProducts (
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Category(Id)
);

/*Inserted Values to Products and Categories table*/
insert into CategoriesForProducts values
(1, 1),
(1, 3),
(2, 2),
(3, 3),
(3, 1),
(5, 5);

/*Query*/
SELECT Pr."Products_Name", Ct."Category_Name"
FROM Products Pr
LEFT JOIN CategoriesForProducts CtPr
ON Pr.Id = CtPr.ProductId
LEFT JOIN Category Ct
ON CtPr.CategoryId = Ct.Id;
