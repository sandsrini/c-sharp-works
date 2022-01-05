create table persons(pid int primary key,gid int,pname varchar(20) not null,email varchar(20) not null);
create table gender(gid int primary key,gname varchar(10));

alter table persons add constraint d foreign key(gid) references gender(gid);
alter table gender add constraint d1 default 1 for gid;
drop table persons

create table tblC(CustomerID int primary key,CompanyName varchar(100),ContactName varchar(100),ContactTitle varchar(100),Address varchar(100),City varchar(100),Region varchar(100),PostalCode int,Country varchar(100),Phone varchar(100),Fax int,foreign key(CompanyName)references tblShippers(CompanyName));
alter table tblC add constraint country_cust default 'Canada' for Country;
select * from tblCustomers
insert into tblC(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Phone,Fax)values(1001,'CTS','SANDHYA','DEVELOPER','AMBATTUR','CHENNAI','CH',600012,'9489885703',134);