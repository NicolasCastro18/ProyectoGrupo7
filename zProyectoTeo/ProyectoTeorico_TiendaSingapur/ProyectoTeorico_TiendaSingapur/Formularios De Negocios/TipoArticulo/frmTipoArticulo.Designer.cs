namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.TipoArticulo
{
    partial class frmTipoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoArticulo));
            this.grillaTipoArticulo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaTipoArticulo
            // 
            this.grillaTipoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NombreArticulo});
            this.grillaTipoArticulo.Location = new System.Drawing.Point(24, 116);
            this.grillaTipoArticulo.Name = "grillaTipoArticulo";
            this.grillaTipoArticulo.Size = new System.Drawing.Size(288, 201);
            this.grillaTipoArticulo.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.Consultar;
            this.btnBuscar.Location = new System.Drawing.Point(228, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 24);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(198, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(24, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 24);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(133, 62);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 32);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Color";
            // 
            // id
            // 
            this.id.DataPropertyName = "id_TipoPrenda";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "nombre";
            this.NombreArticulo.HeaderText = "Nombre";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.Width = 150;
            // 
            // frmTipoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(344, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grillaTipoArticulo);
            this.Name = "frmTipoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoArticulo";
            this.Load += new System.EventHandler(this.frmTipoArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaTipoArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
    }
}