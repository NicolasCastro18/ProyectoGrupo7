using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Empleado;
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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios
{
    public partial class frmCyBEmpleado : Form
    {
        public frmCyBEmpleado()
        {
            InitializeComponent();
        }

        private void frmCyBEmpleado_Load(object sender, EventArgs e)
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
                string consulta = "Select legajo, apellido, nombre, nombreUsuario, contraseña, mail, telefono, id_barrio, calle, nroCalle From Empleado where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dgvEmpleado.DataSource = tabla; 



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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            string id = string.Empty;
            id = txtLegajo.Text;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "Select legajo, apellido, nombre, nombreUsuario, contraseña, mail, telefono, id_barrio, calle, nroCalle From Empleado  where id_empleado = '" + id + "'  and borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            dgvEmpleado.DataSource = tabla;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // btnModificar.Enabled = true;
            //btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Empleado set borrado = " + 1 + "where legajo = '" + txtLegajo.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Empleado borrado");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionEmpleado cb;
            cb = new ModificacionEmpleado();
            cb.Nombre = (string)dgvEmpleado.CurrentRow.Cells[2].Value;
            cb.Apellido = (string)dgvEmpleado.CurrentRow.Cells[1].Value;
            cb.NombreUsuario = (string)dgvEmpleado.CurrentRow.Cells[3].Value;
            cb.Contraseña = (string)dgvEmpleado.CurrentRow.Cells[4].Value;
            cb.Mail = (string)dgvEmpleado.CurrentRow.Cells[5].Value;
            cb.Telefono = (int)dgvEmpleado.CurrentRow.Cells[6].Value;
            cb.Calle = (string)dgvEmpleado.CurrentRow.Cells[8].Value;
            cb.NroCalle = (int)dgvEmpleado.CurrentRow.Cells[9].Value;
            cb.id_Barrio = (int)dgvEmpleado.CurrentRow.Cells[7].Value;
            cb.Legajo = (int)dgvEmpleado.CurrentRow.Cells[0].Value;
            cb.ShowDialog();

            cb.Dispose();

        }
        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}
