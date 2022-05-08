using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Articulo;
using ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Colores;
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

        }

        private void datosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBYCArticulos ventana = new frmBYCArticulos();
            ventana.ShowDialog();
            ventana.Dispose(); 
        }
    }
}
