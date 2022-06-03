create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(firstname,' ',lastname) as FullName from students where id=@ID);
End

select * from students
select dbo.GetFullName(5);
update students set lastname='Gupta' where id=1;
update students set lastname ='Gupta' where id=2;
update students set lastname='Gupta' where id=3;
update students set lastname= 'Gupta'  where id=4;
update students set lastname ='Gupta' where id=5;
select * from employee1;

create function GetEmpID(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(id,' ',name) as EMPID from employee1 where id=@ID);
End
select * from students;
select dbo.GetFullName(2) ;

create function GetEmployeeId(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT('EMP',id) as EMPID from employee1 where id=@ID);
End

select dbo.GetEmployeeId(4);

select * from employee1
select * from department1
create proc AddEmployee(@Id int,@Name varchar(200),@DepartmentId int)
As 
Begin

insert into employee1 values(@Id,@Name,@DepartmentId);
END

exec dbo.AddEmployee 'Priyanka','IT'

create table employee1(id int IDENTITY(1,1),name varchar(200),departmentid int)
create table department2(id int IDENTITY(1,2),department varchar(20))

create proc getStudents as begin 
select * from employee1 emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;
end 

exec getStudents