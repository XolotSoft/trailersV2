CREATE DATABASE trailers;
GO
USE trailers
GO
CREATE TABLE usuarios(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255),
username varchar(255),
password varchar(255),
rol varchar(255));
GO
CREATE TABLE operadores(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255),
paterno varchar(255),
materno varchar(255),
nacimiento date,
calle varchar(255),
numero varchar(255),
colonia varchar(255),
delegacion varchar(255),
telefono varchar(255),
email varchar(255),
licencia varchar(255),
multas int,
estado varchar(255));
GO
CREATE TABLE vehiculos(
id int IDENTITY PRIMARY KEY NOT NULL,
serie varchar(255),
marca varchar(255),
tipo varchar(255),
modelo varchar(255),
placa varchar(255),
adquicision date,
servicio date,
mantenimiento varchar(255),
DF int,
Chihuahua int,
Moterrey int,
Hermosillo int,
estado varchar(255));
GO
CREATE TABLE destinos(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255)
);
INSERT INTO destinos(nombre)
VALUES('CD de México'),('Chihuahua'),('Monterrey'),('Hermosillo');
GO
CREATE TABLE cargas(
id int IDENTITY PRIMARY KEY NOT NULL,
carga varchar(255),
origen varchar(255),
destino varchar(255),
partida date,
arribo date,
kilo decimal(9,2),
peaje decimal(9,2),
operador_id int,
comision int,
viaticos decimal(9,2),
vehiculo_id int,
precio decimal(9,2),
rendimiento decimal(9,2),
litros decimal(9,2),
costo decimal(9,2),
CONSTRAINT carga_vehiculo
FOREIGN KEY (vehiculo_id)
REFERENCES vehiculos(id)
ON DELETE CASCADE,
CONSTRAINT carga_operador
FOREIGN KEY (operador_id)
REFERENCES operadores(id)
ON DELETE CASCADE);