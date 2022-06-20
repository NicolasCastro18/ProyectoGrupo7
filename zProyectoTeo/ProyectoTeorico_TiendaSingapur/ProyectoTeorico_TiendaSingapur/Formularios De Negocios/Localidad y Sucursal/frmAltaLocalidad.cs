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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    public partial class frmAltaLocalidad : Form
    {
        public frmAltaLocalidad()
        {
            InitializeComponent();
            CargarComboProvincia();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la nueva localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=200.69.137.167,11333;Initial Catalog=BD3K7G06_2022;Persist Security Info=True;User ID=BD3K7G06_2022;Password=PSW06_01001");
                conexion.Open();
                string consulta = "INSERT INTO Localidad (nombre, id_provincia) VALUES ('" + txtNombre.Text + "','" + comboProvLocalidad.SelectedValue + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego la nueva localidad correctamente.", "Exito", MessageBoxButtons.OK);
                conexion.Close();
                this.Close();
            }
        }

        private void CargarComboProvincia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Provincia";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboProvLocalidad.DataSource = tabla;
            comboProvLocalidad.DisplayMember = "nombre";
            comboProvLocalidad.ValueMember = "id_provincia";

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
