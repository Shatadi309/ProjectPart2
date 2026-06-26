--craeting a database called prog_tasks--
create database prog_tasks;

-- use the prog_tasks database--
use [prog_tasks];

--creating a table [entity]
--columns are task_id, task_name, task_description, task_dueDate, task_status
--List of the columns
--task_id datatype int, and auto-increment
--task_name datatype varchar(put number of characters)
--task_description datatype varchar()
--task_dueDate datatype varchar()
--task_status datatype varchar() --

--creating a table called tasks--
create table tasks(
task_id int primary key identity(1,1) ,
task_name varchar(100) ,
task_description varchar(100) ,
task_dueDate varchar(20) ,
task_status varchar(20)
);

--select all from the table tasks--
select * from tasks;
