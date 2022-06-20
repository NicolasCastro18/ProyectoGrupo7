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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Proveedor
{
    public partial class frmCyBProveedor : Form
    {
        public frmCyBProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Proveedor where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dgvProveedor.DataSource = tabla;



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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ConsultarProveedor(txtNombre.Text);

           

            }
            catch (Exception)
            {

                MessageBox.Show("Error en la consulta, intente nuevamente");
            }
        }

        private void ConsultarProveedor(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Proveedor where borrado = 0 AND nombre LIKE '%@nom%' ";
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dgvProveedor.DataSource = tabla;

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
               
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCyBProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                bool resultado = EliminarProveedor(int.Parse(txtIdProveedor.Text));

                if (resultado)
                {
                    MessageBox.Show("Proveedor Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

                throw;
            }



            
           
        }
        private bool EliminarProveedor(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            try
            {
                SqlConnection cn = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                string consulta = "Update Proveedor set borrado = " + 1 + "where id_proveedor = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Proveedor borrado");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al intentar borrar Proveedor");
                return false;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
