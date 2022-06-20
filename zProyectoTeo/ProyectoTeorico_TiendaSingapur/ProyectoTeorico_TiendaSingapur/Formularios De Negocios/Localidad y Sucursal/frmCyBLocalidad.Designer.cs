namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Localidad
{
    partial class frmCyBLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCyBLocalidad));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grillaLocalidad = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(36, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 24);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(99, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(33, 25);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(219, 17);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Ingrese nombre de localidad:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.Consultar;
            this.btnBuscar.Location = new System.Drawing.Point(221, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grillaLocalidad
            // 
            this.grillaLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.NombreArticulo});
            this.grillaLocalidad.Location = new System.Drawing.Point(36, 147);
            this.grillaLocalidad.Name = "grillaLocalidad";
            this.grillaLocalidad.Size = new System.Drawing.Size(288, 205);
            this.grillaLocalidad.TabIndex = 5;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "id_localidad";
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
            this.btnBorrar.Location = new System.Drawing.Point(139, 100);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(76, 30);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // frmCyBLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(355, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grillaLocalidad);
            this.Name = "frmCyBLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCyBLocalidad";
            this.Load += new System.EventHandler(this.frmCyBLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grillaLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
    }
}