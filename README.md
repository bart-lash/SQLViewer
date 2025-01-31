# SQLViewer

Database from: https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql

### SQL query to view orders by employee`s last name (in example: "King"):

```
select * from
	dbo.Orders o
	inner join dbo.Employees e on e.EmployeeID = o.EmployeeID
where e.LastName = 'King'
order by o.OrderDate desc;
```

### SQL query to view sum of order freight by employee:

```
select
	e.FirstName,
	e.LastName,
	sum(o.Freight) ofr
from
	dbo.Orders o 
	inner join dbo.Employees e on e.EmployeeID = o.EmployeeID
group by e.FirstName, e.LastName
order by ofr desc;
```