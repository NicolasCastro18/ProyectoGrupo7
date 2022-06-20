namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    partial class frmCyBSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCyBSucursal));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grillaSucursal = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(36, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 24);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(115, 46);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 20);
            this.txtBuscar.TabIndex = 13;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(33, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(233, 17);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Ingrese nombre de la sucursal:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.Consultar;
            this.btnBuscar.Location = new System.Drawing.Point(224, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 24);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grillaSucursal
            // 
            this.grillaSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.NombreArticulo});
            this.grillaSucursal.Location = new System.Drawing.Point(36, 131);
            this.grillaSucursal.Name = "grillaSucursal";
            this.grillaSucursal.Size = new System.Drawing.Size(288, 205);
            this.grillaSucursal.TabIndex = 10;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "id_sucursal";
            this.IdArticulo.HeaderText = "Id";
            this.IdArticulo.Name = "IdArticulo";
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "nombre";
            this.NombreArticulo.HeaderText = "Nombre";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.Width = 150;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(142, 79);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 35);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // frmCyBSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(362, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grillaSucursal);
            this.Name = "frmCyBSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCyBSucursal";
            this.Load += new System.EventHandler(this.frmCyBSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grillaSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
    }
}