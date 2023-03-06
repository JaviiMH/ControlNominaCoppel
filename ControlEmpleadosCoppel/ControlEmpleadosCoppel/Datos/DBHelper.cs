using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ControlEmpleadosCoppel.Datos
{
    public class DBHelper
    {
        private static string ObtenerConexion()
        {
            return ConfigurationManager.ConnectionStrings["coppelLocal"].ConnectionString;
        }

       
        protected static DataTable EjecutarSPConResultados(string pNombreSP, SqlParameter[] pParametros)
        {

            DataTable dt = new DataTable();
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cnn = new SqlConnection("Server=JAVIER-MEDINA;Database= NominaCoppel; Integrated Security=True;");
                cnn.Open();

                cmd = cnn.CreateCommand();

                cmd.CommandText = pNombreSP;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 1000;

                if (pParametros != null)
                {
                    cmd.Parameters.AddRange(pParametros);
                }


                reader = cmd.ExecuteReader();

                dt.Load(reader);


            }
            catch (Exception ex) { throw ex; }
            finally
            {

                if (cnn.State == System.Data.ConnectionState.Open) { cnn.Close(); }
                if (cnn != null) { cnn.Dispose(); cnn = null; }
                if (cmd != null) { cmd.Dispose(); cmd = null; }
            }

            return dt;
        }
      
       
    }
}
