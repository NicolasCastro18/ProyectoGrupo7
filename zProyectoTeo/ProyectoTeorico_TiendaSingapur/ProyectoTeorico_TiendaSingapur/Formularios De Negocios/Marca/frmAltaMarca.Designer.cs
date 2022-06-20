
namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Marca
{
    partial class frmAltaMarca
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAltaLocalidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAgregar.Location = new System.Drawing.Point(254, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 33);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(102, 144);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(213, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nuevo Marca";
            // 
            // lblAltaLocalidad
            // 
            this.lblAltaLocalidad.AutoSize = true;
            this.lblAltaLocalidad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAltaLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaLocalidad.Location = new System.Drawing.Point(29, 101);
            this.lblAltaLocalidad.Name = "lblAltaLocalidad";
            this.lblAltaLocalidad.Size = new System.Drawing.Size(286, 17);
            this.lblAltaLocalidad.TabIndex = 8;
            this.lblAltaLocalidad.Text = "Ingrese nombre de la nueva localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(32, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(332, 265);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAltaLocalidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAltaMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAltaLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}