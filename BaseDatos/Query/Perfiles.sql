if object_id('perfiles') is not null
drop table perfiles;

create table perfiles(
id_perfil int  primary key , --identity
nombre_perfil varchar (30),
id_privilegio int--,
--foreign key(id_privilegio) references privilegios(id_privilegio)
--on delete cascade
--on update cascade
);


--insert into perfiles(nombre_perfil, id_privilegio) values('gerente', 8);
--insert into perfiles(nombre_perfil, id_privilegio) values('gerente', 9);
--insert into perfiles(nombre_perfil, id_privilegio) values('gerente', 10);
--insert into perfiles(nombre_perfil, id_privilegio) values('gerente', 2);

--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 3);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 5);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 6);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 7);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 13);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 12);
--insert into perfiles(nombre_perfil, id_privilegio) values('encargado', 16);

--insert into perfiles(nombre_perfil, id_privilegio) values('cajero', 2);
--insert into perfiles(nombre_perfil, id_privilegio) values('cajero', 14);
--insert into perfiles(nombre_perfil, id_privilegio) values('cajero', 15);
--insert into perfiles(nombre_perfil, id_privilegio) values('cajero', 16);



