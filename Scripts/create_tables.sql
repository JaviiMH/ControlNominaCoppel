
CREATE database NominaCoppel;
use NominaCoppel;

CREATE table Empleados(
	NumEmpleado int,
	Nombre_empleado varchar(200),
	RolId int
)
go
CREATE table MovimientosEmpleados(
	NumEmpleados int ,
	FechaMovimiento date,
	NumMovimientos int
)