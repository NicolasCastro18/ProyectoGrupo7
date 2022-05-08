using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Articulo
{
    public partial class frmAltaArticulos : Form
    {
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProveedor.Text == "" || cboMarca.Text == "" || cboColor.Text == "" || cboTemporada.Text == "" || cboTipoPrenda.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para ingresar el nuevo articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoPrenda.Focus();
            }
            else
            {
                try
                {
                    bool resultado = InsertarArticulo();

                    if (resultado)
                    {
                        MessageBox.Show("Articulo cargado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fo = new OpenFileDialog();
                DialogResult rs = fo.ShowDialog();
                if (rs == DialogResult.OK)
                {

                    pbArticulo.Image = Image.FromFile(fo.FileName);
                    //string nombreImagen = Path.GetFileName(fo.FileName);
                    pbArticulo.Tag = Path.GetFileName(fo.FileName);

                }

                Size = new Size(778, 508);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo. Intente nuevamente.");
            }
        }
        private void CargarCombo1()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From TipoPrenda where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboTipoPrenda.DataSource = tabla;
                cboTipoPrenda.DisplayMember = "nombre";
                cboTipoPrenda.ValueMember = "id_TipoPrenda";
                cboTipoPrenda.SelectedIndex = -1;
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
        private void CargarCombo2()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Marca where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboMarca.DataSource = tabla;
                cboMarca.DisplayMember = "nombre";
                cboMarca.ValueMember = "id_marca";
                cboMarca.SelectedIndex = -1;
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
        private void CargarCombo3()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Temporada where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboTemporada.DataSource = tabla;
                cboTemporada.DisplayMember = "nombre";
                cboTemporada.ValueMember = "id_temporada";
                cboTemporada.SelectedIndex = -1;
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
        private void CargarCombo4()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Color where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboColor.DataSource = tabla;
                cboColor.DisplayMember = "nombre";
                cboColor.ValueMember = "id_color";
                cboColor.SelectedIndex = -1;
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
        private void CargarCombo5()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * From Proveedor where borrado = 0";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboColor.DataSource = tabla;
                cboColor.DisplayMember = "nombre";
                cboColor.ValueMember = "id_proveedor";
                cboColor.SelectedIndex = -1;
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


        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            CargarCombo1();
            CargarCombo2();
            CargarCombo3();
            CargarCombo4();
            CargarCombo5();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool InsertarArticulo()
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into Articulos(id_tipoPrenda, id_color, id_marca, stock, precio, id_temporada, id_proveedor, nombreImagen) values ('" + cboTipoPrenda.SelectedValue + "','" + cboColor.SelectedValue + "', '" + cboMarca.SelectedValue + "', '" + nupStock.Value+ "','" + nupPrecio.Value + "','" + cboTemporada.SelectedValue + "', '" + cboProveedor.SelectedValue + "', '" + pbArticulo.Tag + "')";
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
    }
}
