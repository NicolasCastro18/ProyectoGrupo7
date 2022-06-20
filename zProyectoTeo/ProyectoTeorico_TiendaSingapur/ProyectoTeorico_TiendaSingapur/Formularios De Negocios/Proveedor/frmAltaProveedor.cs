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
    public partial class frmAltaProveedor : Form
    {
        public frmAltaProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAltaProveedor_Load(object sender, EventArgs e)

        {
            CargarCombo();
        }

        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (this.txtNombreProveedor.Text == "" || this.txtApellidoProveedor.Text == "" || this.txtMailProveedor.Text == "" || this.txtTelefonoProveedor.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta al Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {   
                
                try
                {
                    
                    bool resultado = InsertarProveedor(txtNombreProveedor.Text, txtApellidoProveedor.Text, txtMailProveedor.Text, txtTelefonoProveedor.Text, txtCalleProveedor.Text, txtAlturaProveedor.Text);

                    if (resultado)
                    {
                        MessageBox.Show("Proveedor dado de alta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

      
        private bool InsertarProveedor(string nombre, string apellido, string mail, string telefono, string calle , string altura)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into Proveedor (nombre, apellido, mail, telefono, calle, nro_Calle, id_barrio) values (@nom, @apell, @mail, @telefono, @call, @nroCall, '" + cboBarrio.SelectedValue + "')";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom",nombre);
                cmd.Parameters.AddWithValue("@apell",apellido);
                cmd.Parameters.AddWithValue("@mail",mail);
                cmd.Parameters.AddWithValue("@telefono",telefono);
                cmd.Parameters.AddWithValue("@call",calle);

                cmd.Parameters.AddWithValue("@nroCall", altura);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            this.txtNombreProveedor.Text = "";
            this.txtApellidoProveedor.Text = "";
            this.txtCalleProveedor.Text = "";
            this.txtTelefonoProveedor.Text = "";
            this.txtMailProveedor.Text = "";
            

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
    }
    
    
}
