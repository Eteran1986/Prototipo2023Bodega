namespace Capa_Presentacion
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónProductoToolStripMenuItem,
            this.gestiónProveedoresToolStripMenuItem,
            this.gestiónClientesToolStripMenuItem,
            this.gestiónComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónProductoToolStripMenuItem
            // 
            this.gestiónProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestiónProductoToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.gestion_de_productos;
            this.gestiónProductoToolStripMenuItem.Name = "gestiónProductoToolStripMenuItem";
            this.gestiónProductoToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.gestiónProductoToolStripMenuItem.Text = "Gestión Producto";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.productos;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gestiónProveedoresToolStripMenuItem
            // 
            this.gestiónProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gestiónProveedoresToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.proveedores;
            this.gestiónProveedoresToolStripMenuItem.Name = "gestiónProveedoresToolStripMenuItem";
            this.gestiónProveedoresToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.gestiónProveedoresToolStripMenuItem.Text = "Gestión Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.proveedor;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // gestiónClientesToolStripMenuItem
            // 
            this.gestiónClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.gestiónClientesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.atencion_al_cliente;
            this.gestiónClientesToolStripMenuItem.Name = "gestiónClientesToolStripMenuItem";
            this.gestiónClientesToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.gestiónClientesToolStripMenuItem.Text = "Gestión Clientes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // gestiónComprasToolStripMenuItem
            // 
            this.gestiónComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.gestiónComprasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.Compras;
            this.gestiónComprasToolStripMenuItem.Name = "gestiónComprasToolStripMenuItem";
            this.gestiónComprasToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.gestiónComprasToolStripMenuItem.Text = "Gestión Compras";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.smartphone;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.inventario;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = global::Capa_Presentacion.Properties.Resources.inventario__1_;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(154, 30);
            this.inventarioToolStripMenuItem1.Text = "Inventarios";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.ventas;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.configuracion;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.empresa;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto Prototipo de Bodega";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(795, 387);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(173, 44);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "10:20:15";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.Location = new System.Drawing.Point(803, 425);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(144, 16);
            this.lbldia.TabIndex = 3;
            this.lbldia.Text = "03 de noviembre de 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.LOGO_WEB_AZUL1;
            this.pictureBox1.Location = new System.Drawing.Point(240, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Ventas - ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    }
}

