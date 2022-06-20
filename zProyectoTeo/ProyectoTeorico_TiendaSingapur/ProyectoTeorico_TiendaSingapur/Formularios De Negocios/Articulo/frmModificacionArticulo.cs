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

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Articulo
{
    public partial class frmModificacionArticulo : Form
    {
        public int id_TipoPrenda { get; set; }
        public int id_Color { get; set; }
        public int id_Marca { get; set; }
        public int id_Temporada { get; set; }
        public int id_Proveedor { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string NombreImagen { get; set; }

        public frmModificacionArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificacionArticulo_Load(object sender, EventArgs e)
        {
            this.comboTipoPrenda.SelectedValue = this.id_TipoPrenda.ToString();
            this.comboTemporada.SelectedValue = this.id_Temporada.ToString();
            this.comboMarca.SelectedValue = this.id_Marca.ToString();
            this.comboProveedor.SelectedValue = this.id_Proveedor.ToString();   
            this.comboColor.SelectedValue = this.id_Color.ToString();
            this.nupPrecio.Text = this.Precio.ToString(); ;
            this.nupStock.Text = this.Stock.ToString(); ;

            CargarComboColor();
            CargarComboMarca();
            CargarComboTemporada();
            CargarComboTipoPrenda();
            
        }
        private void CargarComboTipoPrenda()
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM TipoPrenda where borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboTipoPrenda.DataSource = tabla;
            comboTipoPrenda.DisplayMember = "nombre";
            comboTipoPrenda.ValueMember = "id_TipoPrenda";
            comboTipoPrenda.SelectedIndex = -1;

        }

        private void CargarComboColor()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Color where borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboColor.DataSource = tabla;
            comboColor.DisplayMember = "nombre";
            comboColor.ValueMember = "id_color";
            comboColor.SelectedIndex = -1;

        }

        private void CargarComboMarca()
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Marca where borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboMarca.DataSource = tabla;
            comboMarca.DisplayMember = "nombre";
            comboMarca.ValueMember = "id_marca";
            comboMarca.SelectedIndex = -1;

        }

        private void CargarComboTemporada()
        {
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Temporada where borrado = 0";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            comboTemporada.DataSource = tabla;
            comboTemporada.DisplayMember = "nombre";
            comboTemporada.ValueMember = "id_temporada";
            comboTemporada.SelectedIndex = -1;

        }
       

    }
}
