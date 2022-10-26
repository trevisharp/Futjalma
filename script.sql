use master
go

if (exists(select * from sys.databases where name = 'Futjalma'))
	drop database Futjalma
go

create database Futjalma
go

use Futjalma
go

create table Jogador(
	ID int identity primary key,
	Nome varchar(120) not null,
	DataNascimento date not null,
	Foto image null
);
go

create table Clube(
	ID int identity primary key,
	Nome varchar(100) not null,
	Fundacao date not null,
	Escudo image null
);
go

create table Contratacao(
	ID int identity primary key,
	JogadorID int references Jogador(ID) not null,
	ClubeID int references Clube(ID) not null,
	Camisa int not null,
	Fechamento date not null,
);
go


