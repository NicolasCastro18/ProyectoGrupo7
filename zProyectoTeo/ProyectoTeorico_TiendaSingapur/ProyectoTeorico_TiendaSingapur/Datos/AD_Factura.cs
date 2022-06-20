using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeorico_TiendaSingapur.Datos
{
    public class AD_Factura
    {
        public static int ObtenerUltimoIdFactura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select MAX(nro_factura) From Factura where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;

                //cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
                
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
