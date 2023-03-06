using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ControlEmpleadosCoppel.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlEmpleadosCoppel.Datos
{
   
    public class DBCatalogos : DBHelper
    {
        private static string SP_dboConsultaEmpleado = "dbo.ConsultaEmpleado";
        private static string SP_ReporteMovimientosEmpleados = "dbo.ReporteMovimientosEmpleados";
        private static string SP_AltaEmpleados = "dbo.AltaEmpleados";
        private static string SP_CapturaMovimientoEmpleado = "dbo.CapturaMovimientoEmpleado";



        public static DataTable ConsultaEmpleado(int NumEmpleado, int mes)
        {
            DataTable dt = null;
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@NumEmpleado", NumEmpleado != null ? NumEmpleado : 0));
                parametros.Add(new SqlParameter("@Mes", mes ));
                dt = EjecutarSPConResultados(SP_dboConsultaEmpleado, parametros.ToArray());
            }
            catch (Exception error)
            {

            }
            return dt;
        }

        public static DataTable ReporteMovimientosEmpleados(string fechaIni, string fechaFin)
        {
            DataTable dt = null;
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@fechaIni", fechaIni != null ? fechaIni : ""));
                parametros.Add(new SqlParameter("@fechaFin", fechaFin != null ? fechaFin : ""));
                dt = EjecutarSPConResultados(SP_ReporteMovimientosEmpleados, parametros.ToArray());
            }
            catch (Exception error)
            {

            }
            return dt;
        }
       
        public static DataTable AltaEmpleados(EmpleadosModel empleado)
        {
            bool result = true;
            DataTable dt = null;
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@NumEmpleado", empleado.NumEmpleado));
                parametros.Add(new SqlParameter("@Nombre_empleado", empleado.Nombre_empleado));
                parametros.Add(new SqlParameter("@RolId", empleado.RolId));

                dt = EjecutarSPConResultados(SP_AltaEmpleados, parametros.ToArray());
            }
            catch (Exception Ex)
            {
                result = false;
            }
            return dt;
        }
       
       
        public static DataTable CapturaMovimientoEmpleado(MovimientosModel model)
        {
            DataTable dt = null;
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@NumEmpleado", model.NumEmpleado));
                parametros.Add(new SqlParameter("@Mes", model.FechaMovimiento ));
                parametros.Add(new SqlParameter("@NumMovimientos", model.NumMovimientos ));
                dt = EjecutarSPConResultados(SP_CapturaMovimientoEmpleado, parametros.ToArray());
            }
            catch (Exception error)
            {

            }
            return dt;
        }
      
        
       
       

    }
}

