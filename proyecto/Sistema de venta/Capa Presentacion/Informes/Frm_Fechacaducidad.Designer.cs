namespace Capa_Presentacion
{
    partial class Frm_Fechacaducidad
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrarInformeFechacaducidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_Generales = new Capa_Presentacion.Informes.Datos_Generales();
            this.mostrar_InformeFechacaducidadTableAdapter = new Capa_Presentacion.Informes.Datos_GeneralesTableAdapters.Mostrar_InformeFechacaducidadTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInformeFechacaducidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.BtnAplicar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DTPHasta);
            this.panel1.Controls.Add(this.DTPDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 488);
            this.panel1.TabIndex = 0;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Location = new System.Drawing.Point(22, 273);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(106, 23);
            this.BtnAplicar.TabIndex = 6;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASTA";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(28, 247);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(95, 20);
            this.DTPHasta.TabIndex = 3;
            // 
            // DTPDesde
            // 
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(28, 193);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(95, 20);
            this.DTPDesde.TabIndex = 2;
            this.DTPDesde.Value = new System.DateTime(2023, 2, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA";
            // 
            // BtnTodos
            // 
            this.BtnTodos.Location = new System.Drawing.Point(22, 75);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(106, 23);
            this.BtnTodos.TabIndex = 0;
            this.BtnTodos.Text = "Today";
            this.BtnTodos.UseVisualStyleBackColor = true;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MostrarInf_FechaCaducidad";
            reportDataSource1.Value = this.mostrarInformeFechacaducidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Informes.RptFechaCaducidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(153, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 488);
            this.reportViewer1.TabIndex = 1;
            // 
            // mostrarInformeFechacaducidadBindingSource
            // 
            this.mostrarInformeFechacaducidadBindingSource.DataMember = "Mostrar_InformeFechacaducidad";
            this.mostrarInformeFechacaducidadBindingSource.DataSource = this.datos_Generales;
            // 
            // datos_Generales
            // 
            this.datos_Generales.DataSetName = "Datos_Generales";
            this.datos_Generales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrar_InformeFechacaducidadTableAdapter
            // 
            this.mostrar_InformeFechacaducidadTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Fechacaducidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Fechacaducidad";
            this.Text = "Frm_Fechacaducidad";
            this.Load += new System.EventHandler(this.Frm_Fechacaducidad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInformeFechacaducidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTodos;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.BindingSource mostrarInformeFechacaducidadBindingSource;
        private Informes.Datos_Generales datos_Generales;
        private Informes.Datos_GeneralesTableAdapters.Mostrar_InformeFechacaducidadTableAdapter mostrar_InformeFechacaducidadTableAdapter;
    }
}