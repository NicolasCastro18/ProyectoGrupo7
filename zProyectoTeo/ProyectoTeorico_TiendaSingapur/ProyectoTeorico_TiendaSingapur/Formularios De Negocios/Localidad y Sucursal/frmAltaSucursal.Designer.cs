namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    partial class frmAltaSucursal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAltaSucursal = new System.Windows.Forms.Label();
            this.dgvAltaArticulo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Location = new System.Drawing.Point(300, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 33);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAltaSucursal
            // 
            this.lblAltaSucursal.AutoSize = true;
            this.lblAltaSucursal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAltaSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaSucursal.Location = new System.Drawing.Point(57, 84);
            this.lblAltaSucursal.Name = "lblAltaSucursal";
            this.lblAltaSucursal.Size = new System.Drawing.Size(282, 17);
            this.lblAltaSucursal.TabIndex = 11;
            this.lblAltaSucursal.Text = "Ingrese nombre de la nueva sucursal:";
            // 
            // dgvAltaArticulo
            // 
            this.dgvAltaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaArticulo.Location = new System.Drawing.Point(38, 67);
            this.dgvAltaArticulo.Name = "dgvAltaArticulo";
            this.dgvAltaArticulo.Size = new System.Drawing.Size(316, 92);
            this.dgvAltaArticulo.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(38, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(102, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nueva Sucursal";
            // 
            // frmAltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaSucursal);
            this.Controls.Add(this.dgvAltaArticulo);
            this.Name = "frmAltaSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Sucursal";
            this.Load += new System.EventHandler(this.frmAltaSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAltaSucursal;
        private System.Windows.Forms.DataGridView dgvAltaArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}