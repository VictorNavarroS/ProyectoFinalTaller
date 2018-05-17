create database ProyectoTaller
use ProyectoTaller

-- creacion de tablas de la base de datos
create table proveedor(
id_proveedor int identity(1,1)primary key,
nombre_proveedor varchar (50) not null unique,
telefono_contacto int not null,
correo_contacto varchar (50) not null,
estado bit
);

create table permisos(
id_permiso int identity (1,1) primary key,
nombrePermiso varchar (20)not null
);
create table tipo_operacion(
Id_tipo int identity(1,1)primary key,
tipo_operacion varchar (40)not null
);
create table cargo(
id_cargo int identity(1,1)primary key,
nombre_cargo varchar(50) not null unique,
Permisos int foreign key references permisos(id_permiso)not null,
estado bit
);
create table usuarios(
id_usuario int identity(1,1)primary key,
rut varchar (13) not null unique,
nombre1 varchar(50) not null,
nombre2 varchar(50) ,
apellido1 varchar(50) not null,
apellido2 varchar(50) not null,
correo varchar(150) not null unique,
contraseña varchar(30)not null,
cargo int foreign key references cargo(id_cargo)not null,
estado bit
);
create table productos(
id_producto int identity(1,1)primary key,
serie varchar(50)not null unique ,
nombre varchar(50) not null,
descripcion varchar(50) not null,
valor_compra int not null,
valor_venta int ,
stock int not null,
stock_minimo int not null,
ubicacion varchar (20) not null,
proveedor int foreign key references proveedor(id_proveedor)not null,
estado bit not null
);

create table operacion(
numero_operacion int identity(1,1)primary key,
usuario int foreign key references usuarios(id_usuario)not null,
tipo_operacion int foreign key references tipo_operacion(id_tipo)not null,
descripcion varchar(80) ,
fechaOperacion date not null
);

alter table ventas(
id_venta int identity(1,1)primary key,
usuario int foreign key references usuarios(id_usuario)not null,
cantidad_productos int,
total_venta int,
NroOperacion int foreign key references operacion(numero_operacion)not null
);

create table detalle_venta(
id_venta int foreign key references ventas(id_venta)not null,
id_usuario int foreign key references usuarios(id_usuario)not null,
serie_producto varchar (50)foreign key references productos(serie),
nombre_producto varchar (50),
cantidad int not null,
valor_unitario int not null
);

-- creacion de proveedores
insert into proveedor values ('China',987654321,'china@proveedor.com',1);
insert into proveedor values ('EE.UU',555696924,'eeuu@proveedor.com',1);
insert into proveedor values ('India',999944442,'india@proveedor.com',1);
insert into proveedor values ('Brasil',654789123,'brasil@proveedor.com',1);

-- creacion de permisos
insert into permisos values('Administrador');
insert into permisos values('Usuario');

-- creacion de tipos de operacion
insert into tipo_operacion values('Venta');--1
insert into tipo_operacion values('Generar Reporte Venta');--2
insert into tipo_operacion values('Ingreso de producto');--3
insert into tipo_operacion values('Modificacion de producto');--4
insert into tipo_operacion values('Ingreso de Usuario');--5
insert into tipo_operacion values('Modificacion de Usuario');--6
insert into tipo_operacion values('Descuento de Stock');--7
insert into tipo_operacion values('Ingreso de Cargo');--8
insert into tipo_operacion values('Modificacion de Cargo');--9
insert into tipo_operacion values('Ingreso de Proveedor');--10
insert into tipo_operacion values('Modificacion de Proveedor');--11

-- creacion de cargos

insert into cargo values('Adminsitrador',1,1);
insert into cargo values('Administrador Ventas',1,1);
insert into cargo values('Administrador Bodega',1,1);
insert into cargo values('Vendedor',2,1);
insert into cargo values('Bodeguero',2,1);

-- creacion de usaurio de prueba
insert into usuarios values ('admin','admin',null,'de','sistema','administrador@acme.com','admin',1,1);
insert into usuarios values ('1-9','usuario','de','prueba','logueo','usuario@usuario.com','123456789',2,1);
insert into usuarios values ('2-9','bodeguero','de','prueba','logueo','bodeguero@usuario.com','12345',5,1);

-- creacion de producto de prueba
insert into productos values('serie1','mouse','descripcion',2000,2800,10,5,'1a',1,1);
insert into productos values('serie','teclado','asdasd',3000,5000,10,5,'1a',1,1);
insert into productos values('prueba','pantalla','asdasd',20000,50000,10,5,'1a',1,1);
insert into productos values('serie2','parlante','asdasd',10000,15000,10,5,'1a',1,1);

-- creacion de operacion de muestra
set dateformat dmy;
insert into operacion values (1,1,1,'descripcion de la venta',5,GETDATE());

----------------------------------------------------
select * from operacion
select * from ventas
select * from detalle_venta
select * from productos