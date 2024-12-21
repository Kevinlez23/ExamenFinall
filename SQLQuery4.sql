create database examenFinal
go

use examenFinal
go 

create table Proyectos 
(
	Proyectoid int identity primary key,
	codigo int not null unique,
	Nombre varchar(50) not null unique,
	Fechainicio date,
	Fechafin date,
	)

	create procedure ingresarProyecto
	@codigo int,
	@Nombre varchar(50),
	@Fechainicio date,
	@Fechafin date
	as
		begin
			insert into Proyectos values (@codigo, @Nombre, @Fechainicio, @Fechafin) 
		end

	create procedure borrarProyecto
	@Proyectoid int

	as
		begin
		delete Proyectos where Proyectoid= @Proyectoid
		end

create procedure consultaProyectos

 as
	begin
	select * from Proyectos
	end


create table Empleados
(
	Empleadosid int identity primary key,
	Numerocarnet int not null unique,
	Nombre varchar(50) not null,
	FechaNacimiento date,
	Categoriasid int foreign key references Categorias(Categoriaid),
	Salario INT DEFAULT 250000 CHECK (Salario BETWEEN 250000 AND 500000),
	Direccion varchar(100) default 'SanJose',
	Telefono int,
	Correo varchar(50) not null unique
	)

		create procedure ingresarEmpleado
	@Numerocarnet int,
	@Nombre varchar(50),
	@FechaNacimiento date,
	@Categoriasid int,
	@Salario int,
	@Direccion varchar(50),
	@Telefono int,
	@Correo varchar (50)
	as
		begin
			insert into Empleados values (@Numerocarnet, @Nombre, @FechaNacimiento, @Categoriasid, @Salario, @Direccion, @Telefono, @Correo) 
		end

	create procedure borrarEmpleado
	@Empleadosid int

	as
		begin
		delete Empleados where Empleadosid= @Empleadosid
		end


CREATE PROCEDURE consultaEmpleadoPorCategoria
    @Categoriaid INT -- 
AS
BEGIN
    SELECT * 
    FROM Empleados
    WHERE Categoriasid = @Categoriaid;
END;

create procedure consultaEmpleados

 as
	begin
	select * from Empleados
	end

	
	create table Asignaciones
	(
	Asignacionesid int identity primary key,
	Empleadoid int foreign key references Empleados(Empleadosid),
	Proyectoid int foreign key references Proyectos(Proyectoid),
	FechaAsignacion date
	)

	
	create table Categorias 
(
    Categoriaid int identity primary key,
    NombreCategoria VARCHAR(50) NOT NULL UNIQUE
)

INSERT INTO Categorias (NombreCategoria)
VALUES ('Administrador'), ('Operario'), ('Peon');


