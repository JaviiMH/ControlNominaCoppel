using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using ControlEmpleadosCoppel.Models;
using ControlEmpleadosCoppel.Datos;
using Microsoft.AspNetCore.Mvc;

namespace ControlEmpleadosCoppel.Logica
{
    [Produces("application/json")]
    [Route("api/empleados")]
    public class LogicaDatos
    {
        public static DataTable ConsultaEmpleado(int NumEmpleado, int mes)
        {
            return DBCatalogos.ConsultaEmpleado(NumEmpleado, mes);
        }
       
        public static DataTable ReporteMovimientosEmpleados(string fechaIni)
        {
            return DBCatalogos.ReporteMovimientosEmpleados(fechaIni);
        }
        [HttpGet]
        public static DataTable AltaEmpleados(int NumEmpleado, string Nombre_empleado, int RolId)
        {
            return DBCatalogos.AltaEmpleados( NumEmpleado,  Nombre_empleado,  RolId);
        }
        public static DataTable CapturaMovimientoEmpleado(int NumEmpleado, string Nombre_empleado, int RolId, int MesID, int NumEntregas)
        {
            return DBCatalogos.CapturaMovimientoEmpleado(NumEmpleado, Nombre_empleado, RolId, MesID, NumEntregas);
        }
       
    }
}
