namespace Capa_Presentacion
{
    partial class FrmAnularIngresoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.TxtIdDetalleIngreso = new System.Windows.Forms.TextBox();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdIngreso = new System.Windows.Forms.TextBox();
            this.TxtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNoIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(864, 577);
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotalPagar.BackColor = System.Drawing.Color.Linen;
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(113, 582);
            this.TxtTotalPagar.Multiline = true;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(213, 26);
            this.TxtTotalPagar.TabIndex = 42;
            this.TxtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(18, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Total Pagar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(972, 424);
            this.dataGridView1.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.DtpFechaCaducidad);
            this.groupBox2.Controls.Add(this.TxtIdDetalleIngreso);
            this.groupBox2.Controls.Add(this.BtnAgregarProducto);
            this.groupBox2.Controls.Add(this.BtnEliminarProducto);
            this.groupBox2.Controls.Add(this.TxtCostoUnitario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnBuscarProducto);
            this.groupBox2.Controls.Add(this.TxtIdProducto);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtNombreProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCodProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 137);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Producto";
            this.groupBox2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(372, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Fecha Caducidad";
            // 
            // DtpFechaCaducidad
            // 
            this.DtpFechaCaducidad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaCaducidad.Location = new System.Drawing.Point(370, 101);
            this.DtpFechaCaducidad.Name = "DtpFechaCaducidad";
            this.DtpFechaCaducidad.Size = new System.Drawing.Size(102, 22);
            this.DtpFechaCaducidad.TabIndex = 34;
            this.DtpFechaCaducidad.Value = new System.DateTime(2023, 1, 28, 0, 0, 0, 0);
            // 
            // TxtIdDetalleIngreso
            // 
            this.TxtIdDetalleIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtIdDetalleIngreso.Location = new System.Drawing.Point(139, -1);
            this.TxtIdDetalleIngreso.Multiline = true;
            this.TxtIdDetalleIngreso.Name = "TxtIdDetalleIngreso";
            this.TxtIdDetalleIngreso.Size = new System.Drawing.Size(24, 26);
            this.TxtIdDetalleIngreso.TabIndex = 36;
            this.TxtIdDetalleIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtIdDetalleIngreso.Visible = false;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregarProducto.Enabled = false;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.Image = global::Capa_Presentacion.Properties.Resources.agregar;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(916, 45);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnAgregarProducto.TabIndex = 35;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminarProducto.Enabled = false;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.Image = global::Capa_Presentacion.Properties.Resources.cancelar;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(916, 79);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnEliminarProducto.TabIndex = 34;
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BackColor = System.Drawing.Color.Linen;
            this.TxtCostoUnitario.Enabled = false;
            this.TxtCostoUnitario.Location = new System.Drawing.Point(560, 47);
            this.TxtCostoUnitario.Multiline = true;
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(213, 26);
            this.TxtCostoUnitario.TabIndex = 33;
            this.TxtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(557, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo Unitario";
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProducto.Enabled = false;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProducto.Image = global::Capa_Presentacion.Properties.Resources.buscardor;
            this.BtnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(514, 47);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnBuscarProducto.TabIndex = 31;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtIdProducto.Location = new System.Drawing.Point(13, 47);
            this.TxtIdProducto.Multiline = true;
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(24, 26);
            this.TxtIdProducto.TabIndex = 7;
            this.TxtIdProducto.Visible = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.Linen;
            this.TxtCantidad.Enabled = false;
            this.TxtCantidad.Location = new System.Drawing.Point(788, 47);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(87, 26);
            this.TxtCantidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(785, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtNombreProducto.Enabled = false;
            this.TxtNombreProducto.Location = new System.Drawing.Point(266, 47);
            this.TxtNombreProducto.Multiline = true;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(242, 26);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(263, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Producto";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtCodProducto.Enabled = false;
            this.TxtCodProducto.Location = new System.Drawing.Point(43, 47);
            this.TxtCodProducto.Multiline = true;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.ReadOnly = true;
            this.TxtCodProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtCodProducto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(40, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código Producto";
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.Color.Azure;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = global::Capa_Presentacion.Properties.Resources.no_tocar;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(738, 576);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(120, 30);
            this.btnAnular.TabIndex = 38;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpFechaIngreso);
            this.groupBox1.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox1.Controls.Add(this.TxtIdProveedor);
            this.groupBox1.Controls.Add(this.TxtIdIngreso);
            this.groupBox1.Controls.Add(this.TxtComprobante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNomProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNoIngreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 136);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(584, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha Ingreso";
            // 
            // DtpFechaIngreso
            // 
            this.DtpFechaIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaIngreso.Enabled = false;
            this.DtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaIngreso.Location = new System.Drawing.Point(582, 47);
            this.DtpFechaIngreso.Name = "DtpFechaIngreso";
            this.DtpFechaIngreso.Size = new System.Drawing.Size(108, 22);
            this.DtpFechaIngreso.TabIndex = 32;
            this.DtpFechaIngreso.Value = new System.DateTime(2023, 1, 28, 0, 0, 0, 0);
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProveedor.Enabled = false;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.Image = global::Capa_Presentacion.Properties.Resources.buscardor;
            this.BtnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(540, 47);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(30, 26);
            this.BtnBuscarProveedor.TabIndex = 31;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.BackColor = System.Drawing.Color.Linen;
            this.TxtIdProveedor.Location = new System.Drawing.Point(262, 47);
            this.TxtIdProveedor.Multiline = true;
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(24, 26);
            this.TxtIdProveedor.TabIndex = 8;
            this.TxtIdProveedor.Visible = false;
            // 
            // TxtIdIngreso
            // 
            this.TxtIdIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtIdIngreso.Location = new System.Drawing.Point(13, 47);
            this.TxtIdIngreso.Multiline = true;
            this.TxtIdIngreso.Name = "TxtIdIngreso";
            this.TxtIdIngreso.Size = new System.Drawing.Size(24, 26);
            this.TxtIdIngreso.TabIndex = 7;
            this.TxtIdIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtIdIngreso.Visible = false;
            // 
            // TxtComprobante
            // 
            this.TxtComprobante.BackColor = System.Drawing.Color.Linen;
            this.TxtComprobante.Enabled = false;
            this.TxtComprobante.Location = new System.Drawing.Point(43, 100);
            this.TxtComprobante.Multiline = true;
            this.TxtComprobante.Name = "TxtComprobante";
            this.TxtComprobante.Size = new System.Drawing.Size(213, 26);
            this.TxtComprobante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(40, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comprobante";
            // 
            // TxtNomProveedor
            // 
            this.TxtNomProveedor.BackColor = System.Drawing.Color.Linen;
            this.TxtNomProveedor.Enabled = false;
            this.TxtNomProveedor.Location = new System.Drawing.Point(292, 47);
            this.TxtNomProveedor.Multiline = true;
            this.TxtNomProveedor.Name = "TxtNomProveedor";
            this.TxtNomProveedor.ReadOnly = true;
            this.TxtNomProveedor.Size = new System.Drawing.Size(242, 26);
            this.TxtNomProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(289, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor";
            // 
            // TxtNoIngreso
            // 
            this.TxtNoIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtNoIngreso.Enabled = false;
            this.TxtNoIngreso.Location = new System.Drawing.Point(43, 47);
            this.TxtNoIngreso.Multiline = true;
            this.TxtNoIngreso.Name = "TxtNoIngreso";
            this.TxtNoIngreso.ReadOnly = true;
            this.TxtNoIngreso.Size = new System.Drawing.Size(213, 26);
            this.TxtNoIngreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Ingreso";
            // 
            // FrmAnularIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 619);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnularIngresoProducto";
            this.Text = "Anular Ingreso Producto";
            this.Load += new System.EventHandler(this.FrmAnularIngresoProducto_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAnular, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtTotalPagar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker DtpFechaCaducidad;
        public System.Windows.Forms.TextBox TxtIdDetalleIngreso;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.Button BtnEliminarProducto;
        public System.Windows.Forms.TextBox TxtCostoUnitario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BtnBuscarProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker DtpFechaIngreso;
        public System.Windows.Forms.Button BtnBuscarProveedor;
        public System.Windows.Forms.TextBox TxtIdProveedor;
        public System.Windows.Forms.TextBox TxtIdIngreso;
        public System.Windows.Forms.TextBox TxtComprobante;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNomProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNoIngreso;
        private System.Windows.Forms.Label label1;
    }
}