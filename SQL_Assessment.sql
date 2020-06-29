--CREATE TABLE Products -- ...

-----------

INSERT INTO Products (Name, Price) VALUES
('bag', $0.00),
('box', $0.01),
('banjo', $5.00);

INSERT INTO Orders (ProductID, CustomerID) VALUES
(2, 2),
(1, 1),
(3, 3);

INSERT INTO Customers (FirstName, LastName, CardNumber) VALUES
('me', $0.00, '1234567890123457'),
('mysf', $0.01, '1234567275123456'),
('aye', $0.00, '7089567890125376');

-----

INSERT INTO Products (Name, Price) VALUES
('iPhone', $200.00);

-------

INSERT INTO Customers (FirstName, LastName, CardNumber) VALUES
('Tina', 'Smith', '1234567890123456');

------- Buy iPhone

INSERT INTO Orders (ProductID, CustomerID) VALUES
(
	(SELECT ProductID FROM Products WHERE Name='iPhone'),
	(SELECT CustomerID FROM Customers WHERE FirstName='Tina' AND LastName='Smith')
);

------ Get Tina's orders
SELECT * FROM Orders WHERE CustomerID = (SELECT CustomerID FROM Customers WHERE FirstName='Tina' AND LastName='Smith')

------ 