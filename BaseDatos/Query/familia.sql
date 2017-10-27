if OBJECT_ID('familia') is not null
drop table familia;

create table familia(
	id_familia int primary key,--identity ,
	nombre varchar(80)
);

--insert into familia(nombre) values('combos');
--insert into familia(nombre) values('individuales');
--insert into familia(nombre) values('cafeteria');
--insert into familia(nombre) values('bebidas');