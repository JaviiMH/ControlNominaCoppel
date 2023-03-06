
CREATE or ALTER procedure [dbo].ReporteMovimientosEmpleados
(
	@fechaIni int
)
AS
BEGIN 
	                                   
		
	declare @HorasTrabajadas decimal(8, 2), @PagoTotalHoras decimal(8, 2), @PagoTotalBonos decimal(8, 2)
	create table #SalarioEmpleados(
		NumEmpleado int,
		FechaMovimiento date,	
		NumMovimientos int, 
		HorasTrabajadas decimal(8, 2), 
		PagoTotalHoras decimal(8, 2), 
		PagoTotalBonos decimal(8, 2),
		PagoTotalEntregas decimal(8, 2),
		
	)

	insert INTO #SalarioEmpleados
	SELECT NumEmpleado = e.NumEmpleado,
		FechaMovimiento = me.FechaMovimiento,
		NumMovimientos = me.NumMovimientos, 
		HorasTrabajadas = (8 * 6) * 4, 
		PagoTotalHoras = ((30 * 8) * 6) * 4, 
		PagoTotalBonos = CASE WHEN e.RolId = 1 THEN ((10 * 8) * 6) * 4 
							WHEN e.RolId = 2 THEN ((5 * 8) * 6) * 4
							ELSE 0 END,
		PagoTotalEntregas = (5 * me.NumMovimientos)
	from MovimientosEmpleados me
	LEFT JOIN Empleados e (NOLOCK) on me.NumEmpleados = e.NumEmpleado
	where MONTH(me.FechaMovimiento) = @fechaIni

	SELECT e.NumEmpleado, 
			e.Nombre_empleado,
			FechaMovimiento, 
			NumMovimientos, 
			HorasTrabajadas, 
			PagoTotalHoras, 
			PagoTotalBonos,
			PagoTotalEntregas,
			RolId = CASE WHEN e.RolId = 1 THEN 'Chofer'
						WHEN e.RolId = 2 THEN 'Cargador'
						WHEN e.RolId = 3 THEN 'Auxiliar'
					END,
			@fechaIni mMesId,
			Retenciones = CASE WHEN (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) + (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04)) > 10000 THEN (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas )+  (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04)) * 0.11
								ELSE SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.09 END,
			Vales = (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04),
			SueldoTotal = CASE WHEN (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas )+  (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04)) > 10000 THEN( SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) + (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04))-(SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.11)
							ELSE ( SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) + (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.04)) - (SUM(PagoTotalHoras + PagoTotalBonos  + PagoTotalEntregas ) * 0.09) END
	
	from #SalarioEmpleados se
	LEFT JOIN Empleados e (NOLOCK) on se.NumEmpleado = e.NumEmpleado
	where MONTH(se.FechaMovimiento) = @fechaIni
	GROUP BY e.NumEmpleado ,Nombre_empleado,
			FechaMovimiento, 
			NumMovimientos, 
			HorasTrabajadas, 
			PagoTotalHoras, 
			PagoTotalBonos,
			PagoTotalEntregas,
			RolId
 
 

END