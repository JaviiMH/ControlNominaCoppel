
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or ALTER procedure [dbo].CapturaMovimientoEmpleado
(
	
	@NumEmpleado int,
	@Mes int,
	@NumMovimientos int
)
AS
BEGIN 
	
	insert INTO MovimientosEmpleados (NumEmpleados, FechaMovimiento, NumMovimientos) values (@NumEmpleado,  DATEFROMPARTS(YEAR(GETDATE()), @Mes, 1), @NumMovimientos)
 

END
