
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or ALTER procedure [dbo].AltaEmpleados
(
	
	@NumEmpleado int,
	@Nombre_empleado varchar(500),
	@RolId int
)
AS
BEGIN 
	
	insert INTO Empleados (NumEmpleado, Nombre_empleado, RolId) values (@NumEmpleado, @Nombre_empleado, @RolId)
 

END