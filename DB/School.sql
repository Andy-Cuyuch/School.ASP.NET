CREATE DATABASE DBSLand
use DBSLAND

CREATE TABLE dbo.Students
(
	StudentId int PRIMARY KEY NOT NULL, 
	nameStudent VARCHAR(50) NOT NULL,
	lastname varchar(50) not null,
	Carnet varchar(50) not null, 
	correo varchar(50) not null, 
	pass varchar(50) not null 
)
go

CREATE TABLE dbo.Teacher(
	idTeacher INT PRIMARY KEY NOT NULL, 
	nameTeacher varchar(50) not null, 
	age varchar(50) not null, 
	phone varchar(50) not null, 
	carnet varchar(50) not null, 
	yearsSchool varchar(50) not null
)
go

CREATE TABLE dbo.SGrade
(
	degreeId INT PRIMARY KEY, 
	grade varchar(50) not null, 
	descriptions varchar(50) not null,
	student integer, 
	FOREIGN KEY (student) references Students(StudentId)
)
go

insert into Teacher values(1,'Mario','Scalante','123','23','2312')

select * from Teacher; 