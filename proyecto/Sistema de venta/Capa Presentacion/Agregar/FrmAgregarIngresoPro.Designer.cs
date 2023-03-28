using static System.Net.WebRequestMethods;
using System;

namespace Capa_Presentacion
{
    partial class FrmAgregarIngresoPro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdIngreso = new System.Windows.Forms.TextBox();
            this.TxtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNoIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TxtIdDetalleIngreso = new System.Windows.Forms.TextBox();
            this.DtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Fecha_Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(818, 533);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Producto";
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.Image = global::Capa_Presentacion.Properties.Resources.buscardor;
            this.BtnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(620, 47);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(30, 26);
            this.BtnBuscarProveedor.TabIndex = 31;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.BackColor = System.Drawing.Color.Linen;
            this.TxtIdProveedor.Location = new System.Drawing.Point(364, 18);
            this.TxtIdProveedor.Multiline = true;
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(24, 26);
            this.TxtIdProveedor.TabIndex = 8;
            this.TxtIdProveedor.Visible = false;
            // 
            // TxtIdIngreso
            // 
            this.TxtIdIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtIdIngreso.Location = new System.Drawing.Point(104, 18);
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
            this.TxtComprobante.Location = new System.Drawing.Point(663, 47);
            this.TxtComprobante.Multiline = true;
            this.TxtComprobante.Name = "TxtComprobante";
            this.TxtComprobante.Size = new System.Drawing.Size(213, 26);
            this.TxtComprobante.TabIndex = 5;
            this.TxtComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComprobante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(660, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comprobante";
            // 
            // TxtNomProveedor
            // 
            this.TxtNomProveedor.BackColor = System.Drawing.Color.Linen;
            this.TxtNomProveedor.Location = new System.Drawing.Point(222, 47);
            this.TxtNomProveedor.Multiline = true;
            this.TxtNomProveedor.Name = "TxtNomProveedor";
            this.TxtNomProveedor.ReadOnly = true;
            this.TxtNomProveedor.Size = new System.Drawing.Size(390, 26);
            this.TxtNomProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(219, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor";
            // 
            // TxtNoIngreso
            // 
            this.TxtNoIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtNoIngreso.Location = new System.Drawing.Point(14, 47);
            this.TxtNoIngreso.Multiline = true;
            this.TxtNoIngreso.Name = "TxtNoIngreso";
            this.TxtNoIngreso.ReadOnly = true;
            this.TxtNoIngreso.Size = new System.Drawing.Size(191, 26);
            this.TxtNoIngreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Ingreso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Azure;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Capa_Presentacion.Properties.Resources.guardar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(692, 533);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(18, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Pagar";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotalPagar.BackColor = System.Drawing.Color.Linen;
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(113, 539);
            this.TxtTotalPagar.Multiline = true;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(213, 26);
            this.TxtTotalPagar.TabIndex = 36;
            this.TxtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TxtCodProducto
            // 
            this.TxtCodProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtCodProducto.Location = new System.Drawing.Point(43, 47);
            this.TxtCodProducto.Multiline = true;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.ReadOnly = true;
            this.TxtCodProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtCodProducto.TabIndex = 1;
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
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtNombreProducto.Location = new System.Drawing.Point(266, 47);
            this.TxtNombreProducto.Multiline = true;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(347, 26);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(268, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.Linen;
            this.TxtCantidad.Location = new System.Drawing.Point(271, 98);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(87, 26);
            this.TxtCantidad.TabIndex = 5;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
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
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProducto.Image = global::Capa_Presentacion.Properties.Resources.buscardor;
            this.BtnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(619, 47);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnBuscarProducto.TabIndex = 31;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(652, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo Unitario";
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BackColor = System.Drawing.Color.Linen;
            this.TxtCostoUnitario.Location = new System.Drawing.Point(655, 47);
            this.TxtCostoUnitario.Multiline = true;
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(213, 26);
            this.TxtCostoUnitario.TabIndex = 33;
            this.TxtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.Image = global::Capa_Presentacion.Properties.Resources.cancelar;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(879, 81);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnEliminarProducto.TabIndex = 34;
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.Image = global::Capa_Presentacion.Properties.Resources.agregar;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(879, 47);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(30, 26);
            this.BtnAgregarProducto.TabIndex = 35;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TxtIdDetalleIngreso
            // 
            this.TxtIdDetalleIngreso.BackColor = System.Drawing.Color.Linen;
            this.TxtIdDetalleIngreso.Location = new System.Drawing.Point(139, 0);
            this.TxtIdDetalleIngreso.Multiline = true;
            this.TxtIdDetalleIngreso.Name = "TxtIdDetalleIngreso";
            this.TxtIdDetalleIngreso.Size = new System.Drawing.Size(24, 26);
            this.TxtIdDetalleIngreso.TabIndex = 36;
            this.TxtIdDetalleIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtIdDetalleIngreso.Visible = false;
            // 
            // DtpFechaCaducidad
            // 
            this.DtpFechaCaducidad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaCaducidad.Location = new System.Drawing.Point(381, 99);
            this.DtpFechaCaducidad.MinDate = new System.DateTime(2022, 2, 13, 0, 0, 0, 0);
            this.DtpFechaCaducidad.Name = "DtpFechaCaducidad";
            this.DtpFechaCaducidad.Size = new System.Drawing.Size(102, 22);
            this.DtpFechaCaducidad.TabIndex = 34;
            this.DtpFechaCaducidad.Tag = "";
            this.DtpFechaCaducidad.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(368, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Fecha Caducidad";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 137);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Producto";
            // 
            // Fecha_Caducidad
            // 
            this.Fecha_Caducidad.HeaderText = "Fecha_Caducidad";
            this.Fecha_Caducidad.Name = "Fecha_Caducidad";
            this.Fecha_Caducidad.ReadOnly = true;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            // 
            // Costo_Unitario
            // 
            this.Costo_Unitario.HeaderText = "Costo_Unitario";
            this.Costo_Unitario.Name = "Costo_Unitario";
            this.Costo_Unitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre,
            this.Cantidad,
            this.Costo_Unitario,
            this.Sub_Total,
            this.Fecha_Caducidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 283);
            this.dataGridView1.TabIndex = 35;
            // 
            // FrmAgregarIngresoPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 575);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarIngresoPro";
            this.Text = "Ingreso Producto";
            this.Load += new System.EventHandler(this.FrmAgregarIngresoPro_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtTotalPagar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtNoIngreso;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtIdProveedor;
        public System.Windows.Forms.TextBox TxtIdIngreso;
        public System.Windows.Forms.TextBox TxtComprobante;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNomProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BtnBuscarProveedor;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtCantidad;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtCostoUnitario;
        public System.Windows.Forms.Button BtnEliminarProducto;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.TextBox TxtIdDetalleIngreso;
        public System.Windows.Forms.DateTimePicker DtpFechaCaducidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}