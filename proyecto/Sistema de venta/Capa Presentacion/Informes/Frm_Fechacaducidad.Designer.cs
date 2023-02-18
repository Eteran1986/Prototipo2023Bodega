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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Mostrar_InformeFechacaducidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_Generales = new Capa_Presentacion.Informes.Datos_Generales();
            this.mostrarInfFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAplicarDias = new System.Windows.Forms.Button();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.RVRPTFECHA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrarInformeFechacaducidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrar_InformeFechacaducidadTableAdapter = new Capa_Presentacion.Informes.Datos_GeneralesTableAdapters.Mostrar_InformeFechacaducidadTableAdapter();
            this.RVRANGOFECHA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_Inf_FechaTableAdapter = new Capa_Presentacion.Informes.Datos_GeneralesTableAdapters.Mostrar_Inf_FechaTableAdapter();
            this.mostrar_Inf_FechaTableAdapter1 = new Capa_Presentacion.Informes.Datos_GeneralesTableAdapters.Mostrar_Inf_FechaTableAdapter();
            this.RVRDias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrarInfFechaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_InformeFechacaducidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInfFechaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInformeFechacaducidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInfFechaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar_InformeFechacaducidadBindingSource
            // 
            this.Mostrar_InformeFechacaducidadBindingSource.DataMember = "Mostrar_InformeFechacaducidad";
            this.Mostrar_InformeFechacaducidadBindingSource.DataSource = this.datos_Generales;
            // 
            // datos_Generales
            // 
            this.datos_Generales.DataSetName = "Datos_Generales";
            this.datos_Generales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarInfFechaBindingSource
            // 
            this.mostrarInfFechaBindingSource.DataMember = "Mostrar_Inf_Fecha";
            this.mostrarInfFechaBindingSource.DataSource = this.datos_Generales;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnAplicarDias);
            this.panel1.Controls.Add(this.TxtDias);
            this.panel1.Controls.Add(this.label4);
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
            this.panel1.Size = new System.Drawing.Size(210, 488);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consulta Días";
            // 
            // BtnAplicarDias
            // 
            this.BtnAplicarDias.Location = new System.Drawing.Point(55, 311);
            this.BtnAplicarDias.Name = "BtnAplicarDias";
            this.BtnAplicarDias.Size = new System.Drawing.Size(106, 23);
            this.BtnAplicarDias.TabIndex = 9;
            this.BtnAplicarDias.Text = "Aplicar";
            this.BtnAplicarDias.UseVisualStyleBackColor = true;
            this.BtnAplicarDias.Click += new System.EventHandler(this.BtnAplicarDias_Click);
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(68, 285);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(77, 20);
            this.TxtDias.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consulta Rango";
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Location = new System.Drawing.Point(55, 177);
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
            this.label3.Location = new System.Drawing.Point(26, 124);
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
            this.label2.Location = new System.Drawing.Point(124, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASTA";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(107, 146);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(95, 20);
            this.DTPHasta.TabIndex = 3;
            // 
            // DTPDesde
            // 
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(6, 146);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(95, 20);
            this.DTPDesde.TabIndex = 2;
            this.DTPDesde.Value = new System.DateTime(2023, 2, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Caducidad";
            // 
            // BtnTodos
            // 
            this.BtnTodos.Location = new System.Drawing.Point(55, 417);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(106, 23);
            this.BtnTodos.TabIndex = 0;
            this.BtnTodos.Text = "Reporte General";
            this.BtnTodos.UseVisualStyleBackColor = true;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // RVRPTFECHA
            // 
            this.RVRPTFECHA.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource10.Name = "MostrarInf_FechaCaducidad";
            reportDataSource10.Value = this.Mostrar_InformeFechacaducidadBindingSource;
            this.RVRPTFECHA.LocalReport.DataSources.Add(reportDataSource10);
            this.RVRPTFECHA.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Informes.RptFechaCaducidad.rdlc";
            this.RVRPTFECHA.Location = new System.Drawing.Point(210, 0);
            this.RVRPTFECHA.Name = "RVRPTFECHA";
            this.RVRPTFECHA.ServerReport.BearerToken = null;
            this.RVRPTFECHA.Size = new System.Drawing.Size(668, 488);
            this.RVRPTFECHA.TabIndex = 1;
            // 
            // mostrarInformeFechacaducidadBindingSource
            // 
            this.mostrarInformeFechacaducidadBindingSource.DataMember = "Mostrar_InformeFechacaducidad";
            this.mostrarInformeFechacaducidadBindingSource.DataSource = this.datos_Generales;
            // 
            // mostrar_InformeFechacaducidadTableAdapter
            // 
            this.mostrar_InformeFechacaducidadTableAdapter.ClearBeforeFill = true;
            // 
            // RVRANGOFECHA
            // 
            this.RVRANGOFECHA.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource11.Name = "Datos_Generales";
            reportDataSource11.Value = this.mostrarInfFechaBindingSource;
            this.RVRANGOFECHA.LocalReport.DataSources.Add(reportDataSource11);
            this.RVRANGOFECHA.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Informes.RPTRangoFecha.rdlc";
            this.RVRANGOFECHA.Location = new System.Drawing.Point(210, 0);
            this.RVRANGOFECHA.Name = "RVRANGOFECHA";
            this.RVRANGOFECHA.ServerReport.BearerToken = null;
            this.RVRANGOFECHA.Size = new System.Drawing.Size(668, 488);
            this.RVRANGOFECHA.TabIndex = 2;
            // 
            // mostrar_Inf_FechaTableAdapter
            // 
            this.mostrar_Inf_FechaTableAdapter.ClearBeforeFill = true;
            // 
            // mostrar_Inf_FechaTableAdapter1
            // 
            this.mostrar_Inf_FechaTableAdapter1.ClearBeforeFill = true;
            // 
            // RVRDias
            // 
            this.RVRDias.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource12.Name = "Datos_Generales";
            reportDataSource12.Value = this.mostrarInfFechaBindingSource;
            this.RVRDias.LocalReport.DataSources.Add(reportDataSource12);
            this.RVRDias.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Informes.Rpt_Informedias.rdlc";
            this.RVRDias.Location = new System.Drawing.Point(210, 0);
            this.RVRDias.Name = "RVRDias";
            this.RVRDias.ServerReport.BearerToken = null;
            this.RVRDias.Size = new System.Drawing.Size(668, 488);
            this.RVRDias.TabIndex = 3;
            // 
            // mostrarInfFechaBindingSource1
            // 
            this.mostrarInfFechaBindingSource1.DataMember = "Mostrar_Inf_Fecha";
            this.mostrarInfFechaBindingSource1.DataSource = this.datos_Generales;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(0, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Consulta General";
            // 
            // Frm_Fechacaducidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 488);
            this.Controls.Add(this.RVRDias);
            this.Controls.Add(this.RVRANGOFECHA);
            this.Controls.Add(this.RVRPTFECHA);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Fechacaducidad";
            this.Text = "Consulta Fecha Caducidad";
            this.Load += new System.EventHandler(this.Frm_Fechacaducidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_InformeFechacaducidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInfFechaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInformeFechacaducidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInfFechaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer RVRPTFECHA;
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
        private System.Windows.Forms.BindingSource Mostrar_InformeFechacaducidadBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RVRANGOFECHA;
        private System.Windows.Forms.BindingSource mostrarInfFechaBindingSource;
        private Informes.Datos_GeneralesTableAdapters.Mostrar_Inf_FechaTableAdapter mostrar_Inf_FechaTableAdapter;
        private System.Windows.Forms.Label label4;
        private Informes.Datos_GeneralesTableAdapters.Mostrar_Inf_FechaTableAdapter mostrar_Inf_FechaTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer RVRDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAplicarDias;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.BindingSource mostrarInfFechaBindingSource1;
        private System.Windows.Forms.Label label6;
    }
}