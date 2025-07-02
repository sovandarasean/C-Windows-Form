### 🚀 How to Set Up This Project

Since I'm using a **local database**, make sure to create the database, table, and insert mockup data using the SQL scripts below:

### 🗃️ SQL Setup Script

```sql
-- Creating a Database and a Table
CREATE DATABASE SaleReport;

USE SaleReport;
CREATE TABLE PRODUCTSALES ( 
    SALEID INT PRIMARY KEY, 
    PRODUCTCODE NVARCHAR(20), 
    PRODUCTNAME NVARCHAR(100), 
    QUANTITY INT, 
    UNITPRICE DECIMAL(18,2), 
    SALEDATE DATE 
);

-- Insert mockup data into the table
INSERT INTO PRODUCTSALES (SALEID, PRODUCTCODE, PRODUCTNAME, QUANTITY, UNITPRICE, SALEDATE) 
VALUES 
(1, 'P001', 'Pen', 10, 1.50, '2025-06-20'), 
(2, 'P001', 'Pen', 5, 1.50, '2025-06-25'), 
(3, 'P002', 'Notebook', 3, 3.20, '2025-06-21'), 
(4, 'P003', 'Eraser', 15, 0.80, '2025-06-22');

-- Create Stored Procedure to filter sales by date range
CREATE PROCEDURE QuerySaleBetweenDates 
    @STARTDATE DATE, 
    @ENDDATE DATE
AS
BEGIN
    SELECT * FROM PRODUCTSALES 
    WHERE SALEDATE BETWEEN @STARTDATE AND @ENDDATE
END
GO
```
### 🗃️ C# Code Modification
-  **Connection String**
In the file **DBOperation.cs**, please change the value of **serverName** with yours.
```csharp
//since I use a local database, mine will look like this
string serverName = @"(localdb)\MSSQLLocalDB";
```
<p align="center">
  <img 
    src="https://github.com/user-attachments/assets/b487fe46-68a6-482a-a616-afbaf0c33554" 
    alt="Screenshot 2025-07-02 124336" 
    width="600" 
    style="border-radius: 15px;">
</p>

### 🅰️ Font
In **SaleReportXtraReport** Design, I use with **Noto Sans Khmer**. If you don't have one, you can install from the folder **fonts** in the project above.

### 🖨️ Report Sample
<p align="center">
  <img 
    src="https://github.com/user-attachments/assets/4de7d710-7d20-48a6-a1e0-d381ae8f7848" 
    alt="Screenshot 2025-07-02 125613" 
    width="600" 
    style="border-radius: 15px;">
</p>
