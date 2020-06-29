CREATE TABLE NewEmployee (
    ID int NOT NULL,
    FirstName varchar(255),
    LastName varchar(255),
    SSN varchar(255),
	DeptId int
);

CREATE TABLE EmpDetails (
    ID int NOT NULL,
    EmployeeId int,
    Salary float,
	Address1 varchar(255),
	Address2 varchar(255),
	City varchar(255),
	State varchar(255),
	Country varchar(255)
);

CREATE TABLE Department (
    ID int NOT NULL,
    Name varchar(255),
    Location varchar(255),
);
--//////////////////////////////////////
ALTER TABLE Department MODIFY ID "varchar";


INSERT INTO Department (ID, Name, Location) VALUES
(0, 'Downtown', 'STL'),
(1, 'Uptown', 'Updog'),
(2, 'Allround', 'Lake');

INSERT INTO EmpDetails (ID, EmployeeId, Salary, Address1, Address2, City, State, Country) VALUES
(0, 0, 100000.01),
(1, 1, 100000.02),
(2, 2, 100000.03);

INSERT INTO NewEmployee (ID, FirstName, LastName, SSN, DeptId) VALUES
(0, 'William', 'Nesh', '123456789', 0),
(1, 'John', 'Updogo', '231549876', 1),
(2, 'Nick', 'Luke', '132456879', 1);


SELECT * FROM Employee where ReportsTo is not null

SELECT * FROM Employee where ReportsTo in (select EmployeeId from Employee where ReportsTo is null)

SELECT * FROM Employee Inner Join (select EmployeeId from Employee where ReportsTo is null) foo on Employee.EmployeeId = foo.EmployeeId

SELECT * FROM Employee Inner Join (select distinct ReportsTo from Employee) foo on Employee.EmployeeId = foo.EmployeeId


select e.lastname as Employee, m.lastname as Manager from Employee e, Employee m
where m.EmployeeId = e.ReportsTo

select count(*) from Employee

select FirstName, LastName from Employee  


SELECT * 
FROM Employee
INNER JOIN
(
    SELECT 
          EmployeeId
    FROM
          Employee
    GROUP BY
          EmployeeId

) foo
ON Employee.EmployeeId = Foo.EmployeeId;

SELECT * FROM NewEmployee AS ne WHERE ne.LASTNAME = 'Updogo'
GO
--///////////

CREATE SCHEMA School
GO

--1 it's a pain to modify keys
--2 Composit keys mean your foreign keys would also have to be multiple columns
--what kinds of ID columns do we introduce?
-- -- 1. Incrementing integer starting at 1 (IDENTITY)
-- -- 2. GU(Globally Unique)ID random really long number
-- -- 3. hi-lo sequence, some of advantages of both

CREATE TABLE School.Student (
	ID INT IDENTITY(1, 1),
	Name NVARCHAR(200) NOT NULL
);

--ALTER TABLE School.Course...
--DROP TABLE School.Course
CREATE TABLE School.Course (
	ID INT NOT NULL,
	CourseNumber NVARCHAR(10) NOT NULL,
	SectionNumber NVARCHAR(10),

);

ALTER TABLE School.Student
	ADD CONSTRAINT PK_Student_Id PRIMARY KEY (ID);

ALTER TABLE School.Course
	ADD CONSTRAINT PK_Student_Id PRIMARY KEY (ID);


CREATE TABLE School.Enrollment(
	StudentId INT NOT NULL,
	CourseId INT NOT NULL,
	CONSTRAINT PK_Enrollment_StudentId_CourseId PRIMARY KEY (StudentId, CourseId),
	CONSTRAINT PK_Student_StudentId FOREIGN KEY (StudentId)
		REFERENCES School.Student (Id) ON DELETE CASCADE ON UPDATE CASCADE
);




-- Constraints
-- -- IDENTITY
-- -- NULL (No constraint)
-- -- NOT NULL
-- -- PRIMARY KEY: (UNIQUE NOT NULL)
-- -- FOREIGN KEY: (Carry ref to another column)
-- -- UNIQUE
-- CHECK - Check any expression to be true for a row ... CHECK(Id > 0)
-- DEFAULT 


-- when modeling data, an aspect of their relationship is called multiplictiy.
-- Between X and Y, the multiplicity might be...
--   one-to-one - (ex. Person and PersonDetails)
--        technically impossible in SQL between 2 tables - can do one-to-(zero-or-one)
--            with a UNIQUE NOT NULL FOREIGN KEY on one of the tables
--  many-to-one - (One customer places many orders, each order is placed by one customer
--  many-to-many - requires 2 tables
--     We have a third table for the relationship itself.
--      having two UNIQUE NOT NULL FOREIGN KEYs pointing to the main two tables


