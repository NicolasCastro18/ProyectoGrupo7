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
    public partial class frmCyBSucursal : Form
    {
        public frmCyBSucursal()
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
                    string consulta = "SELECT * FROM Sucursal WHERE borrado = 0";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    grillaSucursal.DataSource = tabla;

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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idBusqueda = string.Empty;
            idBusqueda = txtBuscar.Text;
            if (idBusqueda == "")
            {
                MessageBox.Show("ERROR. Ingrese un nombre de sucursal.");
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Sucursal WHERE nombre = '" + idBusqueda + "'  and borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                grillaSucursal.DataSource = tabla;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            cargarGrilla();
        }

        private void frmCyBSucursal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Sucursal set borrado = " + 1 + "where nombre = '" + txtBuscar.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Sucursal borrada.");
        }
    }
}
