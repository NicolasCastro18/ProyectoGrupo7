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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Empleado
{
    public partial class ModificacionEmpleado : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public int id_Barrio { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Id_empleado { get; set; }
        public ModificacionEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificacionEmpleado_Load(object sender, EventArgs e)
        {

            this.txtNombre.Text = this.Nombre.ToString();   
            this.txtApellido.Text = this.Apellido.ToString();
            this.txtNombreUsuario.Text = this.NombreUsuario.ToString();
            this.txtContraseña.Text = this.Contraseña.ToString();
            this.txtMail.Text = this.Mail.ToString();
            this.txtTelefono.Text = this.Telefono.ToString();   
            this.txtCalle.Text = this.Calle.ToString(); 
            this.txtAltura.Text = this.NroCalle.ToString();
            this.cboBarrio.Text = this.id_Barrio.ToString();
            CargarCombo();
        }
        private void CargarCombo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Barrios where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboBarrio.DataSource = tabla;
                cboBarrio.DisplayMember = "nombre";
                cboBarrio.ValueMember = "id_barrio";
                cboBarrio.SelectedIndex = -1;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Empleado set nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', nombreUsuario = '" + txtNombreUsuario.Text + "',contraseña = " +
                "'" + txtContraseña.Text + "', mail = '" + txtMail.Text + "',telefono ='" + txtTelefono.Text + "', calle ='" + txtCalle.Text + "',nroCalle = '" + txtAltura.Text + "', id_barrio = '" + cboBarrio.SelectedValue + "' where id_empleado = '" + Id_empleado + "'" ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Se actualizaron los datos del empleado correctamente.");
        }
    }
}
