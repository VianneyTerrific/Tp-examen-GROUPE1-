--Ajout personne
create procedure sp_AjouterPersonne
	@id varchar(50),@nom varchar(50),@postnom varchar(50),
	@prenom varchar(50),@sexe varchar(1)
as
begin
	if not exists(select * from personne where id=@id)
		insert into personne(id,nom,postnom,prenom,sexe) values 
		(@id,@nom,@postnom,@prenom,@sexe)
end
go

--Modification personne
create procedure sp_ModifierPersonne
	@id varchar(50),@nom varchar(50),@postnom varchar(50),
	@prenom varchar(50),@sexe varchar(1)
as
begin
	update personne set nom=@nom,postnom=@postnom,prenom=@prenom,
	sexe=@sexe where id=@id
end
go

--Suppression personne
create procedure sp_SupprimerPersonne
	@id varchar(50)
as
begin
	if exists(select * from personne where id=@id)
		delete from personne where id=@id
end
go

--Affichage personne
create procedure sp_AfficherPersonne
as
begin 
	select * from personne order by nom asc
end
go




--Ajout adresse
create procedure sp_AjouterAdresse
	@id varchar(50),@quartier varchar(50),@commune varchar(50),
	@ville varchar(50),@pays varchar(50)
as
begin
	if not exists(select * from adresse where id=@id)
		insert into adresse(id,quartier,commune,ville,pays) values 
		(@id,@quartier,@commune,@ville,@pays)
end
go

--Modification adresse
create procedure sp_ModifierAdresse
	@id varchar(50),@quartier varchar(50),@commune varchar(50),
	@ville varchar(50),@pays varchar(50)
as
begin
	update adresse set quartier=@quartier,commune=@commune,
	ville=@ville,pays=@pays where id=@id
end
go

--Suppression adresse
create procedure sp_SupprimerAdresse
	@id varchar(50)
as
begin
	if exists(select * from adresse where id=@id)
		delete from adresse where id=@id
end
go

--Affichage adresse
create procedure sp_AfficherAdresse
as
begin
	select * from adresse order by quartier asc
end
go




--Ajout domicile
create procedure sp_AjouterDomicile
	@id varchar(50),@id_personne varchar(50),@id_adresse varchar(50),@avenue varchar(50),
	@numero_avenue int
as
begin
	if not exists(select * from domicile where id=@id)
		insert into domicile(id,id_personne,id_adresse,avenue,numero_avenue) values 
		(@id,@id_personne,@id_adresse,@avenue,@numero_avenue)
end
go

--Modification domicile
create procedure sp_ModifierDomicile
	@id varchar(50),@id_personne varchar(50),@id_adresse varchar(50),@avenue varchar(50),
	@numero_avenue int
as
begin
	update domicile set id_personne=@id_personne,id_adresse=@id_adresse,avenue=@avenue,
	numero_avenue=@numero_avenue where id=@id
end
go

--Suppression domicile
create procedure sp_SupprimerDomicile
	@id varchar(50)
as
begin
	if exists(select * from domicile where id=@id)
		delete from domicile where id=@id
end
go

--Affichage domicile
create procedure sp_AfficherDomicile
as
begin 
	select d.id,id_personne,nom+' '+postnom+' '+prenom as noms,id_adresse,pays+','+ville+','+commune+','+quartier as adresse,
		avenue,numero_avenue from domicile d 
	inner join personne p on p.id = d.id_personne
	inner join adresse a on a.id = d.id_adresse
	order by nom asc
end
go




--Ajout telephone
create procedure sp_AjouterTelephone
	@id varchar(50),@id_personne varchar(50),@initial varchar(4),
	@numero varchar(9)
as
begin
	if not exists(select * from telephone where id=@id)
		insert into telephone(id,id_personne,initial,numero) values 
		(@id,@id_personne,@initial,@numero)
end
go

--Modification telephone
create procedure sp_ModifierTelephone
	@id varchar(50),@id_personne varchar(50),@initial varchar(4),
	@numero varchar(9)
as
begin
	update telephone set id_personne=@id_personne,initial=@initial,
	numero=@numero where id=@id
end
go

--Suppression telephone
create procedure sp_SupprimerTelephone
	@id varchar(50)
as
begin
	if exists(select * from telephone where id=@id)
		delete from telephone where id=@id
end
go

--Affichage telephone
create procedure sp_AfficherTelephone
as
begin
	select t.id,id_personne,nom+' '+postnom+' '+prenom as noms,initial,numero from telephone t 
	inner join personne p on p.id = t.id_personne
	order by nom asc
end
go