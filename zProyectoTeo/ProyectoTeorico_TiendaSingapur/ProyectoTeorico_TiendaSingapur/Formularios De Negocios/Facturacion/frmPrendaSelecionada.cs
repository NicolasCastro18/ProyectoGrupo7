using ProyectoTeorico_TiendaSingapur.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Facturacion
{
    public partial class frmPrendaSelecionada : Form
    {
        public frmPrendaSelecionada()
        {
            InitializeComponent();
        }

        private void frmPrendaSelecionada_Load(object sender, EventArgs e)
        {
            CargarComboTipoPrenda();
        }
        private void CargarComboTipoPrenda()
        {
            comboTipoPrenda.DataSource = TipoPrenda.ObtenerTipoPrendas();
            comboTipoPrenda.DisplayMember = "nombre";
            comboTipoPrenda.ValueMember = "id_TipoPrenda";
            comboTipoPrenda.SelectedIndex = -1;
        }
    }
}
