namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad_y_Sucursal
{
    partial class frmAltaBarrio
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAltaLocalidad = new System.Windows.Forms.Label();
            this.dgvAltaArticulo = new System.Windows.Forms.DataGridView();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.comboLocBarrio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(33, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.ForeColor = System.Drawing.Color.Cyan;
            this.lblBarrio.Location = new System.Drawing.Point(107, 29);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(160, 25);
            this.lblBarrio.TabIndex = 17;
            this.lblBarrio.Text = "Nuevo Barrio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(270, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 45);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 139);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAltaLocalidad
            // 
            this.lblAltaLocalidad.AutoSize = true;
            this.lblAltaLocalidad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAltaLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaLocalidad.Location = new System.Drawing.Point(49, 102);
            this.lblAltaLocalidad.Name = "lblAltaLocalidad";
            this.lblAltaLocalidad.Size = new System.Drawing.Size(250, 17);
            this.lblAltaLocalidad.TabIndex = 13;
            this.lblAltaLocalidad.Text = "Ingrese nombre del nuevo barrio:";
            // 
            // dgvAltaArticulo
            // 
            this.dgvAltaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaArticulo.Location = new System.Drawing.Point(33, 80);
            this.dgvAltaArticulo.Name = "dgvAltaArticulo";
            this.dgvAltaArticulo.Size = new System.Drawing.Size(285, 142);
            this.dgvAltaArticulo.TabIndex = 12;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(49, 179);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(66, 13);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // comboLocBarrio
            // 
            this.comboLocBarrio.FormattingEnabled = true;
            this.comboLocBarrio.Location = new System.Drawing.Point(122, 171);
            this.comboLocBarrio.Name = "comboLocBarrio";
            this.comboLocBarrio.Size = new System.Drawing.Size(177, 21);
            this.comboLocBarrio.TabIndex = 20;
            // 
            // frmAltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 295);
            this.Controls.Add(this.comboLocBarrio);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaLocalidad);
            this.Controls.Add(this.dgvAltaArticulo);
            this.Name = "frmAltaBarrio";
            this.Text = "frmAltaBarrio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAltaLocalidad;
        private System.Windows.Forms.DataGridView dgvAltaArticulo;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox comboLocBarrio;
    }
}