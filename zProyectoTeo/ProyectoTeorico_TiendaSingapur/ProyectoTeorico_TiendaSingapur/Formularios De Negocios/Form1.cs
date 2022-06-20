using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Articulo;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Cliente;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Colores;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Facturacion;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad_y_Sucursal;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Marca;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Proveedor;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.TipoArticulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeorico_TiendaSingapur
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado ventana = new frmAltaEmpleado();
            ventana.ShowDialog();
            ventana.Dispose();    
        }

        private void altaColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltasColores ventana = new frmAltasColores();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCyBEmpleado ventana = new frmCyBEmpleado();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaColores ventana = new frmConsultaColores();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void altaArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaArticulos ventana = new frmAltaArticulos();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosTipoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoArticulo ventana = new frmTipoArticulo();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBYCArticulos ventana = new frmBYCArticulos();
            ventana.ShowDialog();
            ventana.Dispose(); 
        }

        private void altaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaSucursal ventana = new frmAltaSucursal();
            ventana.ShowDialog();
            ventana.Dispose();

        }

        private void altaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaLocalidad ventana = new frmAltaLocalidad();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosLocalidadtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCyBLocalidad ventana = new frmCyBLocalidad();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosSucursaltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCyBSucursal ventana = new frmCyBSucursal();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCliente ventana = new frmAltaCliente();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarca ventana = new frmAltaMarca();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void altaTipoPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaTipoArticulo ventana = new frmAltaTipoArticulo();
            ventana.ShowDialog();
            ventana.Dispose();


        }

        private void altaBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaBarrio ventana = new frmAltaBarrio();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajaYMod ventana = new frmBajaYMod();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCyBProveedor ventana = new frmCyBProveedor();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMarca ventana = new frmConsultaMarca();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void datosBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaProveedor ventana = new frmAltaProveedor();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion ventana = new frmFacturacion();
            ventana.ShowDialog();
            ventana.Dispose();
        }
    }
}
