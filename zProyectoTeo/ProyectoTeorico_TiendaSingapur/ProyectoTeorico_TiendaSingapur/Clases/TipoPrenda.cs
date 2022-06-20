using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeorico_TiendaSingapur.Clases
{
    public class TipoPrenda
    {
        public int Id_tipoPrenda { get; set; }
        public string Nombre { get; set; }
        public static DataTable ObtenerTipoPrendas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From TipoPrenda where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

                //cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
