if OBJECT_ID('privilegiosasignados') is not null
drop table privilegiosasignados;

create table privilegiosasignados(
id_privilegioasignado int  primary key,--identity,
id_privilegio int,
codigo_empleado int--, 
--foreign key(codigo_empleado) references usuario(codigo_empleado)

);

--insert into privilegiosasignados(id_privilegio, codigo_empleado) values(2, 100);
--insert into privilegiosasignados(id_privilegio, codigo_empleado) values(1, 101);
--insert into privilegiosasignados(id_privilegio, codigo_empleado) values(3, 101);