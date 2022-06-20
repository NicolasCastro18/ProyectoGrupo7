
namespace ProyectoTeorico_TiendaSingapur.Formularios_De_Negocios.Proveedor
{
    partial class frmAltaProveedor
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
            this.groupBoxAltaProveedor = new System.Windows.Forms.GroupBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtAlturaProveedor = new System.Windows.Forms.TextBox();
            this.txtCalleProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtMailProveedor = new System.Windows.Forms.TextBox();
            this.txtApellidoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellidoProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.groupBoxAltaProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAltaProveedor
            // 
            this.groupBoxAltaProveedor.Controls.Add(this.cboBarrio);
            this.groupBoxAltaProveedor.Controls.Add(this.label1);
            this.groupBoxAltaProveedor.Controls.Add(this.btnCancelar);
            this.groupBoxAltaProveedor.Controls.Add(this.btnLimpiar);
            this.groupBoxAltaProveedor.Controls.Add(this.btnAlta);
            this.groupBoxAltaProveedor.Controls.Add(this.txtAlturaProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.txtCalleProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.txtTelefonoProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.txtMailProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.txtApellidoProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.txtNombreProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.lblNumeroCalle);
            this.groupBoxAltaProveedor.Controls.Add(this.lblCalle);
            this.groupBoxAltaProveedor.Controls.Add(this.lblTelefono);
            this.groupBoxAltaProveedor.Controls.Add(this.label2);
            this.groupBoxAltaProveedor.Controls.Add(this.lblMail);
            this.groupBoxAltaProveedor.Controls.Add(this.lblApellidoProveedor);
            this.groupBoxAltaProveedor.Controls.Add(this.lblNombreProveedor);
            this.groupBoxAltaProveedor.Location = new System.Drawing.Point(30, 12);
            this.groupBoxAltaProveedor.Name = "groupBoxAltaProveedor";
            this.groupBoxAltaProveedor.Size = new System.Drawing.Size(349, 425);
            this.groupBoxAltaProveedor.TabIndex = 0;
            this.groupBoxAltaProveedor.TabStop = false;
            this.groupBoxAltaProveedor.Text = "Datos Proveedor";
            this.groupBoxAltaProveedor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(93, 280);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(229, 21);
            this.cboBarrio.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "campos con \"*\" son obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.CancelarIcon;
            this.btnCancelar.Location = new System.Drawing.Point(178, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 379);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 26);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Image = global::ProyectoTeorico_TiendaSingapur.Properties.Resources.AgregarIcon;
            this.btnAlta.Location = new System.Drawing.Point(286, 371);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(57, 43);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtAlturaProveedor
            // 
            this.txtAlturaProveedor.Location = new System.Drawing.Point(93, 232);
            this.txtAlturaProveedor.Name = "txtAlturaProveedor";
            this.txtAlturaProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtAlturaProveedor.TabIndex = 12;
            // 
            // txtCalleProveedor
            // 
            this.txtCalleProveedor.Location = new System.Drawing.Point(93, 190);
            this.txtCalleProveedor.Name = "txtCalleProveedor";
            this.txtCalleProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtCalleProveedor.TabIndex = 11;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(93, 152);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtTelefonoProveedor.TabIndex = 10;
            // 
            // txtMailProveedor
            // 
            this.txtMailProveedor.Location = new System.Drawing.Point(93, 111);
            this.txtMailProveedor.Name = "txtMailProveedor";
            this.txtMailProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtMailProveedor.TabIndex = 9;
            // 
            // txtApellidoProveedor
            // 
            this.txtApellidoProveedor.Location = new System.Drawing.Point(93, 72);
            this.txtApellidoProveedor.Name = "txtApellidoProveedor";
            this.txtApellidoProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtApellidoProveedor.TabIndex = 8;
            this.txtApellidoProveedor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(93, 31);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtNombreProveedor.TabIndex = 7;
            this.txtNombreProveedor.TextChanged += new System.EventHandler(this.txtNombreProveedor_TextChanged);
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(26, 239);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(34, 13);
            this.lblNumeroCalle.TabIndex = 6;
            this.lblNumeroCalle.Text = "Altura";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(26, 197);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 5;
            this.lblCalle.Text = "Calle";
            this.lblCalle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(26, 159);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barrio";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(26, 118);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-mail(*)";
            // 
            // lblApellidoProveedor
            // 
            this.lblApellidoProveedor.AutoSize = true;
            this.lblApellidoProveedor.Location = new System.Drawing.Point(26, 79);
            this.lblApellidoProveedor.Name = "lblApellidoProveedor";
            this.lblApellidoProveedor.Size = new System.Drawing.Size(54, 13);
            this.lblApellidoProveedor.TabIndex = 1;
            this.lblApellidoProveedor.Text = "Apellido(*)";
            this.lblApellidoProveedor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(26, 38);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(54, 13);
            this.lblNombreProveedor.TabIndex = 0;
            this.lblNombreProveedor.Text = "Nombre(*)";
            this.lblNombreProveedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.groupBoxAltaProveedor);
            this.Name = "frmAltaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Proveedor";
            this.Load += new System.EventHandler(this.frmAltaProveedor_Load);
            this.groupBoxAltaProveedor.ResumeLayout(false);
            this.groupBoxAltaProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAltaProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblApellidoProveedor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtAlturaProveedor;
        private System.Windows.Forms.TextBox txtCalleProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtMailProveedor;
        private System.Windows.Forms.TextBox txtApellidoProveedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBarrio;
    }
}