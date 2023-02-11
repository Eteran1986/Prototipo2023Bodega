namespace Capa_Presentacion.Informes
{
    partial class FrmMostrar_IngresoProducto
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
            this.mostrarIngresoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_Generales = new Capa_Presentacion.Informes.Datos_Generales();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_IngresoProductoTableAdapter = new Capa_Presentacion.Informes.Datos_GeneralesTableAdapters.Mostrar_IngresoProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarIngresoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarIngresoProductoBindingSource
            // 
            this.mostrarIngresoProductoBindingSource.DataMember = "Mostrar_IngresoProducto";
            this.mostrarIngresoProductoBindingSource.DataSource = this.datos_Generales;
            // 
            // datos_Generales
            // 
            this.datos_Generales.DataSetName = "Datos_Generales";
            this.datos_Generales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datos_Generales";
            reportDataSource1.Value = this.mostrarIngresoProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Informes.Mostrar_IngresoProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // mostrar_IngresoProductoTableAdapter
            // 
            this.mostrar_IngresoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrar_IngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrar_IngresoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Mostrar_IngresoProducto";
            this.Load += new System.EventHandler(this.Frm_Mostrar_IngresoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarIngresoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostrarIngresoProductoBindingSource;
        private Datos_Generales datos_Generales;
        private Datos_GeneralesTableAdapters.Mostrar_IngresoProductoTableAdapter mostrar_IngresoProductoTableAdapter;
    }
}