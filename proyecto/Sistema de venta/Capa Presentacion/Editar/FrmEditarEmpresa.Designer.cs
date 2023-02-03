namespace Capa_Presentacion
{
    partial class FrmEditarEmpresa
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
            this.TxtExaminar = new System.Windows.Forms.TextBox();
            this.PtbLogoAgregar = new System.Windows.Forms.PictureBox();
            this.BtnGuardarFoto = new System.Windows.Forms.Button();
            this.MtxtTelefonoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDirEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRUCEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomEmpresa = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TxtIDEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(136, 179);
            // 
            // TxtExaminar
            // 
            this.TxtExaminar.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExaminar.Location = new System.Drawing.Point(368, 180);
            this.TxtExaminar.Multiline = true;
            this.TxtExaminar.Name = "TxtExaminar";
            this.TxtExaminar.ReadOnly = true;
            this.TxtExaminar.Size = new System.Drawing.Size(25, 29);
            this.TxtExaminar.TabIndex = 46;
            this.TxtExaminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtExaminar.Visible = false;
            // 
            // PtbLogoAgregar
            // 
            this.PtbLogoAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PtbLogoAgregar.Image = global::Capa_Presentacion.Properties.Resources.sinlogo;
            this.PtbLogoAgregar.Location = new System.Drawing.Point(407, 33);
            this.PtbLogoAgregar.Name = "PtbLogoAgregar";
            this.PtbLogoAgregar.Size = new System.Drawing.Size(115, 130);
            this.PtbLogoAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbLogoAgregar.TabIndex = 45;
            this.PtbLogoAgregar.TabStop = false;
            // 
            // BtnGuardarFoto
            // 
            this.BtnGuardarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarFoto.BackColor = System.Drawing.Color.Azure;
            this.BtnGuardarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarFoto.Image = global::Capa_Presentacion.Properties.Resources.agregar_foto;
            this.BtnGuardarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarFoto.Location = new System.Drawing.Point(399, 179);
            this.BtnGuardarFoto.Name = "BtnGuardarFoto";
            this.BtnGuardarFoto.Size = new System.Drawing.Size(129, 30);
            this.BtnGuardarFoto.TabIndex = 44;
            this.BtnGuardarFoto.Text = "Agregar Logo";
            this.BtnGuardarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarFoto.UseVisualStyleBackColor = false;
            this.BtnGuardarFoto.Click += new System.EventHandler(this.BtnGuardarFoto_Click);
            // 
            // MtxtTelefonoEmpresa
            // 
            this.MtxtTelefonoEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.MtxtTelefonoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtTelefonoEmpresa.Location = new System.Drawing.Point(7, 135);
            this.MtxtTelefonoEmpresa.Mask = "000-000-0000";
            this.MtxtTelefonoEmpresa.Name = "MtxtTelefonoEmpresa";
            this.MtxtTelefonoEmpresa.Size = new System.Drawing.Size(115, 26);
            this.MtxtTelefonoEmpresa.TabIndex = 43;
            this.MtxtTelefonoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtTelefonoEmpresa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Teléfono";
            // 
            // TxtEmailEmpresa
            // 
            this.TxtEmailEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailEmpresa.Location = new System.Drawing.Point(141, 138);
            this.TxtEmailEmpresa.Multiline = true;
            this.TxtEmailEmpresa.Name = "TxtEmailEmpresa";
            this.TxtEmailEmpresa.Size = new System.Drawing.Size(243, 25);
            this.TxtEmailEmpresa.TabIndex = 40;
            this.TxtEmailEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailEmpresa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Correo Empresa";
            // 
            // TxtDirEmpresa
            // 
            this.TxtDirEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtDirEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirEmpresa.Location = new System.Drawing.Point(8, 85);
            this.TxtDirEmpresa.Multiline = true;
            this.TxtDirEmpresa.Name = "TxtDirEmpresa";
            this.TxtDirEmpresa.Size = new System.Drawing.Size(376, 25);
            this.TxtDirEmpresa.TabIndex = 38;
            this.TxtDirEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDirEmpresa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dirección Empresa";
            // 
            // TxtRUCEmpresa
            // 
            this.TxtRUCEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtRUCEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUCEmpresa.Location = new System.Drawing.Point(204, 33);
            this.TxtRUCEmpresa.Multiline = true;
            this.TxtRUCEmpresa.Name = "TxtRUCEmpresa";
            this.TxtRUCEmpresa.Size = new System.Drawing.Size(180, 25);
            this.TxtRUCEmpresa.TabIndex = 36;
            this.TxtRUCEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUCEmpresa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "RUC Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre Empresa";
            // 
            // TxtNomEmpresa
            // 
            this.TxtNomEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNomEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomEmpresa.Location = new System.Drawing.Point(8, 33);
            this.TxtNomEmpresa.Multiline = true;
            this.TxtNomEmpresa.Name = "TxtNomEmpresa";
            this.TxtNomEmpresa.Size = new System.Drawing.Size(173, 25);
            this.TxtNomEmpresa.TabIndex = 33;
            this.TxtNomEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomEmpresa_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Capa_Presentacion.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(10, 180);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TxtIDEmpresa
            // 
            this.TxtIDEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtIDEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDEmpresa.Location = new System.Drawing.Point(157, 2);
            this.TxtIDEmpresa.Multiline = true;
            this.TxtIDEmpresa.Name = "TxtIDEmpresa";
            this.TxtIDEmpresa.ReadOnly = true;
            this.TxtIDEmpresa.Size = new System.Drawing.Size(24, 25);
            this.TxtIDEmpresa.TabIndex = 48;
            this.TxtIDEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIDEmpresa.Visible = false;
            // 
            // FrmEditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 221);
            this.Controls.Add(this.TxtIDEmpresa);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.TxtExaminar);
            this.Controls.Add(this.PtbLogoAgregar);
            this.Controls.Add(this.BtnGuardarFoto);
            this.Controls.Add(this.MtxtTelefonoEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmailEmpresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDirEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRUCEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomEmpresa);
            this.Name = "FrmEditarEmpresa";
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.FrmEditarEmpresa1_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.TxtNomEmpresa, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtRUCEmpresa, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtDirEmpresa, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtEmailEmpresa, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.MtxtTelefonoEmpresa, 0);
            this.Controls.SetChildIndex(this.BtnGuardarFoto, 0);
            this.Controls.SetChildIndex(this.PtbLogoAgregar, 0);
            this.Controls.SetChildIndex(this.TxtExaminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.TxtIDEmpresa, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtExaminar;
        public System.Windows.Forms.Button BtnGuardarFoto;
        public System.Windows.Forms.MaskedTextBox MtxtTelefonoEmpresa;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtEmailEmpresa;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtDirEmpresa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtRUCEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNomEmpresa;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox TxtIDEmpresa;
        public System.Windows.Forms.PictureBox PtbLogoAgregar;
    }
}