create table tcustomers(customer_id varchar(10) primary key,customer_name varchar(20),address varchar(20),phone_no BIGINT,email_id varchar(20));
insert into tcustomers values(101,'PRIYA','TNAGAR',9444663968,'riya@gmail.com')
insert into tcustomers values(102,'SAN','TIRUPUR',9489885704,'san@gmail.com')
insert into tcustomers values(103,'SAM','ADAYAR',9444674511,'sam@yahoo.com')
insert into tcustomers values(104,'SHALINI','ANNA NAGAR',9489885703,'shalu@gmail.com')
select * from tcustomers where email_id like '%_@gmail.com%' order by customer_id
update tcustomers set phone_no='9789876589' where customer_id=101;
select * from tcustomers order by customer_id;
drop table tcustomers;