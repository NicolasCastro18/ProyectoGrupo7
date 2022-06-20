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
    public partial class frmBYCArticulos : Form
    {
        public frmBYCArticulos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "Update Articulos set borrado = " + 1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cn.Open();
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Articulo borrado");
        }

        private void frmBYCArticulos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            CargarComboTipoPrenda();
            CargarComboColor();
            CargarComboMarca();
            CargarComboTemporada();
        }
        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select  T.nombre as 'nombreTipoPrenda', Te.nombre as 'nombreTemporada', A.precio, A.stock, M.nombre as 'nombreMarca', C.nombre as 'nombreColor', P.nombre as 'nombreProveedor', A.nombreImagen From Articulos A, Temporada Te, TipoPrenda T, Marca M, Color C, Proveedor P Where A.borrado = 0 and A.id_temporada = Te.id_temporada  and A.id_color = C.id_color and A.id_marca = M.id_marca and A.id_tipoPrenda = T.id_TipoPrenda and A.id_proveedor = p.id_proveedor ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dgvArticulo.DataSource = tabla;



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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
 
            string consulta1 = "SELECT T.nombre as 'nombreTipoPrenda', Te.nombre as 'nombreTemporada', A.precio, A.stock, M.nombre as 'nombreMarca', C.nombre as 'nombreColor', P.nombre as 'nombreProveedor', A.nombreImagen  FROM Articulos A join Temporada Te on (Te.id_temporada = A.id_temporada) join Marca M on(M.id_marca = A.id_marca) join Color C on(C.id_color = A.id_color) join TipoPrenda T on(T.id_TipoPrenda = A.id_tipoPrenda) join Proveedor P on(P.id_proveedor = A.id_proveedor) WHERE A.borrado = 0";
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            if (comboTipoPrenda.SelectedIndex != -1)
            {
                consulta1 = consulta1 + " and T.id_TipoPrenda = '" + comboTipoPrenda.SelectedValue + "'";
            }
           
            if (comboColor.SelectedIndex != -1)
            {
                consulta1 = consulta1 + " and C.id_color = '" + comboColor.SelectedValue + "'";
            }
           

            if (comboMarca.SelectedIndex != -1)
            {
                consulta1 = consulta1 + " and M.id_marca = '" + comboMarca.SelectedValue + "'";
            }
            

            if (comboTemporada.SelectedIndex != -1)
            {
                consulta1 = consulta1 + " and Te.id_temporada = '" + comboTemporada.SelectedValue + "'";
            }
            

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta1;
            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            dgvArticulo.DataSource = tabla;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void CargarComboTipoPrenda()
        {
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
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
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
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
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
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
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            comboTemporada.SelectedIndex = -1;
            comboTipoPrenda.SelectedIndex = -1;
            comboColor.SelectedIndex = -1;
            comboMarca.SelectedIndex = -1;

            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionArticulo cb;
            cb = new frmModificacionArticulo();
            cb.id_TipoPrenda = (int)dgvArticulo.CurrentRow.Cells[0].Value;
            cb.id_Color = (int)dgvArticulo.CurrentRow.Cells[1].Value;
            cb.id_Marca = (int)dgvArticulo.CurrentRow.Cells[2].Value;
            cb.Stock = (int)dgvArticulo.CurrentRow.Cells[3].Value;
            cb.id_Temporada =  (int)dgvArticulo.CurrentRow.Cells[4].Value;  
            cb.Precio = (int)dgvArticulo.CurrentRow.Cells[5].Value;
            cb.id_Proveedor = (int)dgvArticulo.CurrentRow.Cells[6].Value;
            cb.NombreImagen = (string)dgvArticulo.CurrentRow.Cells[7].Value;
        }
    }
}
