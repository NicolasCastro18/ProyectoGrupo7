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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad_y_Sucursal
{
    public partial class frmAltaBarrio : Form
    {
        public frmAltaBarrio()
        {
            InitializeComponent();
            CargarComboLocalidades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del nuevo barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=200.69.137.167,11333;Initial Catalog=BD3K7G06_2022;Persist Security Info=True;User ID=BD3K7G06_2022;Password=PSW06_01001");
                conexion.Open();
                string consulta = "INSERT INTO Barrios (nombre, id_localidad) VALUES ('" + txtNombre.Text + "','" + comboLocBarrio.SelectedValue + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego el nuevo barrio correctamente.", "Exito", MessageBoxButtons.OK);
                conexion.Close();
                this.Close();
            }
        }

        private void CargarComboLocalidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Localidad";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboLocBarrio.DataSource = tabla;
            comboLocBarrio.DisplayMember = "nombre";
            comboLocBarrio.ValueMember = "id_localidad";

        }
    }
}
