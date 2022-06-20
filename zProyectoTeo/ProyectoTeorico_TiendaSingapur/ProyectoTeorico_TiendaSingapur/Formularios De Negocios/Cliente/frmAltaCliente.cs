using System;
using ProyectoTeorico_TiendaSingapur.Clases;
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
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtAltura.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCalle.Text = "";
            this.txtTelefono.Text = "";
            this.cboBarrioNASHI.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombo1()
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

                cboBarrioNASHI.DataSource = tabla;
                cboBarrioNASHI.DisplayMember = "nombre";
                cboBarrioNASHI.ValueMember = "id_barrio";
                cboBarrioNASHI.SelectedIndex = -1;
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


        private void button1_Click(object sender, EventArgs e)
        {

            //bool resultado = false;
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
            }
            else
            {
                try
                {
                    bool resultado = InsertarCliente(txtNombre.Text, txtApellido.Text);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente dado de alta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception)
                {

                    throw;
                }


            }
        }
        private bool InsertarCliente(string nombre, string contraseña)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into Clientes (nombre, apellido, telefono, calle, nro_Calle, id_barrio) values ('" + txtNombre.Text + "','" + txtApellido.Text + "','"  +  
                    txtTelefono.Text + "', '" + txtCalle.Text + "','" + txtAltura.Text + "', '" + cboBarrioNASHI.SelectedValue + "')";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }




            return resultado;
        }

        private void lblBarrio_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaCliente_Load_1(object sender, EventArgs e)
        {
            CargarCombo1();
        }
    }
}
