CREATE DATABASE Ass02
USE Ass02
--USE MyStock
--DROP DATABASE Ass02

-- TABLE
CREATE TABLE Members (
	MemberID int PRIMARY KEY,
	Email varchar(100) NOT NULL,
	CompanyName varchar(40) NOT NULL,
	City varchar(15) NOT NULL,
	Country varchar(15) NOT NULL,
	Passwords varchar(30) NOT NULL,
	RoleID int NOT NULL
)

CREATE TABLE Roles (
	RoleID int PRIMARY KEY,
	RoleName varchar(10),
)

CREATE TABLE Orders (
	OrderID int PRIMARY KEY,
	MemberID int NOT NULL,
	OrderDate datetime NOT NULL,
	RequiredDate datetime,
	ShippedDate datetime,
	Freight money
)

CREATE TABLE OrderDetails (
	OrderID int NOT NULL,
	ProductID int NOT NULL,
	UnitPrice money NOT NULL,
	Quantity int NOT NULL,
	Discount float NOT NULL
)

CREATE TABLE Products (
	ProductID int PRIMARY KEY,
	CategoryID int NOT NULL,
	ProductName varchar(100) NOT NULL,
	Weights varchar(20) NOT NULL,
	UnitPrice money NOT NULL,
	UnitsInStock int NOT NULL
)

CREATE TABLE Categories (
	CategoryID int PRIMARY KEY,
	CategoryName varchar(100)
)

-- Foreign key
ALTER TABLE Members ADD FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
ALTER TABLE Orders ADD FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
ALTER TABLE OrderDetails ADD FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
ALTER TABLE OrderDetails ADD FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
ALTER TABLE OrderDetails ADD PRIMARY KEY (OrderID, ProductID)
ALTER TABLE Products ADD FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)

-- Insert data
---- Categories
INSERT INTO Categories(CategoryID, CategoryName) VALUES (1, 'Car')
INSERT INTO Categories(CategoryID, CategoryName) VALUES (2, 'Book')

---- Products
INSERT INTO Products(ProductID, CategoryID, ProductName, Weights, UnitPrice, UnitsInStock) VALUES (1, 1, 'Santa Fe', '2 tons', 60000, 10)
INSERT INTO Products(ProductID, CategoryID, ProductName, Weights, UnitPrice, UnitsInStock) VALUES (2, 1, 'Hyundai Sedan', '3 tons', 75000, 5)
INSERT INTO Products(ProductID, CategoryID, ProductName, Weights, UnitPrice, UnitsInStock) VALUES (3, 2, '48 Laws of Power', '150 grams', 5, 285)
INSERT INTO Products(ProductID, CategoryID, ProductName, Weights, UnitPrice, UnitsInStock) VALUES (4, 2, 'Design Patterns, Elements of reusable Object-Oriented Software', '200 grams', 15, 98)

---- Roles
INSERT INTO Roles(RoleID, RoleName) VALUES (1, 'Admin')
INSERT INTO Roles(RoleID, RoleName) VALUES (2, 'User')

---- Members
INSERT INTO Members(MemberID, Email, CompanyName, City, Country, Passwords, RoleID) VALUES (1, 'admin@gmail.com', 'P&G', 'Ho Chi Minh', 'VietNam', '12345678', 1)
INSERT INTO Members(MemberID, Email, CompanyName, City, Country, Passwords, RoleID) VALUES (2, 'user1@gmail.com', 'FPT', 'Ho Chi Minh', 'VietNam', '12345678', 2)
INSERT INTO Members(MemberID, Email, CompanyName, City, Country, Passwords, RoleID) VALUES (3, 'user2@gmail.com', 'Vietcombank', 'Ho Chi Minh', 'VietNam', '12345678', 2)