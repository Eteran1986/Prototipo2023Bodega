namespace Capa_Presentacion
{
    partial class FrmEditarCliente
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
            this.label7 = new System.Windows.Forms.Label();
            this.CboEstadoCliente = new System.Windows.Forms.ComboBox();
            this.TxtEmailCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MtxtTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDirCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRUCCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TextID_Clientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(467, 198);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Estado";
            // 
            // CboEstadoCliente
            // 
            this.CboEstadoCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CboEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoCliente.FormattingEnabled = true;
            this.CboEstadoCliente.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.CboEstadoCliente.Location = new System.Drawing.Point(13, 203);
            this.CboEstadoCliente.Name = "CboEstadoCliente";
            this.CboEstadoCliente.Size = new System.Drawing.Size(121, 28);
            this.CboEstadoCliente.TabIndex = 44;
            this.CboEstadoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboEstadoCliente_KeyPress);
            // 
            // TxtEmailCliente
            // 
            this.TxtEmailCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailCliente.Location = new System.Drawing.Point(209, 146);
            this.TxtEmailCliente.Multiline = true;
            this.TxtEmailCliente.Name = "TxtEmailCliente";
            this.TxtEmailCliente.Size = new System.Drawing.Size(376, 25);
            this.TxtEmailCliente.TabIndex = 43;
            this.TxtEmailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailCliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Correo Cliente";
            // 
            // MtxtTelefonoCliente
            // 
            this.MtxtTelefonoCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MtxtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtTelefonoCliente.Location = new System.Drawing.Point(13, 148);
            this.MtxtTelefonoCliente.Mask = "000-000-0000";
            this.MtxtTelefonoCliente.Name = "MtxtTelefonoCliente";
            this.MtxtTelefonoCliente.Size = new System.Drawing.Size(115, 26);
            this.MtxtTelefonoCliente.TabIndex = 41;
            this.MtxtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtTelefonoCliente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Teléfono";
            // 
            // TxtDirCliente
            // 
            this.TxtDirCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtDirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirCliente.Location = new System.Drawing.Point(209, 90);
            this.TxtDirCliente.Multiline = true;
            this.TxtDirCliente.Name = "TxtDirCliente";
            this.TxtDirCliente.Size = new System.Drawing.Size(376, 25);
            this.TxtDirCliente.TabIndex = 39;
            this.TxtDirCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDirCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Dirección Cliente";
            // 
            // TxtRUCCliente
            // 
            this.TxtRUCCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtRUCCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUCCliente.Location = new System.Drawing.Point(13, 90);
            this.TxtRUCCliente.Multiline = true;
            this.TxtRUCCliente.Name = "TxtRUCCliente";
            this.TxtRUCCliente.Size = new System.Drawing.Size(173, 25);
            this.TxtRUCCliente.TabIndex = 37;
            this.TxtRUCCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUCCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cédula-RUC";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(206, 33);
            this.TxtNombreCliente.Multiline = true;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(379, 25);
            this.TxtNombreCliente.TabIndex = 32;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre Cliente";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodCliente.Location = new System.Drawing.Point(13, 33);
            this.TxtCodCliente.Multiline = true;
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.ReadOnly = true;
            this.TxtCodCliente.Size = new System.Drawing.Size(173, 25);
            this.TxtCodCliente.TabIndex = 34;
            this.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cod Cliente";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Capa_Presentacion.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(341, 198);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TextID_Clientes
            // 
            this.TextID_Clientes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TextID_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID_Clientes.Location = new System.Drawing.Point(106, 4);
            this.TextID_Clientes.Multiline = true;
            this.TextID_Clientes.Name = "TextID_Clientes";
            this.TextID_Clientes.ReadOnly = true;
            this.TextID_Clientes.Size = new System.Drawing.Size(41, 25);
            this.TextID_Clientes.TabIndex = 47;
            this.TextID_Clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextID_Clientes.Visible = false;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 240);
            this.Controls.Add(this.TextID_Clientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboEstadoCliente);
            this.Controls.Add(this.TxtEmailCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtxtTelefonoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDirCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRUCCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreCliente, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtRUCCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtDirCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.MtxtTelefonoCliente, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtEmailCliente, 0);
            this.Controls.SetChildIndex(this.CboEstadoCliente, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.TextID_Clientes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CboEstadoCliente;
        public System.Windows.Forms.TextBox TxtEmailCliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox MtxtTelefonoCliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDirCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtRUCCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox TextID_Clientes;
    }
}