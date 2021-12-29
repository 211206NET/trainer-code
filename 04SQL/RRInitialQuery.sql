-- Creating a new db in our server, named rrdb
CREATE DATABASE RRDB;

-- turning off super annoying feature ("auto close") that gets enabled by default
ALTER DATABASE RRDB
SET AUTO_CLOSE OFF;

-- Changing to use RRDB db instead of master
USE RRDB;

-- tables take constraints which includes 
-- data type,
-- not null (this column cannot be left empty)
-- unique (you can have duplicates of the data in this column)
-- check (for additional checking)
-- primary key (= not null + unique ), foreign key (use with references keyword)
-- default (for providing default value)
CREATE TABLE Restaurant(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name NVARCHAR(450) NOT NULL UNIQUE,
    City NVARCHAR(100),
    State NVARCHAR(50)
);


CREATE TABLE Review(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Rating INT NOT NULL,
    NOTE NTEXT,
    RestaurantId INT FOREIGN KEY REFERENCES Restaurant(Id) NOT NULL
);

-- If you want to alter your table structure use ALTER TABLE <table-name>
-- If you want to completely remove the table and its structure, 
-- use DROP TABLE <table-name>; (DDL)
-- If you want to just remove one or more records in a table,
-- use DELETE FROM <table-name> ... (DML)
-- If you want to delete ALL records in a table, but keep the structure
-- use TRUNCATE keyword

DROP TABLE Review;
DROP TABLE Restaurant;
-- TRUNCATE TABLE Restaurant;

-- Inserting data is part of DML sublanguage, and we use INSERT keyword
INSERT INTO Restaurant (Name, City, State) VALUES
('Salt and Straw', 'Seattle', 'WA');

Select * FROM Restaurant;
Select * FROM Review;

INSERT INTO Review (RestaurantId, Rating, Note) VALUES (1, 5, 'AMAZING ICE CREAM');

-- Deleting all records from restaurant with the word Taco in its name
Delete FROM Restaurant Where Name like 'Salt%';

Update Restaurant
SET City = 'Portland', State = 'OR'
WHERE Name = 'Salt and Straw';