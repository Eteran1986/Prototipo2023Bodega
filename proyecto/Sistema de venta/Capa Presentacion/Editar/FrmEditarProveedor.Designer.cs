namespace Capa_Presentacion
{
    partial class FrmEditarProveedor
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
            this.TxtEmailProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MtxtTelefondoProveedor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDirProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRUCProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TextID_Proveedores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(467, 185);
            // 
            // TxtEmailProveedor
            // 
            this.TxtEmailProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtEmailProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailProveedor.Location = new System.Drawing.Point(208, 148);
            this.TxtEmailProveedor.Multiline = true;
            this.TxtEmailProveedor.Name = "TxtEmailProveedor";
            this.TxtEmailProveedor.Size = new System.Drawing.Size(376, 25);
            this.TxtEmailProveedor.TabIndex = 25;
            this.TxtEmailProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailProveedor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Correo Proveedor";
            // 
            // MtxtTelefondoProveedor
            // 
            this.MtxtTelefondoProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MtxtTelefondoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtTelefondoProveedor.Location = new System.Drawing.Point(15, 150);
            this.MtxtTelefondoProveedor.Mask = "000-000-0000";
            this.MtxtTelefondoProveedor.Name = "MtxtTelefondoProveedor";
            this.MtxtTelefondoProveedor.Size = new System.Drawing.Size(115, 26);
            this.MtxtTelefondoProveedor.TabIndex = 23;
            this.MtxtTelefondoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtTelefondoProveedor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Teléfono";
            // 
            // TxtDirProveedor
            // 
            this.TxtDirProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtDirProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirProveedor.Location = new System.Drawing.Point(208, 96);
            this.TxtDirProveedor.Multiline = true;
            this.TxtDirProveedor.Name = "TxtDirProveedor";
            this.TxtDirProveedor.Size = new System.Drawing.Size(376, 25);
            this.TxtDirProveedor.TabIndex = 21;
            this.TxtDirProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDirProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dirección Proveedor";
            // 
            // TxtRUCProveedor
            // 
            this.TxtRUCProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtRUCProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUCProveedor.Location = new System.Drawing.Point(12, 96);
            this.TxtRUCProveedor.Multiline = true;
            this.TxtRUCProveedor.Name = "TxtRUCProveedor";
            this.TxtRUCProveedor.Size = new System.Drawing.Size(173, 25);
            this.TxtRUCProveedor.TabIndex = 19;
            this.TxtRUCProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUCProveedor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "RUC Proveedor";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(205, 32);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(379, 25);
            this.TxtNombreProveedor.TabIndex = 14;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Proveedor";
            // 
            // TxtCodProveedor
            // 
            this.TxtCodProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtCodProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodProveedor.Location = new System.Drawing.Point(12, 32);
            this.TxtCodProveedor.Multiline = true;
            this.TxtCodProveedor.Name = "TxtCodProveedor";
            this.TxtCodProveedor.ReadOnly = true;
            this.TxtCodProveedor.Size = new System.Drawing.Size(173, 25);
            this.TxtCodProveedor.TabIndex = 16;
            this.TxtCodProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cod Proveedor";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Capa_Presentacion.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(341, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TextID_Proveedores
            // 
            this.TextID_Proveedores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TextID_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID_Proveedores.Location = new System.Drawing.Point(117, 4);
            this.TextID_Proveedores.Multiline = true;
            this.TextID_Proveedores.Name = "TextID_Proveedores";
            this.TextID_Proveedores.ReadOnly = true;
            this.TextID_Proveedores.Size = new System.Drawing.Size(41, 25);
            this.TextID_Proveedores.TabIndex = 31;
            this.TextID_Proveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextID_Proveedores.Visible = false;
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 227);
            this.Controls.Add(this.TextID_Proveedores);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.TxtEmailProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtxtTelefondoProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDirProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRUCProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodProveedor);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProveedor";
            this.Text = "Editar Proveedor";
            this.Load += new System.EventHandler(this.FrmEditarProveedor_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodProveedor, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreProveedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtRUCProveedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtDirProveedor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.MtxtTelefondoProveedor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtEmailProveedor, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.TextID_Proveedores, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtEmailProveedor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox MtxtTelefondoProveedor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDirProveedor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtRUCProveedor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodProveedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox TextID_Proveedores;
    }
}