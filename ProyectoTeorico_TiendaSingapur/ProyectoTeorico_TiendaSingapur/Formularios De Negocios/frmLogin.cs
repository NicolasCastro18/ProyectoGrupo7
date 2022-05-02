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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G06_2022;Persist Security Info=True;User ID=BD3K7G06_2022;Password=***********
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña.Text;
                bool resultado = false;

                resultado = ValidarUsuario(nombreUsuario, contraseña);
                if (resultado == true)
                {
                    frmPrincipal ventana = new frmPrincipal();
                    ventana.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

                
            }
            

        }

        private bool ValidarUsuario(string nombre, string password)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            string consulta = "Select *  From Empleado where nombreUsuario like '" + nombre + "'And  contraseña like '" + password + "'";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open(); 
            cmd.Connection = cn;

            DataTable tabla = new DataTable();  

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                resultado = true;

            }
            else
            {
                resultado = false;  
            }

            return resultado;

        }
    }
}
