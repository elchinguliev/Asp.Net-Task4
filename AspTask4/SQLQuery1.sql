create database MyProductDb
go 
use MyProductDb
go
create table Categories(
	Id int primary key Identity(1,1)not null,
	Title nvarchar(50) not null
)
go
create table Products(
	Id int primary key Identity(1,1)not null,
	[Name] nvarchar(50) not null,
	Price  money not null Default(0)
)