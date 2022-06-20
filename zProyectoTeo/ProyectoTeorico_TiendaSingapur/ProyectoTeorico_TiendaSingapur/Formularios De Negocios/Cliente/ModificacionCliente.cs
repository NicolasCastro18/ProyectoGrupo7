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
    public partial class ModificacionCliente : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public int id_Barrio { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Id_cliente { get; set; }
        public ModificacionCliente()
        {
            InitializeComponent();
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.Nombre.ToString();
            this.txtApellido.Text = this.Apellido.ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Clientes set nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + 
                 "',telefono ='" + txtTelefono.Text + "', calle ='" + txtCalle.Text + "',nro_calle = '" + txtAltura.Text + "', id_barrio = '" + cboBarrio.SelectedValue + "' where id_cliente = '" + Id_cliente + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Se actualizaron los datos del cliente con exito.");
        }
    }
}
