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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.TipoArticulo
{
    public partial class frmTipoArticulo : Form
    {
        public frmTipoArticulo()
        {
            InitializeComponent();
        }

        private void frmTipoArticulo_Load_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

                SqlConnection cn = new SqlConnection(cadenaConexion);

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT * FROM TipoPrenda WHERE borrado = 0";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    grillaTipoArticulo.DataSource = tabla;

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
                MessageBox.Show("ERROR. Ingrese un ID.");
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

                SqlConnection cn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TipoPrenda WHERE id_TipoPrenda = '" + idBusqueda + "'  and borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaTipoArticulo.DataSource = tabla;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            cargarGrilla();
        }
    }   
}
