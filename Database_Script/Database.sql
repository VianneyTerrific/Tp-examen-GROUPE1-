create database gestion_personne
go

use gestion_personne
go

create table personne
(
	id varchar(50),
	nom varchar(50) not null,
	postnom varchar(50) not null,
	prenom varchar(50) not null,
	sexe varchar(1) default 'M' not null,
	constraint pk_personne primary key(id),
	constraint uk_personne unique(nom,postnom,prenom)
)
go

create table adresse
(
	id varchar(50),
	quartier varchar(50) not null,
	commune varchar(50) not null,
	ville varchar(50) not null,
	pays varchar(50) not null,
	constraint pk_adresse primary key(id)
)
go

create table domicile
(
	id varchar(50),
	id_personne varchar(50) not null,
	id_adresse varchar(50) not null,
	avenue varchar(50) not null,
	numero_avenue int not null,
	constraint pk_domicile primary key(id),
	constraint fk_personne_domicile foreign key(id_personne)
	references personne(id),
	constraint fk_addresse_domicile foreign key(id_adresse)
	references adresse(id)
)
go

create table telephone 
(
	id varchar(50),
	id_personne varchar(50) not null,
	initial varchar(4) not null,
	numero varchar(9) not null,
	constraint pk_telephone primary key(id),
	constraint fk_personne_telephone 
	foreign key(id_personne) references personne(id)
)
go