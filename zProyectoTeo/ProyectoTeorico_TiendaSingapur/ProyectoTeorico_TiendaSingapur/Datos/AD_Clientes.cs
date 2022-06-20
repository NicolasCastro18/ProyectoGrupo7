using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTeorico_TiendaSingapur.Datos
{
    public class AD_Clientes
    {
        public int Id { get; set; }
        public int CUIL { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; } = "hola";
        public int NroCalle { get; set; } = 4;
        public int Telefono { get; set; }
        public static DataTable ObtenerClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Clientes where borrado = 0";
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
        public static string ObtenerCalleClientesxId(int ID)
        {
            string resultado = "";
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select calle From Clientes where borrado = 0 where id_cliente = " + ID;
                cn.Open();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;
                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    resultado = sqlReader.GetValue(0).ToString();
                }

                sqlReader.Close();
                
                return resultado;
                

                //cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return ""; 
                
            }

            finally
            {
                cn.Close();
            }
        }
        public static string ObtenerCuilCliente(int ID)
        {
            string resultado = "";
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand(); 
                string consulta = "Select cuil From Clientes where borrado = 0 where id_cliente = " + ID;
                cn.Open();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;
                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    resultado = sqlReader.GetValue(0).ToString();
                }

                sqlReader.Close();
                
                return resultado;




                //cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return "";

            }

            finally
            {
                cn.Close();
            }
        }
        
        public override string ToString()
        {
            return Nombre;
        }

    }
}
