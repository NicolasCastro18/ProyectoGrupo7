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
    public partial class frmAltaSucursal : Form
    {
        public frmAltaSucursal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la nueva sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conexion = new SqlConnection(@"server=200.69.137.167,11333;Initial Catalog=BD3K7G06_2022;Persist Security Info=True;User ID=BD3K7G06_2022;Password=PSW06_01001");
                conexion.Open();
                string consulta = "INSERT INTO Sucursal (nombre) VALUES ('" + txtNombre.Text + "')";
                SqlCommand agregado = new SqlCommand(consulta, conexion);
                agregado.ExecuteNonQuery();
                MessageBox.Show("Se agrego la nueva sucursal correctamente.", "Exito", MessageBoxButtons.OK);
                conexion.Close();
                this.Close();
            }
        }
    }
}
