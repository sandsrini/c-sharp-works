create table hotel_details(hotel_id varchar(20) primary key,hotel_name varchar(20),hotel_type varchar(20),rating int);
drop table hotel_details
insert into hotel_details values(1,'A2B','Veg',5);
select hotel_name + ' is a ' +hotel_type as Hotel_info from hotel_details;