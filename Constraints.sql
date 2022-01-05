use sql_asp

create table tblCustomers(CustomerId varchar(20) primary key,CompanyName varchar(30),ContactName varchar(20),ContactTitle varchar(10),Address varchar(60),
City varchar(20),Region varchar(20),PostalCode int,Country varchar(20),Phone varchar(12),
Fax varchar(20), foreign key(CompanyName) references tblShippers(CompanyName));

insert into tblCustomers(CustomerId,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Phone,Fax)values('1002','tcs','SANDHYA','DEVELOPER','AMBATTUR','CHENNAI','CH',600012,'9489885703','134');
select * from tblCustomers;

create table tblShippers(ShipperID varchar(20) primary key,CompanyName varchar(30) unique);

insert into tblShippers values('5','merit');
insert into tblShippers values('4','dell');
select * from tblShippers;

create table tblOrders(OrderID varchar(20) primary key,CustomerID varchar(20),EmployeeID varchar(20),ShipName varchar(50),ShipAddress varchar(50),
ShipCity varchar(50),ShipRegion varchar(50),ShipPostalCode int,ShipCountry varchar(20),
ShipVia varchar(20),OrderDate Date,RequiredDate Date,ShippedDate Date,Freight varchar(40),foreign key(CustomerID) references tblCustomers(CustomerID));

drop table tblCustomers

create table tblOrderDetails(OrderID varchar(20) primary key,ProductID varchar(10),UnitPrice int,
Quantity int,Discount int,foreign key(ProductID) references Products(ProductID));
insert into tblOrders values('6','1001','102','SANDHYA','AMBATTUR','CHENNAI','CH',600012,'INDIA','ABT','2021-10-12','2021-11-10','2021-10-9','TRUCK');
select * from tblOrders

insert into tblOrderDetails values('2','1',10,0,10);

select * from tblOrderDetails;

create table Products(ProductID varchar(10) primary key,SupplierID varchar(20),CategoryID varchar(10),ProductName varchar(30),
EnglishName varchar(30),QuantityPerUnit int,UnitPrice int,UnitsInStock int,UnitsOnOrder int,ReorderLevel int,Discontinued bit,foreign key(SupplierID) references tblSupplier(SupplierID));

insert into Products(ProductID,ProductName) values ('2','Rice');

select * from Products;
create table tblSupplier(SupplierID varchar(20) primary key,Name varchar(30),Address varchar(60),City varchar(20),Province varchar(20));

alter table tblCustomers add constraint dcountry default 'Canada' for Country;

alter table tblOrderDetails add constraint qcheck check(Quantity>0);

alter table tblOrders add constraint chkdate check(ShippedDate>OrderDate);insert into tblOrderDetails values(1,1001,101,'SANDHYA','AMBATTUR','CHENNAI','CH',600012,'INDIA','ABT','2021-10-10','2021-10-13','2021-10-12','TRUCK');
