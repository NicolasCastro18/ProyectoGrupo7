using ProyectoTeorico_TiendaSingapur.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Facturacion
{
    public partial class frmFacturacion : Form
    {
        AD_Clientes oCliente = new AD_Clientes();

        bool primeraCarga = false; 

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
            CargarComboFacturas();

            txtNroFactura.Enabled = true;
            txtDireccion.Enabled = true;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            btnCancelar.Enabled = false;
            txtSubtotal.Text = (0).ToString("N2");
            txtDescuento.Text = (0).ToString("N2");
            txtNroFactura.Text = (AD_Factura.ObtenerUltimoIdFactura() + 1).ToString();
            dtpFecha.Value = DateTime.Today;

            

        }
        private void CargarComboCliente()
        {
            comboCliente.DataSource = AD_Clientes.ObtenerClientes();
            comboCliente.DisplayMember = "nombre";
            comboCliente.ValueMember = "id_cliente";
            comboCliente.SelectedIndex = -1;
            primeraCarga = true;
        }
        private void CargarComboFacturas()
        {
            comboTipoFactura.DataSource = AD_TipoFactura.ObtenerTipoFacturas();
            comboTipoFactura.DisplayMember = "nombre";
            comboTipoFactura.ValueMember = "id_TipoFactura";
            comboTipoFactura.SelectedIndex = -1;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecPrenda_Click(object sender, EventArgs e)
        {
            frmPrendaSelecionada ventana = new frmPrendaSelecionada();
            ventana.ShowDialog();
            ventana.Dispose();

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
             
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos();
            if(comboCliente.SelectedIndex != 0)
            {
                if(comboCliente.SelectedIndex != 1)
                {
                    primeraCarga = true;
                }
               
            }
            
        }
        private void Datos()
        {
            if(primeraCarga == true)
            {
                txtDireccion.Text = AD_Clientes.ObtenerCalleClientesxId((int)comboCliente.SelectedValue);

                txtCuil.Text = AD_Clientes.ObtenerCuilCliente((int)comboCliente.SelectedValue);
            }
            else
            {
                txtDireccion.Text = "";
                txtCuil.Text = "";
            }
        }
    }
}

