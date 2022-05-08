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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios
{
    
    public partial class frmAltaEmpleado : Form
    {
        
        bool resultado = false;
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //bool resultado = false;
            if (this.txtLegajo.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtNombreUsuario.Text == "" || this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
            }
            else
            {
                try
                {
                    bool resultado = InsertarUsuario(txtNombreUsuario.Text, txtApellido.Text);

                    if (resultado)
                    {
                        MessageBox.Show("Empleado dado de alta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                               
                }
                catch (Exception)
                {

                    throw;
                }
               

            }
        }

        private bool InsertarUsuario(string nombre, string contraseña)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into Empleado (nombre, apellido, nombreUsuario, contraseña, mail, telefono, calle, nroCalle, id_barrio, legajo) values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtNombreUsuario.Text + "', " +
                    "'" + txtContraseña.Text + "','" + txtMail.Text + "','" + txtTelefono.Text + "', '" + txtCalle.Text + "','" + txtAltura.Text + "', '" + cboBarrio.SelectedValue+ "', '" + txtLegajo.Text + "')";
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




            return    resultado;
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
                DataTable tabla =  new DataTable();

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
       

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtAltura.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCalle.Text = "";
            this.txtContraseña.Text = "";
            this.txtNombreUsuario.Text = "";
            this.txtTelefono.Text = "";
            this.txtMail.Text = "";
            this.cboBarrio.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblBarrio_Click(object sender, EventArgs e)
        {

        }
    }
}
