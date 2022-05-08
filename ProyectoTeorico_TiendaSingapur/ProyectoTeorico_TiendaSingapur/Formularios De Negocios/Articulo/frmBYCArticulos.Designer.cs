namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Articulo
{
    partial class frmBYCArticulos
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
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.gbFiltrosPrendas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboTemporada = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.comboTipoPrenda = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.gbFiltrosPrendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoPrenda,
            this.color,
            this.marca,
            this.stock,
            this.temporada,
            this.precio,
            this.proveedor,
            this.nombre});
            this.dgvArticulo.Location = new System.Drawing.Point(11, 184);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.Size = new System.Drawing.Size(841, 205);
            this.dgvArticulo.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(389, 422);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosPrendas
            // 
            this.gbFiltrosPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbFiltrosPrendas.Controls.Add(this.btnBuscar);
            this.gbFiltrosPrendas.Controls.Add(this.comboTemporada);
            this.gbFiltrosPrendas.Controls.Add(this.lblMarca);
            this.gbFiltrosPrendas.Controls.Add(this.lblTemporada);
            this.gbFiltrosPrendas.Controls.Add(this.comboMarca);
            this.gbFiltrosPrendas.Controls.Add(this.comboColor);
            this.gbFiltrosPrendas.Controls.Add(this.lblTipoPrenda);
            this.gbFiltrosPrendas.Controls.Add(this.comboTipoPrenda);
            this.gbFiltrosPrendas.Controls.Add(this.lblColor);
            this.gbFiltrosPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrosPrendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFiltrosPrendas.Location = new System.Drawing.Point(61, 12);
            this.gbFiltrosPrendas.Name = "gbFiltrosPrendas";
            this.gbFiltrosPrendas.Size = new System.Drawing.Size(644, 155);
            this.gbFiltrosPrendas.TabIndex = 16;
            this.gbFiltrosPrendas.TabStop = false;
            this.gbFiltrosPrendas.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.Consultar;
            this.btnBuscar.Location = new System.Drawing.Point(25, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 26);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboTemporada
            // 
            this.comboTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemporada.FormattingEnabled = true;
            this.comboTemporada.Location = new System.Drawing.Point(391, 69);
            this.comboTemporada.Name = "comboTemporada";
            this.comboTemporada.Size = new System.Drawing.Size(113, 25);
            this.comboTemporada.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(334, 34);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTemporada.Location = new System.Drawing.Point(300, 72);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(85, 17);
            this.lblTemporada.TabIndex = 6;
            this.lblTemporada.Text = "Temporada:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(391, 31);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(113, 25);
            this.comboMarca.TabIndex = 4;
            // 
            // comboColor
            // 
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(144, 69);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(113, 25);
            this.comboColor.TabIndex = 2;
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoPrenda.Location = new System.Drawing.Point(22, 31);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(110, 17);
            this.lblTipoPrenda.TabIndex = 1;
            this.lblTipoPrenda.Text = "Tipo de Prenda:";
            // 
            // comboTipoPrenda
            // 
            this.comboTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPrenda.FormattingEnabled = true;
            this.comboTipoPrenda.Location = new System.Drawing.Point(144, 31);
            this.comboTipoPrenda.Name = "comboTipoPrenda";
            this.comboTipoPrenda.Size = new System.Drawing.Size(113, 25);
            this.comboTipoPrenda.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColor.Location = new System.Drawing.Point(87, 72);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.EliminarPrenda;
            this.btnBorrar.Location = new System.Drawing.Point(12, 415);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(141, 30);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.salir__2_;
            this.btnCancelar.Location = new System.Drawing.Point(511, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 32);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.ModificarPrenda;
            this.btnModificar.Location = new System.Drawing.Point(632, 413);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 29);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // tipoPrenda
            // 
            this.tipoPrenda.DataPropertyName = "nombre";
            this.tipoPrenda.HeaderText = "TipoPrenda";
            this.tipoPrenda.Name = "tipoPrenda";
            // 
            // color
            // 
            this.color.DataPropertyName = "nombre";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "nombre";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // temporada
            // 
            this.temporada.DataPropertyName = "nombre";
            this.temporada.HeaderText = "Temporada";
            this.temporada.Name = "temporada";
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // proveedor
            // 
            this.proveedor.DataPropertyName = "nombre";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombreImagen";
            this.nombre.HeaderText = "Nombre Imagen";
            this.nombre.Name = "nombre";
            // 
            // frmBYCArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(864, 465);
            this.Controls.Add(this.gbFiltrosPrendas);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "frmBYCArticulos";
            this.Text = "frmBYCArticulos";
            this.Load += new System.EventHandler(this.frmBYCArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.gbFiltrosPrendas.ResumeLayout(false);
            this.gbFiltrosPrendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbFiltrosPrendas;
        private System.Windows.Forms.ComboBox comboTemporada;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.ComboBox comboTipoPrenda;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}