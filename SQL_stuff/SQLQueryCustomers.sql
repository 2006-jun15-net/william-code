--SELECT * FROM Customer

--SELECT * FROM Customer WHERE Country='Brazil';

--SELECT * FROM Employee WHERE Title LIKE '%Sales%agent%';

--SELECT SUM (dbo.Invoice.Total) AS 'CashMoney' FROM dbo.Invoice WHERE InvoiceDate LIKE '%2009%'

--SELECT COUNT(*) FROM InvoiceLine WHERE InvoiceId=37 
--SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
--SELECT COUNT(*) FROM Invoice WHERE InvoiceId=37 
--SELECT COUNT(column_name) AS Number FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name='Invoice'

--SELECT Country, COUNT(Country) AS InvoiceCountryCount FROM Customer GROUP BY Country

--SELECT dbo.Invoice.BillingCountry, SUM(Invoice.Total) AS InvoiceCountryTotals
--	FROM Invoice
--	GROUP BY BillingCountry
--	ORDER BY InvoiceCountryTotals DESC

