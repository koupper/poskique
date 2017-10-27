if object_id('caja') is not null
drop table caja;

create table caja(
	id_caja varchar(30) primary key,
	id_tienda int,
	codigo_empleado int, 
	efectivoInicial money,
	efectivoAlCierre money null,
	id_dinero varchar(30),
	fechaInicio datetime default getdate(),
	fechaCierre datetime null, 
	estatus bit,
	caja_maestra int--, -- true abierta, false cerrada
	--foreign key (codigo_empleado) REFERENCES usuario(codigo_empleado) 
	--on update cascade
	--on delete cascade,
	--foreign key (id_dinero) REFERENCES dinero(id_dinero) 
	--on update cascade
	--on delete cascade
	);
	
	/*
	insert into caja(id_caja, id_tienda,codigo_empleado, efectivoInicial, efectivoAlCierre, id_dinero, fechaCierre)	
	values(1020, 1, 100, 0, null, 0, null);
	*/
	--update caja set fechaCierre = '' where id_caja = 
	
	--efectivoAlCierre,
	--fechaInicio,
	--fechaCierre)
	
	-- revisar si la caja esta abierta o cerrada

	/*select top 1 id_caja, id_dinero, estatus from caja where id_tienda = 2 order by fechaInicio desc 
	
	update caja * from caja where id_tienda = 2 order by fechaInicio desc 
	
	update caja set fechaCierre = '', estatus =  where id_caja =  
	
	
	
	*/


	alter table caja add caja_maestra int;
	