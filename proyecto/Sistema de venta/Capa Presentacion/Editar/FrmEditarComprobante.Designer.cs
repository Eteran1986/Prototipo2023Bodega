namespace Capa_Presentacion
{
    partial class FrmEditarComprobante
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
            this.TxtCorrelativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreComprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Txtidcompro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(189, 133);
            // 
            // TxtCorrelativo
            // 
            this.TxtCorrelativo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtCorrelativo.Enabled = false;
            this.TxtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrelativo.Location = new System.Drawing.Point(165, 93);
            this.TxtCorrelativo.Multiline = true;
            this.TxtCorrelativo.Name = "TxtCorrelativo";
            this.TxtCorrelativo.Size = new System.Drawing.Size(143, 25);
            this.TxtCorrelativo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Correlativo";
            // 
            // TxtTipoComprobante
            // 
            this.TxtTipoComprobante.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoComprobante.Location = new System.Drawing.Point(10, 93);
            this.TxtTipoComprobante.Multiline = true;
            this.TxtTipoComprobante.Name = "TxtTipoComprobante";
            this.TxtTipoComprobante.Size = new System.Drawing.Size(143, 25);
            this.TxtTipoComprobante.TabIndex = 29;
            this.TxtTipoComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoComprobante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tipo de Comprobante";
            // 
            // TxtNombreComprobante
            // 
            this.TxtNombreComprobante.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtNombreComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreComprobante.Location = new System.Drawing.Point(10, 32);
            this.TxtNombreComprobante.Multiline = true;
            this.TxtNombreComprobante.Name = "TxtNombreComprobante";
            this.TxtNombreComprobante.Size = new System.Drawing.Size(298, 25);
            this.TxtNombreComprobante.TabIndex = 27;
            this.TxtNombreComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreComprobante_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Comprobante";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Capa_Presentacion.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(63, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Txtidcompro
            // 
            this.Txtidcompro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txtidcompro.Enabled = false;
            this.Txtidcompro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidcompro.Location = new System.Drawing.Point(157, 6);
            this.Txtidcompro.Multiline = true;
            this.Txtidcompro.Name = "Txtidcompro";
            this.Txtidcompro.Size = new System.Drawing.Size(26, 25);
            this.Txtidcompro.TabIndex = 48;
            this.Txtidcompro.Visible = false;
            // 
            // FrmEditarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 175);
            this.Controls.Add(this.Txtidcompro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.TxtCorrelativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTipoComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreComprobante);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarComprobante";
            this.Text = "Editar Comprobante";
            this.Load += new System.EventHandler(this.FrmEditarComprobante_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreComprobante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtTipoComprobante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtCorrelativo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.Txtidcompro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtCorrelativo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtTipoComprobante;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtNombreComprobante;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox Txtidcompro;
    }
}