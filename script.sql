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

create table Campeonato(
	ID int identity primary key,
	Nome varchar(100) not null,
	Inicio date not null,
	Premiacao decimal(10, 2) not null,
	Logo image null,
	Campeao int references Clube(ID) null
);
go

create table Inscricao(
	ID int identity primary key,
	ClubeID int references Clube(ID) not null,
	CampeonatoID int references Campeonato(ID) not null,
);
go

create table Partida(
	ID int identity primary key,
	Clube1ID int references Clube(ID) not null,
	Clube2ID int references Clube(ID) not null,
	Placar1 int not null,
	Placar2 int not null
);