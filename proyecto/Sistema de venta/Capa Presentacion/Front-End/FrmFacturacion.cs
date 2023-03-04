using Capa_Dominio;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmFacturacion : FormBase
    {
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Ventas Ventas = new CDo_Ventas();
        CE_Ventas Venta = new CE_Ventas();
        CDo_DetalleVentas DetalleVentas = new CDo_DetalleVentas();
        CE_DetalleVentas DetalleVenta = new CE_DetalleVentas();

        public delegate void UpdateDelegate(object sender, UpdatedEventArgs args);
        public event UpdateDelegate UpdatedEventHandler;

        public class UpdatedEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void GenerarCorrelativos()
        {
            TxtNoFactura.Text = "FAC" + Procedimientos.GenerarCodigo("Ventas");
        }

        private void LlenarComboBox()
        {
            //Procedimientos.LlenarComboBox("TipoComprobante", "Nombre_Comprobante", CboTipoCOmprobante);
            CboTipoCOmprobante.DataSource = Procedimientos.CargarDatos("TipoComprobante");
            CboTipoCOmprobante.ValueMember = "ID_Comprobante";
            CboTipoCOmprobante.DisplayMember = "Nombre_Comprobante";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            GenerarCorrelativos();
            LlenarComboBox();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaCliente VistaCliente = new FrmVistaCliente();
            VistaCliente.ShowDialog();
            try
            {
                if (VistaCliente.DialogResult == DialogResult.OK)
                {
                    TxtIdCliente.Text = VistaCliente.dataGridView1.Rows[VistaCliente.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNomCliente.Text = VistaCliente.dataGridView1.Rows[VistaCliente.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    CboTipoCOmprobante.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Cliente en la vista" + ex, "Seleccionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GenerarComprobante()
        {
            string Compro = CboTipoCOmprobante.Text;
            switch (Compro)
            {
                case "Facturas":
                    TxtNoCOmprobnte.Text = "F" + Procedimientos.GenerarCodigoFact(CboTipoCOmprobante.SelectedValue.ToString());
                    break;

                case "Nota de Venta":
                    TxtNoCOmprobnte.Text = "NV" + Procedimientos.GenerarCodigoFact(CboTipoCOmprobante.SelectedValue.ToString());
                    break;

                case "Consumidor Final":
                    TxtNoCOmprobnte.Text = "CF" + Procedimientos.GenerarCodigoFact(CboTipoCOmprobante.SelectedValue.ToString());
                    break;
            }
        }

        private void CboTipoCOmprobante_Leave(object sender, EventArgs e)
        {
            try
            {
                GenerarComprobante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El codigo del comprobante no se ha generado por: " + ex.Message, "Generar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
