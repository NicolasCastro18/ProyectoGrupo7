namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Facturacion
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.comboTipoFactura = new System.Windows.Forms.ComboBox();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this.btnSelecPrenda = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrendaSelected = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(644, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(697, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 23);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDireccion.Location = new System.Drawing.Point(369, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 23);
            this.txtDireccion.TabIndex = 20;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(285, 58);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNroFactura.Location = new System.Drawing.Point(285, 15);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(83, 17);
            this.lblNroFactura.TabIndex = 18;
            this.lblNroFactura.Text = "Nro Factura";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNroFactura.Location = new System.Drawing.Point(374, 12);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(126, 23);
            this.txtNroFactura.TabIndex = 17;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClientes.Location = new System.Drawing.Point(42, 55);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(51, 17);
            this.lblClientes.TabIndex = 16;
            this.lblClientes.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(101, 52);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(126, 25);
            this.comboCliente.TabIndex = 15;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoFactura.Location = new System.Drawing.Point(5, 15);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(88, 17);
            this.lblTipoFactura.TabIndex = 14;
            this.lblTipoFactura.Text = "Tipo Factura";
            // 
            // comboTipoFactura
            // 
            this.comboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboTipoFactura.FormattingEnabled = true;
            this.comboTipoFactura.Location = new System.Drawing.Point(101, 12);
            this.comboTipoFactura.Name = "comboTipoFactura";
            this.comboTipoFactura.Size = new System.Drawing.Size(126, 25);
            this.comboTipoFactura.TabIndex = 13;
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.Controls.Add(this.btnSelecPrenda);
            this.dpbDetalle.Controls.Add(this.btnQuitar);
            this.dpbDetalle.Controls.Add(this.btnCancelar);
            this.dpbDetalle.Controls.Add(this.btnAgregar);
            this.dpbDetalle.Controls.Add(this.txtPrendaSelected);
            this.dpbDetalle.Controls.Add(this.nudCantidad);
            this.dpbDetalle.Controls.Add(this.txtImporteTotal);
            this.dpbDetalle.Controls.Add(this.txtDescuento);
            this.dpbDetalle.Controls.Add(this.txtSubtotal);
            this.dpbDetalle.Controls.Add(this.lblImporteTotal);
            this.dpbDetalle.Controls.Add(this.lblDescuento);
            this.dpbDetalle.Controls.Add(this.lblSubtotal);
            this.dpbDetalle.Controls.Add(this.txtImporte);
            this.dpbDetalle.Controls.Add(this.lblImporte);
            this.dpbDetalle.Controls.Add(this.dgvDetalleFactura);
            this.dpbDetalle.Controls.Add(this.txtPrecio);
            this.dpbDetalle.Controls.Add(this.lblPrecio);
            this.dpbDetalle.Controls.Add(this._lblCantidad);
            this.dpbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpbDetalle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dpbDetalle.Location = new System.Drawing.Point(12, 83);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Size = new System.Drawing.Size(797, 362);
            this.dpbDetalle.TabIndex = 25;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // btnSelecPrenda
            // 
            this.btnSelecPrenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelecPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecPrenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelecPrenda.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecPrenda.Image")));
            this.btnSelecPrenda.Location = new System.Drawing.Point(13, 23);
            this.btnSelecPrenda.Name = "btnSelecPrenda";
            this.btnSelecPrenda.Size = new System.Drawing.Size(178, 31);
            this.btnSelecPrenda.TabIndex = 35;
            this.btnSelecPrenda.UseVisualStyleBackColor = true;
            this.btnSelecPrenda.Click += new System.EventHandler(this.btnSelecPrenda_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(628, 23);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(61, 54);
            this.btnQuitar.TabIndex = 34;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(694, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 57);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = " ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Location = new System.Drawing.Point(568, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 54);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrendaSelected
            // 
            this.txtPrendaSelected.Enabled = false;
            this.txtPrendaSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPrendaSelected.Location = new System.Drawing.Point(13, 60);
            this.txtPrendaSelected.Name = "txtPrendaSelected";
            this.txtPrendaSelected.Size = new System.Drawing.Size(244, 23);
            this.txtPrendaSelected.TabIndex = 17;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Location = new System.Drawing.Point(357, 23);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(64, 23);
            this.nudCantidad.TabIndex = 31;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(683, 324);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 23);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(462, 324);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(225, 324);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(586, 327);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(91, 17);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(354, 327);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(102, 17);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento (%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(159, 327);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 17);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(498, 23);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(64, 23);
            this.txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(437, 25);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(55, 17);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(13, 92);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(770, 221);
            this.dgvDetalleFactura.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(357, 59);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(64, 23);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(303, 62);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // _lblCantidad
            // 
            this._lblCantidad.AutoSize = true;
            this._lblCantidad.Location = new System.Drawing.Point(287, 25);
            this._lblCantidad.Name = "_lblCantidad";
            this._lblCantidad.Size = new System.Drawing.Size(64, 17);
            this._lblCantidad.TabIndex = 2;
            this._lblCantidad.Text = "Cantidad";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalir.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.salir__2_;
            this.btnSalir.Location = new System.Drawing.Point(715, 464);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 31);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGrabar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.GuardarIcon_;
            this.btnGrabar.Location = new System.Drawing.Point(109, 464);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 31);
            this.btnGrabar.TabIndex = 27;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(16, 464);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 28);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(663, 57);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(142, 20);
            this.txtCuil.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(616, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cuil";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(824, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.comboTipoFactura);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmFacturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox comboTipoFactura;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.Button btnSelecPrenda;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrendaSelected;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label _lblCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label2;
    }
}