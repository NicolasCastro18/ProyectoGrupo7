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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Cliente
{
    public partial class frmBajaYMod : Form
    {
        public frmBajaYMod()
        {
            InitializeComponent();
        }

        private void frmBajaYMod_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select id_cliente, apellido, nombre, telefono, id_barrio, calle, nro_calle From Clientes where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dgvCliente.DataSource = tabla;



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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Cliente set borrado = " + 1 + "where id_cliente = '" + txtId.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Color borrado");
        }    

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionCliente cb;
            cb = new ModificacionCliente();
            cb.Nombre = (string)dgvCliente.CurrentRow.Cells[2].Value;
            cb.Apellido = (string)dgvCliente.CurrentRow.Cells[1].Value;
            cb.Telefono = (int)dgvCliente.CurrentRow.Cells[3].Value;
            cb.Calle = (string)dgvCliente.CurrentRow.Cells[5].Value;
            cb.NroCalle = (int)dgvCliente.CurrentRow.Cells[6].Value;
            cb.id_Barrio = (int)dgvCliente.CurrentRow.Cells[4].Value;
            cb.Id_cliente = (int)dgvCliente.CurrentRow.Cells[0].Value;
            cb.ShowDialog();

            cb.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            string id = string.Empty;
            id = txtId.Text;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "Select id_cliente, apellido, nombre, telefono, id_barrio, calle, nro_calle From Clientes where id_cliente = '" + id + "'  and borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            dgvCliente.DataSource = tabla;
        }
    }
}
