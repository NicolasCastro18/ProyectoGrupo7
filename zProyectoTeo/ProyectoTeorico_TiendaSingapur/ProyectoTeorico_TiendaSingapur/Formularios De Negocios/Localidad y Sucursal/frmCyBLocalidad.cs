using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    public partial class frmCyBLocalidad : Form
    {
        public frmCyBLocalidad()
        {
            InitializeComponent();
        }

        private void cargarGrilla()
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT * FROM Localidad WHERE borrado = 0";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    grillaLocalidad.DataSource = tabla;

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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            cargarGrilla();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idBusqueda = string.Empty;
            idBusqueda = txtBuscar.Text;
            if (idBusqueda == "")
            {
                MessageBox.Show("ERROR. Ingrese un nombre de localidad.");
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Localidad WHERE nombre = '" + idBusqueda + "'  and borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                grillaLocalidad.DataSource = tabla;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Localidad set borrado = " + 1 + "where nombre = '" + txtBuscar.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Localidad borrada.");
        }

        private void frmCyBLocalidad_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
