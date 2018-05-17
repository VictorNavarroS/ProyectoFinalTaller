use ProyectoTaller

select * from usuarios;
select * from productos;
select distinct(tipo_operacion) from operacion;

------------------------- Procedimiento Nuevo Usuario-------------------------
alter procedure Nuevo_usuario
@rut varchar (12),
@nombre1 varchar(50), 
@nombre2 varchar(50), 
@apellido1 varchar(50),
@apellido2 varchar(50), 
@correo varchar(150),
@contraseña varchar(50),
@cargo int,
@estado bit
as
begin	
	begin
		if exists (select * from usuarios where rut = @rut)
			begin
			raiserror ('Este RUT ya posee una cuenta',11,1);
			end;			
		else
			begin
			insert into usuarios values (@rut,@nombre1,@nombre2,@apellido1,@apellido2,@correo,@contraseña,@cargo,@estado);
			end;
	end;
end;
------------------------- Procedimiento Actualiza Usuarios-------------------------
create procedure actualizaUsuarios
@rut varchar (13),
@nombre1 varchar(50), 
@nombre2 varchar(50) ,
@apellido1 varchar(50), 
@apellido2 varchar(50) ,
@correo varchar(150),
@contraseña varchar(30),
@cargo int ,
@estado bit
as 
begin
	update usuarios set nombre1=@nombre1,nombre2=@nombre2,apellido1=@apellido1,apellido2=@apellido2,correo =@correo,
	contraseña=@contraseña,cargo=@cargo,estado=@estado where rut=@rut;
end;



------------------------- Procedimiento Nuevo Producto-------------------------

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[validaRegistroProducto]  @serie varchar(50) ,@nombre varchar(50) ,@descripcion varchar(50) ,@estado bit,@stock int ,@stockMin int ,@ubicacion varchar(20) ,@valorCompra int ,@proveedor int
as
begin
if exists(select serie from productos where serie = @serie)
begin
	raiserror('La serie ingresada ya existe en la base de datos',11,1);
end
else
begin
	declare @valor_venta int;
	select @valor_venta=@valorCompra+(@valorCompra*0.2)
	insert into productos values (@serie ,@nombre ,@descripcion ,@valorCompra ,@valor_venta ,@stock ,@stockMin ,@ubicacion ,@proveedor, @estado )
end
end
GO
------------------------- Procedimiento Actualiza producto-------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[validaActualizacionProductos]  @serie varchar(50) ,@nombre varchar(50) ,@descripcion varchar(50) ,@valorCompra int ,@stock int ,@stockMin int ,@ubicacion varchar(20) ,@proveedor int, @estado bit
as
begin
if not exists(select serie from productos where serie = @serie)
begin
	raiserror('El rut ingresado no existe en la base de datos',11,1);
end
else
begin
declare @valorventa int;
select @valorventa=@valorCompra+(@valorCompra*0.2);
	update productos set 
	nombre=@nombre ,
	descripcion=@descripcion ,
	valor_compra = @valorCompra,
	valor_venta=@valorventa,
	stock = @stock,
	stock_minimo = @stockMin,
	ubicacion = @ubicacion,
	proveedor = @proveedor,
	estado = @estado
	where serie = @serie
end
end
GO
------------------------- Procedimiento Nuevo Cargo-------------------------
create procedure Nuevo_cargo
@nombre_cargo varchar(50),
@Permisos int,
@estado bit
as
begin
	begin
		if exists (select * from cargo where nombre_cargo=@nombre_cargo)
			begin
			raiserror ('Este cargo ya Existe',11,1);
			end;
		else
			begin
			insert into cargo values (@nombre_cargo,@Permisos,@estado);
			end;
	end;
end;
-------------------------Procedimiento Actualiza Cargo-------------------------
create procedure actualizaCargo
@nombre_cargo varchar(50) ,
@Permisos int,
@estado bit
as 
begin
	update cargo set Permisos=@Permisos,estado=@estado where nombre_cargo=@nombre_cargo;
end;

------------------------- Procedimiento Nuevo Proveedor-------------------------
create procedure Nuevo_Proveedor
@nombre_proveedor varchar (50),
@telefono_contacto int ,
@correo_contacto varchar (50),
@estado bit
as
begin
	begin
		if exists (select * from proveedor where nombre_proveedor=@nombre_proveedor)
			begin
			raiserror ('Este Proveedor ya Existe',11,1);
			end;
		else
			begin
			insert into proveedor values (@nombre_proveedor,@telefono_contacto,@correo_contacto,@estado);
			end;
	end;
end;
------------------------- Procedimiento Actualiza proveedor-------------------------
create procedure actualizaProveedores
@nombre_proveedor varchar (50),
@telefono_contacto int ,
@correo_contacto varchar (50),
@estado bit
as 
begin
	update proveedor set  telefono_contacto=@telefono_contacto,correo_contacto=@correo_contacto,estado=@estado where nombre_proveedor=@nombre_proveedor;
end;

------------------------- Procedimiento Nueva operacion-------------------------
alter procedure Nueva_Operacion
@usuario int,
@tipo_operacion int ,
@descripcion varchar(80) 
as
begin
	declare @fechaOperacion date;
	select @fechaOperacion = GETDATE();
	insert into operacion values(@usuario,@tipo_operacion,@descripcion,@fechaOperacion)
end;

------------------------- Procedimiento Nueva Venta-------------------------
create procedure Nueva_Venta
@usuario int,
@cantidad_productos int ,
@total_venta int ,
@NroOperacion int 
as
begin
	insert into ventas values(@usuario,@cantidad_productos,@total_venta ,@NroOperacion);

end;

------------------------- Procedimiento NuevoDetalleVenta-------------------------
alter procedure NuevoDetalleVenta
@id_venta int,
@id_usuario int ,
@serie_producto varchar(50) ,
@nombre_producto varchar(50) ,
@cantidad int ,
@valor_unitario int
as
begin
	insert into detalle_venta values(@id_venta,@id_usuario,@serie_producto,@nombre_producto,@cantidad,@valor_unitario);
	update productos set stock=stock-@cantidad where serie=@serie_producto;
end;

-------------------------Procedimiento Actualiza estado producto-------------------------
drop trigger actualizacionEstadoProducto
on productos
instead of update
as
begin
	declare @id_producto int;
	declare @stock int;
	declare @estado bit;
	declare @estado2 bit;
	declare @cantidad int;
	declare @serie_producto varchar (50);
	select @serie_producto=  i.serie from inserted i;
	select @id_producto= i.id_producto from inserted i;
	select @stock = stock from productos where id_producto=@id_producto;
	select @estado = i.estado from inserted i;
	select @estado2 = d.estado from deleted d where id_producto=@id_producto;
	if @estado != @estado2
		begin
			if @estado= 0 and @estado2 = 1
				begin
					if @stock = 0 
						begin
							update productos set estado = @estado where id_producto = @id_producto;
						end;		
					else
						begin
							raiserror ( 'No se pueden desactivar productos con existencias',11,1);
						end;
				end;
			else
				begin
					update productos set estado = @estado where id_producto = @id_producto;
				end;
		end;
end;

update productos set stock=stock-2 where serie='serie';