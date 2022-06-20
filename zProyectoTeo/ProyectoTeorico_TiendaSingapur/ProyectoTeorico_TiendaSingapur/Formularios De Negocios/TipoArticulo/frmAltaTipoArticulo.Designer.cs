namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.TipoArticulo
{
    partial class frmAltaTipoArticulo
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
            this.dgvAltaArticulo = new System.Windows.Forms.DataGridView();
            this.lblAltaAticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAltaArticulo
            // 
            this.dgvAltaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaArticulo.Location = new System.Drawing.Point(19, 73);
            this.dgvAltaArticulo.Name = "dgvAltaArticulo";
            this.dgvAltaArticulo.Size = new System.Drawing.Size(336, 101);
            this.dgvAltaArticulo.TabIndex = 0;
            // 
            // lblAltaAticulo
            // 
            this.lblAltaAticulo.AutoSize = true;
            this.lblAltaAticulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAltaAticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaAticulo.Location = new System.Drawing.Point(39, 94);
            this.lblAltaAticulo.Name = "lblAltaAticulo";
            this.lblAltaAticulo.Size = new System.Drawing.Size(316, 17);
            this.lblAltaAticulo.TabIndex = 1;
            this.lblAltaAticulo.Text = "Ingrese nombre del nuevo tipo de articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Location = new System.Drawing.Point(292, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nuevo Tipo Articulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(32, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaTipoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 227);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAltaAticulo);
            this.Controls.Add(this.dgvAltaArticulo);
            this.Name = "frmAltaTipoArticulo";
            this.Text = "Alta Tipo Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAltaArticulo;
        private System.Windows.Forms.Label lblAltaAticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}