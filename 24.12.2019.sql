SELECT * FROM [Order];
SELECT * FROM [OrderLine];

SELECT 
    [Name], 
    LEN([Name]) AS [NameLength] 
FROM [Product] 
WHERE LEN([Name]) > 20
ORDER BY [NameLength];

DECLARE @year INT = YEAR(GETUTCDATE());
DECLARE @month INT = MONTH(GETUTCDATE());
DECLARE @day INT = DAY(GETUTCDATE());
SELECT
GETUTCDATE() AS [DateTime],
@year AS [Year],
@month as [Month],
@day as [Day];

--Самостоятельная работа
SELECT * FROM OrderLine;
SELECT COUNT(*), COUNT(DISTINCT[Count]) FROM [OrderLine];

SELECT * FROM [Order];
SELECT COUNT(*) FROM [OrderLine];
SELECT COUNT(OrderId) FROM [OrderLine];
SELECT MAX(Id) FROM [Order];
SELECT AVG(Discount) FROM [Order];
SELECT MIN(OrderDate), MAX(OrderDate) FROM [Order];

SELECT MAX([OrderDate]) FROM [Order] WHERE YEAR([OrderDate]) = 2018;

SELECT MAX(LEN([Name])) FROM [Product];
--Самостоятельная работа

SELECT 
    O.Id AS OrderId,
    C.Name AS CustomerName
FROM [Order] O
JOIN [Customer] C
    ON O.CustomerId = C.Id
WHERE YEAR (O.[OrderDate]) = 2018;

SELECT
    *
FROM [Customer] C
WHERE Id IN (
    SELECT CustomerId FROM [Order] WHERE YEAR ([OrderDate]) = 2018
);

--Id и название товара с максималной длиной наименования
SELECT [Name] 
FROM [Product] 
WHERE LEN([Name]) = (
SELECT MAX(LEN([Name])) FROM [Product]
);

--Размер макс скидки в 2016 году


--номер первого заказа в 2019 году
SELECT
    *
FROM [Order] 
WHERE [OrderDate] = 2019;

--3
SELECT  C.Id,
        C.Name 
FROM [Order] AS O 
JOIN [Customer] AS C ON O.CustomerId = C.Id 
WHERE O.Discount IN (
    SELECT MAX ([Discount]) FROM [Order]  WHERE YEAR ([OrderDate]) = 2016
);

--4
SELECT  C.Id,
        C.Name 
FROM [Order] AS O 
JOIN [Customer] AS C ON O.CustomerId = C.Id 
WHERE O.OrderDate IN (
    SELECT MIN ([OrderDate]) FROM [Order]  WHERE YEAR ([OrderDate]) = 2019
);

--совместная работа
SELECT 
    P.Name AS ProductName,
    OL.Count AS OrderLineCount,
    P.Price AS OrderLineProductPrice,
    OL.Count * P.Price AS OrderLineTotal
FROM [Order] AS O
JOIN [OrderLine] AS OL
    ON O.Id = OL.OrderId
JOIN [Product] AS P
    ON P.Id = OL.ProductId
WHERE O.Id = 22;

SELECT SUM(OL.Count * P.Price) AS Total
FROM [Order] AS O
JOIN [OrderLine] AS OL
    ON O.Id = OL.OrderId
JOIN [Product] AS P
    ON P.Id = OL.ProductId
WHERE O.Id = 22;


--итоговая сумма потраченная Марией
SELECT * FROM [Customer] WHERE [Name] = 'Мария';


SELECT 
    SUM(OL.Count * P.Price) AS OrderLineTotal
FROM [Order] AS O
JOIN [OrderLine] AS OL
    ON O.Id = OL.OrderId
JOIN [Product] AS P
    ON P.Id = OL.ProductId
JOIN [Customer] AS C
    ON C.Id = O.CustomerId
WHERE C.Name = 'Мария';

--Самостоятельная 4 (ид клиента | имя клиента | итоговая потраченная сумма)

