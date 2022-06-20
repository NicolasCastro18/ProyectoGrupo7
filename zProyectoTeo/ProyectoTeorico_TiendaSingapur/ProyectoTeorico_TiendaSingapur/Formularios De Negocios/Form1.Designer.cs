namespace ProyectoTeorico_TiendaSingapur
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTipoPrendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaLocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosTipoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosLocalidadtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosSucursaltoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosBarriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.facturarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(162, 485);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.altaEmpleadoToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.altaColorToolStripMenuItem,
            this.altaTipoPrendaToolStripMenuItem,
            this.altaArticuloToolStripMenuItem,
            this.altaBarrioToolStripMenuItem,
            this.altaLocalidadToolStripMenuItem,
            this.altaSucursalToolStripMenuItem,
            this.altaProveedorToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaClienteToolStripMenuItem.Text = "Alta Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaEmpleadoToolStripMenuItem.Text = "Alta Empleado";
            this.altaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaEmpleadoToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaToolStripMenuItem.Text = "Alta Marca";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // altaColorToolStripMenuItem
            // 
            this.altaColorToolStripMenuItem.Name = "altaColorToolStripMenuItem";
            this.altaColorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaColorToolStripMenuItem.Text = "Alta Color";
            this.altaColorToolStripMenuItem.Click += new System.EventHandler(this.altaColorToolStripMenuItem_Click);
            // 
            // altaTipoPrendaToolStripMenuItem
            // 
            this.altaTipoPrendaToolStripMenuItem.Name = "altaTipoPrendaToolStripMenuItem";
            this.altaTipoPrendaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaTipoPrendaToolStripMenuItem.Text = "Alta TipoArticulo";
            this.altaTipoPrendaToolStripMenuItem.Click += new System.EventHandler(this.altaTipoPrendaToolStripMenuItem_Click);
            // 
            // altaArticuloToolStripMenuItem
            // 
            this.altaArticuloToolStripMenuItem.Name = "altaArticuloToolStripMenuItem";
            this.altaArticuloToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaArticuloToolStripMenuItem.Text = "Alta Articulo";
            this.altaArticuloToolStripMenuItem.Click += new System.EventHandler(this.altaArticuloToolStripMenuItem_Click);
            // 
            // altaBarrioToolStripMenuItem
            // 
            this.altaBarrioToolStripMenuItem.Name = "altaBarrioToolStripMenuItem";
            this.altaBarrioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaBarrioToolStripMenuItem.Text = "Alta Barrio";
            this.altaBarrioToolStripMenuItem.Click += new System.EventHandler(this.altaBarrioToolStripMenuItem_Click);
            // 
            // altaLocalidadToolStripMenuItem
            // 
            this.altaLocalidadToolStripMenuItem.Name = "altaLocalidadToolStripMenuItem";
            this.altaLocalidadToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaLocalidadToolStripMenuItem.Text = "Alta Localidad";
            this.altaLocalidadToolStripMenuItem.Click += new System.EventHandler(this.altaLocalidadToolStripMenuItem_Click);
            // 
            // altaSucursalToolStripMenuItem
            // 
            this.altaSucursalToolStripMenuItem.Name = "altaSucursalToolStripMenuItem";
            this.altaSucursalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaSucursalToolStripMenuItem.Text = "Alta Sucursal";
            this.altaSucursalToolStripMenuItem.Click += new System.EventHandler(this.altaSucursalToolStripMenuItem_Click);
            // 
            // altaProveedorToolStripMenuItem
            // 
            this.altaProveedorToolStripMenuItem.Name = "altaProveedorToolStripMenuItem";
            this.altaProveedorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaProveedorToolStripMenuItem.Text = "Alta Proveedor";
            this.altaProveedorToolStripMenuItem.Click += new System.EventHandler(this.altaProveedorToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosClienteToolStripMenuItem,
            this.datosEmpleadosToolStripMenuItem,
            this.datosProveedoresToolStripMenuItem,
            this.datosTipoArticuloToolStripMenuItem,
            this.datosColoresToolStripMenuItem,
            this.datosMarcaToolStripMenuItem,
            this.datosArticulosToolStripMenuItem,
            this.datosLocalidadtoolStripMenuItem1,
            this.datosSucursaltoolStripMenuItem2,
            this.datosBarriosToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.consultaToolStripMenuItem.Text = "Consulta y Eliminacion";
            // 
            // datosClienteToolStripMenuItem
            // 
            this.datosClienteToolStripMenuItem.Name = "datosClienteToolStripMenuItem";
            this.datosClienteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosClienteToolStripMenuItem.Text = "Datos Cliente";
            this.datosClienteToolStripMenuItem.Click += new System.EventHandler(this.datosClienteToolStripMenuItem_Click);
            // 
            // datosEmpleadosToolStripMenuItem
            // 
            this.datosEmpleadosToolStripMenuItem.Name = "datosEmpleadosToolStripMenuItem";
            this.datosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosEmpleadosToolStripMenuItem.Text = "Datos Empleados";
            this.datosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.datosEmpleadosToolStripMenuItem_Click);
            // 
            // datosProveedoresToolStripMenuItem
            // 
            this.datosProveedoresToolStripMenuItem.Name = "datosProveedoresToolStripMenuItem";
            this.datosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosProveedoresToolStripMenuItem.Text = "Datos Proveedores";
            this.datosProveedoresToolStripMenuItem.Click += new System.EventHandler(this.datosProveedoresToolStripMenuItem_Click);
            // 
            // datosTipoArticuloToolStripMenuItem
            // 
            this.datosTipoArticuloToolStripMenuItem.Name = "datosTipoArticuloToolStripMenuItem";
            this.datosTipoArticuloToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosTipoArticuloToolStripMenuItem.Text = "Datos TipoArticulo";
            this.datosTipoArticuloToolStripMenuItem.Click += new System.EventHandler(this.datosTipoArticuloToolStripMenuItem_Click);
            // 
            // datosColoresToolStripMenuItem
            // 
            this.datosColoresToolStripMenuItem.Name = "datosColoresToolStripMenuItem";
            this.datosColoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosColoresToolStripMenuItem.Text = "Datos Colores";
            this.datosColoresToolStripMenuItem.Click += new System.EventHandler(this.datosColoresToolStripMenuItem_Click);
            // 
            // datosMarcaToolStripMenuItem
            // 
            this.datosMarcaToolStripMenuItem.Name = "datosMarcaToolStripMenuItem";
            this.datosMarcaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosMarcaToolStripMenuItem.Text = "Datos Marcas";
            this.datosMarcaToolStripMenuItem.Click += new System.EventHandler(this.datosMarcaToolStripMenuItem_Click);
            // 
            // datosArticulosToolStripMenuItem
            // 
            this.datosArticulosToolStripMenuItem.Name = "datosArticulosToolStripMenuItem";
            this.datosArticulosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosArticulosToolStripMenuItem.Text = "Datos Articulos";
            this.datosArticulosToolStripMenuItem.Click += new System.EventHandler(this.datosArticulosToolStripMenuItem_Click);
            // 
            // datosLocalidadtoolStripMenuItem1
            // 
            this.datosLocalidadtoolStripMenuItem1.Name = "datosLocalidadtoolStripMenuItem1";
            this.datosLocalidadtoolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.datosLocalidadtoolStripMenuItem1.Text = "Datos Localidad";
            this.datosLocalidadtoolStripMenuItem1.Click += new System.EventHandler(this.datosLocalidadtoolStripMenuItem1_Click);
            // 
            // datosSucursaltoolStripMenuItem2
            // 
            this.datosSucursaltoolStripMenuItem2.Name = "datosSucursaltoolStripMenuItem2";
            this.datosSucursaltoolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.datosSucursaltoolStripMenuItem2.Text = "Datos Sucursal";
            this.datosSucursaltoolStripMenuItem2.Click += new System.EventHandler(this.datosSucursaltoolStripMenuItem2_Click);
            // 
            // datosBarriosToolStripMenuItem
            // 
            this.datosBarriosToolStripMenuItem.Name = "datosBarriosToolStripMenuItem";
            this.datosBarriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.datosBarriosToolStripMenuItem.Text = "Datos Barrios";
            this.datosBarriosToolStripMenuItem.Click += new System.EventHandler(this.datosBarriosToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem,
            this.eliminarFacturaToolStripMenuItem});
            this.facturarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturarToolStripMenuItem.Image")));
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.facturarToolStripMenuItem.Text = "Facturar";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "Nueva Factura";
            this.nuevaFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFacturaToolStripMenuItem_Click);
            // 
            // eliminarFacturaToolStripMenuItem
            // 
            this.eliminarFacturaToolStripMenuItem.Name = "eliminarFacturaToolStripMenuItem";
            this.eliminarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarFacturaToolStripMenuItem.Text = "Eliminar Factura";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1069, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTipoPrendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaLocalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosTipoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosLocalidadtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosSucursaltoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem datosBarriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

