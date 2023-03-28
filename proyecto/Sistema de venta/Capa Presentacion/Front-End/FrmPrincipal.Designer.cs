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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LUsuario = new System.Windows.Forms.Label();
            this.PUsuario = new System.Windows.Forms.Panel();
            this.LbPrototipo = new System.Windows.Forms.Label();
            this.PProveedor = new System.Windows.Forms.Panel();
            this.PProductos = new System.Windows.Forms.Panel();
            this.PCompras = new System.Windows.Forms.Panel();
            this.Pventas = new System.Windows.Forms.Panel();
            this.PReportes = new System.Windows.Forms.Panel();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.PDashboard = new System.Windows.Forms.Panel();
            this.Btusuario = new System.Windows.Forms.Button();
            this.IconoMenu = new System.Windows.Forms.PictureBox();
            this.Logounemi = new System.Windows.Forms.PictureBox();
            this.Botton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnCompras = new System.Windows.Forms.Button();
            this.gestiónProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PUsuario.SuspendLayout();
            this.PProveedor.SuspendLayout();
            this.PProductos.SuspendLayout();
            this.PCompras.SuspendLayout();
            this.Pventas.SuspendLayout();
            this.PReportes.SuspendLayout();
            this.PDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logounemi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(186)))), ((int)(((byte)(88)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónProductoToolStripMenuItem,
            this.gestiónProveedoresToolStripMenuItem,
            this.gestiónClientesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.gestiónComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(134)))), ((int)(((byte)(62)))));
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.PProveedor);
            this.MenuPanel.Controls.Add(this.PProductos);
            this.MenuPanel.Controls.Add(this.PCompras);
            this.MenuPanel.Controls.Add(this.Pventas);
            this.MenuPanel.Controls.Add(this.PReportes);
            this.MenuPanel.Controls.Add(this.PDashboard);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.MaximumSize = new System.Drawing.Size(203, 1067);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(63, 267);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(203, 613);
            this.MenuPanel.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LUsuario);
            this.panel2.Controls.Add(this.PUsuario);
            this.panel2.Controls.Add(this.IconoMenu);
            this.panel2.Controls.Add(this.Logounemi);
            this.panel2.Controls.Add(this.LbPrototipo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 143);
            this.panel2.TabIndex = 2;
            // 
            // LUsuario
            // 
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.White;
            this.LUsuario.Location = new System.Drawing.Point(37, 95);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(160, 32);
            this.LUsuario.TabIndex = 7;
            this.LUsuario.Text = "Usuario";
            this.LUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PUsuario
            // 
            this.PUsuario.Controls.Add(this.Btusuario);
            this.PUsuario.Location = new System.Drawing.Point(3, 90);
            this.PUsuario.Name = "PUsuario";
            this.PUsuario.Size = new System.Drawing.Size(60, 37);
            this.PUsuario.TabIndex = 6;
            // 
            // LbPrototipo
            // 
            this.LbPrototipo.AutoSize = true;
            this.LbPrototipo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrototipo.Location = new System.Drawing.Point(12, 66);
            this.LbPrototipo.Name = "LbPrototipo";
            this.LbPrototipo.Size = new System.Drawing.Size(178, 21);
            this.LbPrototipo.TabIndex = 4;
            this.LbPrototipo.Text = "Prototipo Bodega";
            // 
            // PProveedor
            // 
            this.PProveedor.Controls.Add(this.Botton);
            this.PProveedor.Location = new System.Drawing.Point(3, 152);
            this.PProveedor.Name = "PProveedor";
            this.PProveedor.Size = new System.Drawing.Size(194, 37);
            this.PProveedor.TabIndex = 3;
            // 
            // PProductos
            // 
            this.PProductos.Controls.Add(this.button6);
            this.PProductos.Location = new System.Drawing.Point(3, 195);
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(194, 37);
            this.PProductos.TabIndex = 13;
            // 
            // PCompras
            // 
            this.PCompras.Controls.Add(this.button7);
            this.PCompras.Location = new System.Drawing.Point(3, 238);
            this.PCompras.Name = "PCompras";
            this.PCompras.Size = new System.Drawing.Size(194, 37);
            this.PCompras.TabIndex = 14;
            // 
            // Pventas
            // 
            this.Pventas.Controls.Add(this.button9);
            this.Pventas.Location = new System.Drawing.Point(3, 281);
            this.Pventas.Name = "Pventas";
            this.Pventas.Size = new System.Drawing.Size(194, 37);
            this.Pventas.TabIndex = 15;
            // 
            // PReportes
            // 
            this.PReportes.Controls.Add(this.button8);
            this.PReportes.Location = new System.Drawing.Point(3, 324);
            this.PReportes.Name = "PReportes";
            this.PReportes.Size = new System.Drawing.Size(200, 37);
            this.PReportes.TabIndex = 16;
            // 
            // MenuTimer
            // 
            this.MenuTimer.Interval = 10;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // PDashboard
            // 
            this.PDashboard.Controls.Add(this.button1);
            this.PDashboard.Location = new System.Drawing.Point(3, 367);
            this.PDashboard.Name = "PDashboard";
            this.PDashboard.Size = new System.Drawing.Size(200, 37);
            this.PDashboard.TabIndex = 17;
            // 
            // Btusuario
            // 
            this.Btusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btusuario.Image = global::Capa_Presentacion.Properties.Resources.usuario;
            this.Btusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btusuario.Location = new System.Drawing.Point(-2, -11);
            this.Btusuario.Name = "Btusuario";
            this.Btusuario.Size = new System.Drawing.Size(73, 62);
            this.Btusuario.TabIndex = 11;
            this.Btusuario.Text = "                                                       ";
            this.Btusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btusuario.UseVisualStyleBackColor = true;
            // 
            // IconoMenu
            // 
            this.IconoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMenu.Image = global::Capa_Presentacion.Properties.Resources.barra_de_menus;
            this.IconoMenu.Location = new System.Drawing.Point(8, 13);
            this.IconoMenu.Name = "IconoMenu";
            this.IconoMenu.Size = new System.Drawing.Size(43, 43);
            this.IconoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconoMenu.TabIndex = 5;
            this.IconoMenu.TabStop = false;
            this.IconoMenu.Click += new System.EventHandler(this.IconoMenu_Click);
            // 
            // Logounemi
            // 
            this.Logounemi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logounemi.Image = global::Capa_Presentacion.Properties.Resources.LOGO_WEB_AZUL1;
            this.Logounemi.Location = new System.Drawing.Point(64, 13);
            this.Logounemi.Name = "Logounemi";
            this.Logounemi.Size = new System.Drawing.Size(127, 50);
            this.Logounemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logounemi.TabIndex = 4;
            this.Logounemi.TabStop = false;
            // 
            // Botton
            // 
            this.Botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Botton.Image = global::Capa_Presentacion.Properties.Resources.proveedor1;
            this.Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botton.Location = new System.Drawing.Point(-2, -11);
            this.Botton.Name = "Botton";
            this.Botton.Size = new System.Drawing.Size(223, 62);
            this.Botton.TabIndex = 11;
            this.Botton.Text = "                                                       Proveedor";
            this.Botton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Botton.UseVisualStyleBackColor = true;
            this.Botton.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::Capa_Presentacion.Properties.Resources.productos__1_1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, -11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 62);
            this.button6.TabIndex = 11;
            this.button6.Text = "                                                Productos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = global::Capa_Presentacion.Properties.Resources.compras1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-1, -11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 62);
            this.button7.TabIndex = 11;
            this.button7.Text = "                                                Compras";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = global::Capa_Presentacion.Properties.Resources.carrito_de_compras__1_;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-1, -11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 62);
            this.button9.TabIndex = 11;
            this.button9.Text = "                                                  Facturación";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Image = global::Capa_Presentacion.Properties.Resources.informe_de_negocio;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-1, -11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 62);
            this.button8.TabIndex = 11;
            this.button8.Text = "                                                Reportes";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Capa_Presentacion.Properties.Resources.tablero;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, -11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "                                                DashBoard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVentas.BackColor = System.Drawing.Color.Khaki;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.Black;
            this.BtnVentas.Image = global::Capa_Presentacion.Properties.Resources.ventas;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVentas.Location = new System.Drawing.Point(878, 3);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(160, 110);
            this.BtnVentas.TabIndex = 9;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Visible = false;
            this.BtnVentas.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDashboard.BackColor = System.Drawing.Color.Khaki;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Black;
            this.BtnDashboard.Image = global::Capa_Presentacion.Properties.Resources.presentacion;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDashboard.Location = new System.Drawing.Point(712, 3);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(160, 110);
            this.BtnDashboard.TabIndex = 8;
            this.BtnDashboard.Text = " Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Visible = false;
            this.BtnDashboard.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReportes.BackColor = System.Drawing.Color.Khaki;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.Black;
            this.BtnReportes.Image = global::Capa_Presentacion.Properties.Resources.informe_de_venta;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReportes.Location = new System.Drawing.Point(544, 3);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(160, 110);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = " Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Visible = false;
            this.BtnReportes.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnProductos.BackColor = System.Drawing.Color.Khaki;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.Black;
            this.BtnProductos.Image = global::Capa_Presentacion.Properties.Resources.productos;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProductos.Location = new System.Drawing.Point(376, 3);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(160, 110);
            this.BtnProductos.TabIndex = 6;
            this.BtnProductos.Text = " Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Visible = false;
            this.BtnProductos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCompras.BackColor = System.Drawing.Color.Khaki;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.Black;
            this.BtnCompras.Image = global::Capa_Presentacion.Properties.Resources.Compras;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCompras.Location = new System.Drawing.Point(209, 3);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Size = new System.Drawing.Size(160, 110);
            this.BtnCompras.TabIndex = 5;
            this.BtnCompras.Text = " Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCompras.UseVisualStyleBackColor = false;
            this.BtnCompras.Visible = false;
            this.BtnCompras.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // gestiónProductoToolStripMenuItem
            // 
            this.gestiónProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestiónProductoToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.gestion_de_productos;
            this.gestiónProductoToolStripMenuItem.Name = "gestiónProductoToolStripMenuItem";
            this.gestiónProductoToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.gestiónProductoToolStripMenuItem.Text = "Gestión Producto";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.productos;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gestiónProveedoresToolStripMenuItem
            // 
            this.gestiónProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gestiónProveedoresToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.proveedores;
            this.gestiónProveedoresToolStripMenuItem.Name = "gestiónProveedoresToolStripMenuItem";
            this.gestiónProveedoresToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.gestiónProveedoresToolStripMenuItem.Text = "Gestión Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.proveedor;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
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
            this.gestiónClientesToolStripMenuItem.Visible = false;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.ventasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.ventas;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.Facturación;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Image = global::Capa_Presentacion.Properties.Resources.ventas;
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(159, 30);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // gestiónComprasToolStripMenuItem
            // 
            this.gestiónComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.gestiónComprasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.Compras;
            this.gestiónComprasToolStripMenuItem.Name = "gestiónComprasToolStripMenuItem";
            this.gestiónComprasToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.gestiónComprasToolStripMenuItem.Text = "Gestión Compras";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.smartphone;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.inventario;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = global::Capa_Presentacion.Properties.Resources.inventario__1_;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(153, 30);
            this.inventarioToolStripMenuItem1.Text = "Inventarios";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.tiposDeComprobantesToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.configuracion;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.empresa;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.informe_de_venta;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.acceso_usuarios;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.presentacion;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // tiposDeComprobantesToolStripMenuItem
            // 
            this.tiposDeComprobantesToolStripMenuItem.Image = global::Capa_Presentacion.Properties.Resources.comprobante;
            this.tiposDeComprobantesToolStripMenuItem.Name = "tiposDeComprobantesToolStripMenuItem";
            this.tiposDeComprobantesToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.tiposDeComprobantesToolStripMenuItem.Text = "Tipos de Comprobantes";
            this.tiposDeComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeComprobantesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1064, 613);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnDashboard);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnCompras);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototipo Bodega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PUsuario.ResumeLayout(false);
            this.PProveedor.ResumeLayout(false);
            this.PProductos.ResumeLayout(false);
            this.PCompras.ResumeLayout(false);
            this.Pventas.ResumeLayout(false);
            this.PReportes.ResumeLayout(false);
            this.PDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logounemi)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Button BtnCompras;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeComprobantesToolStripMenuItem;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logounemi;
        private System.Windows.Forms.Label LbPrototipo;
        private System.Windows.Forms.Panel PProveedor;
        private System.Windows.Forms.Button Botton;
        private System.Windows.Forms.Panel PProductos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel PCompras;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel Pventas;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel PReportes;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox IconoMenu;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Button Btusuario;
        private System.Windows.Forms.Panel PUsuario;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Panel PDashboard;
        private System.Windows.Forms.Button button1;
    }
}

