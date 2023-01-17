insert into Customer values(1, 'Amruta', 'Kulkarni', 'Dhule', 'India', '8877991122' );
insert into Customer values(2, 'Bhakti', 'Takane', 'Amalner', 'India', '6677991133' );
insert into Customer values(3, 'Srishti', 'Patil', 'Dallas', 'America', '8877990092' );
insert into Customer values(4, 'Raksha', 'Gujrathi', 'seoul', 'Korea', '8876591122' );
insert into Customer values(5, 'Shiny', 'Majumdar', 'Sydney', 'Australia', '030-0074321' );
insert into Customer values(6, 'Shirley', 'William', 'London', 'UK', '7722991123');
insert into Customer values(7, 'Ruchika', 'Mali', 'Paris', 'France', '7214991429', '');

alter table Customer add FaxNumber nvarchar(10);
update Customer set Country = 'Germany', City='Berlin' where Id = 5;
update Customer set FaxNumber = '4210' where Id = 1;
update Customer set FaxNumber = '3219' where Id = 4;

Select * from Customer

Select Country from Customer
where Country like 'A%' OR Country like 'I%'
order by Country

select FirstName from Customer
where FirstName like '__i%'


insert into Orders values(100, '2020/10/23 10:21:43:121', 5, 1, 749.00 )
insert into Orders values(101, '2021/10/28 05:34:55:222', 2, 5, 599.00 )
insert into Orders values(102, '2022/05/02 02:52:11:452', 4, 2, 379.00 )
insert into Orders values(103, '2023/01/05 22:13:44:233', 6, 1, 800.00 )
insert into Orders values(104, '2020/12/09 12:33:56:123', 3, 3, 237.00 )
select * from Orders

delete from Orders where TotalAmount = 699.00;

update Orders set OrderDate = '2020/10/23 10:21:43:121' where Id = '100';
update Orders set OrderDate = '2021/10/28 05:34:55:222' where Id = '101';
update Orders set OrderDate = '2022/05/02 02:52:11:452' where Id = '102';
update Orders set OrderDate = '2023/01/05 22:13:44:233' where Id = '103';
update Orders set OrderDate = '2020/12/09 12:33:56:123' where Id = '104';

insert into Products values(200, 'Chips', 50.00, 'Lays', 0, 'Snacks');
insert into Products values(201, 'Chai', 30.00, 'Taj', 1, 'Refreshing Drink');
insert into Products values(203, 'Coffee', 40.00, 'Bru', 0, 'Refreshing Drink');
insert into Products values(202, 'Biscuits', 60.00, 'Burborn', 0, 'Snacks');
insert into Products values(204, 'Fish', 20.00, 'Fish', 1, 'Seafood');
insert into Products values(205, 'chai', 50.00, 'Taj', 1, 'Refreshing Drink');
delete from Products where Id = 205;

select * from Products

insert into OrderItem values(10, 100, 200, 649.00, 3);
insert into OrderItem values(12, 103, 201, 449.00, 5);
insert into OrderItem values(13, 102, 202, 549.00, 3);
insert into OrderItem values(14, 101, 203, 749.00, 2);
insert into OrderItem values(15, 104, 204, 349.00, 6);
insert into OrderItem values(16, 103, 205, 50.00, 6);
delete from OrderItem where ProductId = 205;

update OrderItem set UnitPrice = 15 where OrderId = 103
update OrderItem set UnitPrice = 12 where OrderId = 101
select * from OrderItem;

Assignment 03:

1. select * from Orders where CustomerId = (select Id from Customer where Phone = '030-0074321');

alter table Product add Category nvarchar(40);
update Product set Category = 'Refreshing Drink' where Id = '201';
update Product set Category = 'Snacks' where Id = '200';
update Product set Category = 'Snacks' where Id = '202';
update Product set Category = 'Seafood', ProductName = 'Fish' where Id = '204';
update Product set Category = 'Refreshing Drink' where Id = '203';
update Product set Package = 'Lays' where Id = '200';

2. select * from Product where Category = 'Seafood';
3. Select * from Orders inner join Customer on Orders.CustomerId = Customer.id where Customer.City!='London';
4.select * from OrderItem where ProductId = (Select Id from Product where ProductName ='Chai');

Create table Employee(
FirstName nvarchar(40),
LastName nvarchar(40),
Department nvarchar(40),
Manager nvarchar(40),
Rating int,
Salary int);

insert into Employee values('Amruta', 'Kulkarni','CSE', 'Rashmi', 5, 25000);
insert into Employee values('Apurva', 'Gondkar','Civil', 'Rashmi', 6, 2300);
insert into Employee values('Rutuja', 'Thombre','Civil', 'Rashmi', 5, 26000);
insert into Employee values('Nikita', 'Punde','Entc', 'Rashmi', 5, 35000);
insert into Employee values('Gauri', 'Devahdrao','Civil', 'Rashmi', 6, 22000);

5. select * from Employee;

2nd Assignment:

1. select * from Customer where Country = 'Germany';
2. select concat(FirstName,' ',LastName) AS FullName from Employee;
3. select * from Customer where FaxNumber Is Not Null;
4. select * from Customer where FirstName like '_u%'
5. select * from OrderItem where UnitPrice Between 10 AND 20