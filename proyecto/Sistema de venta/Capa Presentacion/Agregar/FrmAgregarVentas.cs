using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//se agrego
using Capa_Dominio;//se agrego
using Capa_Entidad;//se agrego
using CapaDatos;//se agrego
using Capa_Presentacion;

namespace Capa_Presentacion
{
    public partial class FrmAgregarVentas : FormBase
    {
        public FrmAgregarVentas(FrmVentas Ventas)
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

        //variable
        public int ValorIVA = 12;
        public static double Importe = 0, ImporteNeto = 0, Descuento1 = 0, IVA1 = 0, MontoTotal = 0, Porcentaje = 0;


        public class UpdatedEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }
        private void FrmAgregarVentas_Load(object sender, EventArgs e)
        {
            TxtValorIva.Text = ValorIVA.ToString() + "%";
            GenerarCorrelativos();
            LlenarComboBox();
        }

        private void GenerarCorrelativos()
        {
            TxtNoFactura.Text = "FAC"+Procedimientos.GenerarCodigo("Ventas");
        }

        private void LlenarComboBox()
        {
            CboTipoCOmprobante.DataSource = Procedimientos.CargarDatos("TipoComprobante");
            CboTipoCOmprobante.ValueMember = "ID_Comprobante";
            CboTipoCOmprobante.DisplayMember = "Nombre_Comprobante";
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmVistaProduVentas VistaProduVentas = new FrmVistaProduVentas();
            VistaProduVentas.ShowDialog();
            try
            {
                if (VistaProduVentas.DialogResult == DialogResult.OK)
                {
                    TxtIdProducto.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtCodProducto.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtNombreProducto.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtTipoCargo.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TxtPrecioVenta.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    TxtStock.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    txtPresentacion.Text = VistaProduVentas.dataGridView1.Rows[VistaProduVentas.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                    TxtCantidad.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Producto en la vista" + ex, "Seleccionar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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

        private void CalcularIVA()
        {
            try
            {
                if(TxtTipoCargo.Text == "IVA"&& TxtCantidad.Text != string.Empty)
                {
                    Importe = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text); ;
                    Descuento1 = Importe * Convert.ToDouble(TxtDescuento.Text);
                    ImporteNeto = Importe - Convert.ToDouble(Descuento1.ToString("N2"));
                    IVA1 = ImporteNeto * (ValorIVA / 100);
                    TxtIvaProducto.Text = IVA1.ToString("N2");
                    MontoTotal = Convert.ToDouble(ImporteNeto.ToString("N2")+Convert.ToDouble(TxtIvaProducto.Text));
                    Porcentaje = Descuento1;
                }
                else if (TxtTipoCargo.Text == "SIN IVA" && TxtCantidad.Text != string.Empty)
                {
                    Importe = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text); ;
                    Descuento1 = Importe * Convert.ToDouble(TxtDescuento.Text);
                    ImporteNeto = Importe - Convert.ToDouble(Descuento1.ToString("N2"));
                    TxtIvaProducto.Text = "0";
                    MontoTotal = ImporteNeto;
                    Porcentaje = Descuento1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error calcular el IVA" + ex, "Calcular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GenerarComprobante()
        {
            string Compro = CboTipoCOmprobante.Text;
            switch ( Compro )
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
