create database sri

create table formusiet(
idusuario integer identity (1,1) not null,
fecha varchar (10) not null,
ano varchar (4) not null,
nombre_apellido varchar (30) not null,
cedula varchar (10) not null,
sueldo_salario varchar (10) not null,
comision_bono varchar (10) not null,
participacion varchar (10) not null,
ingreso varchar (10) not null,
decimo_tercer varchar (10) not null,
decimo_cuarto varchar (10) not null,
fondo varchar (10) not null,
ingreso_noagra varchar (10) not null,
aporte_empleador varchar (10) not null,
aporte_empleadores varchar (10) not null,
exo_discapacidad varchar (10) not null,
exo_tercera varchar (10) not null,
imp_renta varchar (10) not null,
constraint pk_formusiet primary key (idusuario)
);

create table formudos(
idusuario integer identity (1,1) not null,
fecha varchar (10) not null,
ano varchar (4) not null,
nombre_apellido varchar (30) not null,
cedula varchar (10) not null,
empresarial varchar (10) not null,
libre varchar (10) not null,
ocupacional varchar (10) not null,
arriendo varchar (10) not null,
regalias varchar (10) not null,
totales_suma varchar (10) not null,
educacion varchar (10) not null,
salud varchar (10) not null,
libre_ejercicio varchar (10) not null,
vestimenta varchar (10) not null,
total_egreso varchar (10) not null,
total varchar (10) not null,
constraint pk_formudos primary key (idusuario)
);

