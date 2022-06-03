Create database SampleDb1
Drop database SampleDb2;
Create table sample(id int, name varchar(200));
select * from sample;
insert into sample values(1, 'Vikash');
delete from sample;
insert into sample values(1, 'Vikash');
insert into sample values(2, 'Rohit');
insert into sample values(3, 'Mohit');
insert into sample values(4, 'Rahul');
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

--full outer join
--left outer join
--right outer join

select * from employee1;

select * from department1;

select * from employee1 emp FULL OUTER JOIN department1 dep on emp.departmentid=dep.id;

select * from employee1 emp LEFT OUTER JOIN department1 dep on emp.departmentid=dep.id;

select * from employee1 emp RIGHT OUTER JOIN department1 dep on emp.departmentid=dep.id;



create table employee1 (id int,name varchar(200),departmentid int)
create table department1(id int,department varchar(20))
insert into employee1 values(1,'Vikash',1)
insert into employee1 values(2,'Rohit',2)
insert into employee1 values(3,'Rahul',1)
insert into employee1 values(4,'Rahul',3)

insert into department1 values(1,'IT')
insert into department1 values(2,'Sales')
insert into department1 values(4,'Admin')

select * from employee1
select * from department1

select emp.name,dep.department from employee1 as emp inner join department1 as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee1 as emp left join department1 as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee1 as emp right join department1 as dep on emp.departmentid=dep.id

select * from employee1 as emp inner join department1 as dep on emp.departmentid=dep.id;

select * from sample;
alter table sample Drop column name;
Alter table sample  Add name varchar(20);


 create table students(id int ,rollno int,firstname varchar(100),lastname varchar(100),gender varchar(20),classid int)

create table studentclass(id int,classname varchar(100))

select * from students
select * from studentclass

insert into studentclass values(1,'V');
insert into studentclass values(2,'VI')
insert into studentclass values(3,'VII')

insert into students values(1,101,'Vikash','Verma','Male',1)
insert into students values(2,102,'Rohit','Kumar','Male',1)
insert into students values(3,103,'Amit','Soni','Male',1)
insert into students values(4,104,'Rakesh','Sharma','Male',1)
insert into students values(5,105,'Anjali','Sharma','Female',1)


select rollno,CONCAT(firstname,' ',lastname) as FullName,gender,sc.classname from students s
inner join studentclass sc on sc.id=s.classid


 










 