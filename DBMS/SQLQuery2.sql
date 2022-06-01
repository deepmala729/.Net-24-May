Create database SampleDb1
Drop database SampleDb2;
Create table sample(id int, name varchar(200));
select * from sample;
insert into sample values(1, 'Vikash');
delete from sample;
insert into sample values(1, 'Vikash');
insert into sample values(1, 'Vikash');
insert into sample values(1, 'Vikash');
insert into sample values(1, 'Vikash');
update sample set name='rohit' where id=1;
Create table Employee(EmpId int, EmpName varchar(200));
select * from Employee;
Alter table Employee  Add Empgender varchar(20);
Alter table Employee  Add Department varchar(20);
Alter table Employee  Add Salary varchar(20);
Alter table Employee  Drop column Empgender;
insert into Employee values(1, 'Vikash');
insert into Employee values(2, 'rohit');
insert into Employee values(3, 'rahul');
insert into Employee values(4, 'anshu');
select * from Employee;
update Employee set Salary='30000' where EmpId=1
update Employee set  Salary='35000' where EmpId=2;
update Employee set  Salary='50000' where EmpId=3;
update Employee set  Salary='50000' where EmpId=4;

update  Employee set Department='IT' where EmpId=1;
update  Employee set  Department='HR' where EmpId=2;
update  Employee set  Department='IT' where EmpId=3;
update  Employee set  Department='Admin' where EmpId=4;
alter table Employee Drop column Department;
Create table Department(id int, Department varchar(20));
Select * from Department;

insert into Department values(101, 'IT');
insert into Department values(102, 'HR');
insert into Department values(103, 'Sales');
insert into Department values(104, 'Admin');

 

 










 