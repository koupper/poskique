


if OBJECT_ID('formaPagoTemp') is not null
drop table formaPagoTemp;

create table formaPagoTemp(
	id_formaPago varchar(30) primary key, --identity , 
	id_venta varchar(25),
	metodoPago varchar(30), -- es: efectivo, tarjeta
	detalle varchar(30), -- nombre de la compañia de la tarjeta 
	monto money,
	numero_tarjeta varchar(4)--,
	--foreign key (id_venta) references ventas(id_venta)
	--on delete cascade
	--on update cascade
	
);

insert into formaPagoTemp
select * from formaPago;

drop table formaPago;
if OBJECT_ID('formaPago') is not null
drop table formaPago;

create table formaPago(
	id_formaPago varchar(30) primary key, --identity , 
	id_venta varchar(25),
	metodoPago varchar(30), -- es: efectivo, tarjeta
	detalle varchar(30), -- nombre de la compañia de la tarjeta 
	monto money,
	numero_tarjeta varchar(4)--,
	--foreign key (id_venta) references ventas(id_venta)
	--on delete cascade
	--on update cascade
	
);

insert into formaPago
select * from formaPagoTemp;

drop table formaPagoTemp;