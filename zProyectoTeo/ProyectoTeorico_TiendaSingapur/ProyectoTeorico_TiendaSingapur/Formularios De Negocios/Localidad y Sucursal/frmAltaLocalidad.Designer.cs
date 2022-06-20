namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    partial class frmAltaLocalidad
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
            this.lblAltaLocalidad = new System.Windows.Forms.Label();
            this.dgvAltaArticulo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProv = new System.Windows.Forms.Label();
            this.comboProvLocalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(317, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 45);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(66, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAltaLocalidad
            // 
            this.lblAltaLocalidad.AutoSize = true;
            this.lblAltaLocalidad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAltaLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaLocalidad.Location = new System.Drawing.Point(66, 98);
            this.lblAltaLocalidad.Name = "lblAltaLocalidad";
            this.lblAltaLocalidad.Size = new System.Drawing.Size(286, 17);
            this.lblAltaLocalidad.TabIndex = 6;
            this.lblAltaLocalidad.Text = "Ingrese nombre de la nueva localidad:";
            // 
            // dgvAltaArticulo
            // 
            this.dgvAltaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaArticulo.Location = new System.Drawing.Point(50, 63);
            this.dgvAltaArticulo.Name = "dgvAltaArticulo";
            this.dgvAltaArticulo.Size = new System.Drawing.Size(315, 143);
            this.dgvAltaArticulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nueva Localidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(50, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(66, 175);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(64, 13);
            this.lblProv.TabIndex = 12;
            this.lblProv.Text = "Provincia:";
            // 
            // comboProvLocalidad
            // 
            this.comboProvLocalidad.FormattingEnabled = true;
            this.comboProvLocalidad.Location = new System.Drawing.Point(136, 172);
            this.comboProvLocalidad.Name = "comboProvLocalidad";
            this.comboProvLocalidad.Size = new System.Drawing.Size(216, 21);
            this.comboProvLocalidad.TabIndex = 13;
            // 
            // frmAltaLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(406, 277);
            this.Controls.Add(this.comboProvLocalidad);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaLocalidad);
            this.Controls.Add(this.dgvAltaArticulo);
            this.Name = "frmAltaLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaLocalidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAltaLocalidad;
        private System.Windows.Forms.DataGridView dgvAltaArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.ComboBox comboProvLocalidad;
    }
}