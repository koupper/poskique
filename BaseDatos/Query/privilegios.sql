if OBJECT_ID('privilegios') is not null
drop table privilegios;

create table privilegios(
id_privilegio int primary key,--identity ,
descripcion varchar(80)
);

--insert into privilegios(descripcion) values('cancelaciones');
--insert into privilegios(descripcion) values('ventas al publico');
--insert into privilegios(descripcion) values('inventario');