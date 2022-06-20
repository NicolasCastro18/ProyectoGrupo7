namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Facturacion
{
    partial class frmPrendaSelecionada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrendaSelecionada));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.comboTipoPrenda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAceptar.Location = new System.Drawing.Point(262, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.Consultar;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBuscar.Location = new System.Drawing.Point(262, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvPrendas
            // 
            this.dgvPrendas.AllowUserToAddRows = false;
            this.dgvPrendas.AllowUserToDeleteRows = false;
            this.dgvPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendas.Location = new System.Drawing.Point(12, 47);
            this.dgvPrendas.Name = "dgvPrendas";
            this.dgvPrendas.ReadOnly = true;
            this.dgvPrendas.RowHeadersWidth = 51;
            this.dgvPrendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendas.Size = new System.Drawing.Size(348, 360);
            this.dgvPrendas.TabIndex = 7;
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTipoPrenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoPrenda.Location = new System.Drawing.Point(9, 12);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(106, 17);
            this.lblTipoPrenda.TabIndex = 6;
            this.lblTipoPrenda.Text = "Tipo de Prenda";
            // 
            // comboTipoPrenda
            // 
            this.comboTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboTipoPrenda.FormattingEnabled = true;
            this.comboTipoPrenda.Location = new System.Drawing.Point(121, 9);
            this.comboTipoPrenda.Name = "comboTipoPrenda";
            this.comboTipoPrenda.Size = new System.Drawing.Size(131, 25);
            this.comboTipoPrenda.TabIndex = 5;
            // 
            // frmPrendaSelecionada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 466);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPrendas);
            this.Controls.Add(this.lblTipoPrenda);
            this.Controls.Add(this.comboTipoPrenda);
            this.Name = "frmPrendaSelecionada";
            this.Text = "frmPrendaSelecionada";
            this.Load += new System.EventHandler(this.frmPrendaSelecionada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPrendas;
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.ComboBox comboTipoPrenda;
    }
}