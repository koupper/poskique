

if OBJECT_ID('corteCaja') is not null
drop table corteCaja;

create table corteCaja(
	id_corte_caja int identity primary key , 
	estatus bit,
	fechaInicio datetime default getdate(),
	fechaCierre datetime, 
	faltante money,
	sobrante money
);

-- abrir una nueva caja
IF(select COUNT(*) from corteCaja where estatus = 1) = 0 
	
	begin insert into corteCaja(estatus)
	values(1); 
	
end

select * from corteCaja where estatus = 1;
