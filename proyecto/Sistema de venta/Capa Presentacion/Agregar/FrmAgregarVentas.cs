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
using Capa_Entidad.Cache;

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
        CDo_TipoCompro TipoComprobantes = new CDo_TipoCompro();
        CE_Tipo_Comprobante TipoComprobante = new CE_Tipo_Comprobante();
        

        public delegate void UpdateDelegate(object sender, UpdatedEventArgs args);
        public event UpdateDelegate UpdatedEventHandler;

        //variable
        public double ValorIVA = 12; //IVA cambios
        
        public static double Importe = 0, ImporteNeto = 0, Descuento1 = 0, IVA1 = 0, MontoTotal = 0, Porcentaje = 0;
        
        public static int ContFila = 0;
        public static decimal Total1=0, Total2=0, Total3=0, Total4=0;

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
            MejorarVista();
        }

        private void GenerarCorrelativos()
        {
            TxtNoFactura.Text = "FAC"+Procedimientos.GenerarCodigo("Ventas");
            TxtIdVenta.Text = Procedimientos.GenerarCodigoID("Ventas");
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

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            if(TxtDescuento.Text==string.Empty)
            {
                return;
            }
            else
            {
                CalcularIVA();
            }
        }

        private void ProductoRepet()
        {
            dataGridView1.Rows.Add(TxtIdProducto.Text, TxtNombreProducto.Text, txtPresentacion.Text, TxtCantidad.Text,
                                                   TxtPrecioVenta.Text, ImporteNeto.ToString("N2"), Descuento1.ToString("N2"),
                                                   TxtIvaProducto.Text, MontoTotal.ToString("N2"));
            dataGridView1.ClearSelection();
            LimpiarDetalle();
            BtnBuscarProducto.Focus();
            ContFila++;
        }

        private void BtnAgregarVentas_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Convert.ToInt32(TxtCantidad.Text) > Convert.ToInt32(TxtStock.Text))
                {
                    MessageBox.Show("La cantidad es mayor al stock", "Agregar Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCantidad.Focus();
                    TxtCantidad.Text = string.Empty;
                }
                else
                {
                    TxtDescuento.Focus();
                    e.Handled = true;
                }
            }
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.Focus();
                e.Handled = true;
            }
        }

        private void MejorarVista()
        {
            dataGridView1.Columns[0].Visible = false;//idproducto
            dataGridView1.Columns[1].Width = 200;//nombre del producto
            dataGridView1.Columns[2].Width = 100;//presentacion
            dataGridView1.Columns[3].Width = 80;//cantidad
            dataGridView1.Columns[4].Width = 80;//precio de venta
            dataGridView1.Columns[5].Width = 80;//subtotal
            dataGridView1.Columns[6].Width = 80;//descuento
            dataGridView1.Columns[7].Width = 80;//iva
            dataGridView1.Columns[8].Width = 80;//total

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##,0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##,0.00";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "#,##,0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void BtnEliminarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContFila > 0)
                {
                    Total1 = Total1 - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
                    TxtSubTotal.Text = Total1.ToString("N2");
                    Total2 = Total2 - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value);
                    TxtDescuentoTotal.Text = Total2.ToString("N2");
                    Total3 = Total3 - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
                    TxtTotalIva.Text = Total3.ToString("N2");
                    Total4 = Total4 - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value);
                    TxtTotalPagar.Text = Total4.ToString("N2");

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ContFila--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Producto para eliminar en Ventas" + ex, "Eliminar Producto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AgregarDetalle()
        {
            try
            {
                if(Convert.ToInt32(TxtCantidad.Text)==0)
                {
                    MessageBox.Show("No existe el Producto", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if(TxtIdProducto.Text==string.Empty || TxtCodProducto.Text == string.Empty || TxtNombreProducto.Text == string.Empty ||
                        TxtTipoCargo.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtStock.Text == string.Empty ||
                        TxtPrecioVenta.Text == string.Empty || TxtDescuento.Text == string.Empty || TxtIvaProducto.Text == string.Empty ||
                        txtPresentacion.Text == string.Empty)
                    {
                        MessageBox.Show("Debe de completar todo los campos", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool Existe = false;
                        int NFila = 0;
                        if(ContFila ==0)
                        {
                            ProductoRepet();
                        }
                        else
                        {
                            foreach(DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[0].Value.ToString()==TxtIdProducto.Text)
                                {
                                    Existe=true;
                                }
                            }
                            if (Existe==true )
                            {
                                dataGridView1.Rows[NFila].Cells[3].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[NFila].Cells[3].Value);
                                dataGridView1.Rows[NFila].Cells[5].Value = ImporteNeto + Convert.ToDouble(dataGridView1.Rows[NFila].Cells[5].Value);
                                dataGridView1.Rows[NFila].Cells[6].Value = Descuento1 + Convert.ToDouble(dataGridView1.Rows[NFila].Cells[6].Value);
                                dataGridView1.Rows[NFila].Cells[7].Value = Convert.ToDouble(TxtIvaProducto.Text) + Convert.ToDouble(dataGridView1.Rows[NFila].Cells[7].Value);
                                dataGridView1.Rows[NFila].Cells[8].Value = MontoTotal + Convert.ToDouble(dataGridView1.Rows[NFila].Cells[8].Value);
                                LimpiarDetalle();
                            }
                            else
                            {
                                ProductoRepet();
                            }
                        }
                    }
                    Total1 = 0; Total2 = 0;Total3= 0; Total4 = 0;
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                        Total2 += Convert.ToDecimal(row1.Cells[6].Value);
                        Total3 += Convert.ToDecimal(row1.Cells[7].Value);
                        Total4 += Convert.ToDecimal(row1.Cells[8].Value);
                    }
                    TxtSubTotal.Text=Total1.ToString("N2");
                    TxtDescuentoTotal.Text = Total2.ToString("N2");
                    TxtTotalIva.Text = Total3.ToString("N2");
                    TxtTotalPagar.Text = Total4.ToString("N2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Producto" + ex, "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpiarDetalle()
        {
            TxtIdProducto.Text= string.Empty;
            TxtCodProducto.Text = string.Empty;
            TxtNombreProducto.Text = string.Empty;
            TxtTipoCargo.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtStock.Text = string.Empty;
            TxtPrecioVenta.Text = string.Empty;
            TxtDescuento.Text = string.Empty;
            TxtIvaProducto.Text = string.Empty;
            txtPresentacion.Text = string.Empty;
            BtnBuscarProducto.Focus();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LimpiarCampo()
        {
            TxtIdCliente.Text = string.Empty;
            TxtNoFactura.Text = string.Empty;
            TxtNomCliente.Text= string.Empty;
            TxtNoCOmprobnte.Text = string.Empty;
            CboTipoCOmprobante.Text = string.Empty; 
            dataGridView1.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try
            {
                if (TxtNoFactura.Text == string.Empty || TxtNomCliente.Text == string.Empty || CboTipoCOmprobante.Text == string.Empty ||
                    TxtNoCOmprobnte.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los Campos por favor", "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Venta.No_Factura = TxtNoFactura.Text;
                    Venta.ID_Cliente = Convert.ToInt32(TxtIdCliente.Text);
                    Venta.Fecha_Venta = Convert.ToDateTime(DateTime.Now);
                    Venta.Comprobante = TxtNoCOmprobnte.Text;
                    Venta.Sub_Total = Convert.ToDecimal(TxtSubTotal.Text);
                    Venta.Descuento = Convert.ToDecimal(TxtDescuentoTotal.Text);
                    Venta.IVA = Convert.ToDecimal(TxtTotalIva.Text);
                    Venta.Monto_Total = Convert.ToDecimal(TxtTotalPagar.Text);
                    Venta.Estado = "Emitido";
                    if (Venta.ID_Usuario == 0)
                    {
                        Venta.ID_Usuario = 1;
                    }
                    Venta.ID_Usuario = Convert.ToInt32(InformacionUsuario.IDUsuario);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DetalleVenta.ID_Venta = Convert.ToInt32(TxtIdVenta.Text);
                        DetalleVenta.ID_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DetalleVenta.Presentacion = Convert.ToString(row.Cells[2].Value.ToString());
                        DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                        DetalleVenta.Precio_Venta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[5].Value.ToString());
                        DetalleVenta.Descuento = Convert.ToDecimal(row.Cells[6].Value.ToString());
                        DetalleVenta.IVA = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        DetalleVenta.Monto_Total = Convert.ToDecimal(row.Cells[8].Value.ToString());

                        DetalleVentas.AgregarDetalleVentas(DetalleVenta);
                    }

                    Ventas.AgregarVentas(Venta);
                    ActualizarComprobante();
                    MessageBox.Show("Las venta de los Productos fue agregada correctamente", "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    TxtSubTotal.Text = "0.00";
                    TxtDescuentoTotal.Text = "0.00";
                    TxtTotalIva.Text = "0.00";
                    TxtTotalPagar.Text = "0.00";
                    Agregar();
                    LimpiarDetalle();
                    LimpiarCampo();
                    GenerarCorrelativos();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta de Producto no fue agregada por: " + ex.Message, "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void ActualizarComprobante()
        {
            try
            {
                TipoComprobante.ID_Comprobante = Convert.ToInt32(CboTipoCOmprobante.SelectedValue.ToString());
                TipoComprobante.Correlativo = Convert.ToInt32(Procedimientos.GenerarCodigoFact(CboTipoCOmprobante.SelectedValue.ToString()));

                TipoComprobantes.ActComprobante(TipoComprobante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Comprobante no fue Editado por :" + ex.Message, "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Importe = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text);
                    Descuento1 = Importe * (Convert.ToDouble(TxtDescuento.Text)/100);
                    ImporteNeto = Importe - Convert.ToDouble(Descuento1.ToString("N2"));
                    IVA1 = ImporteNeto * (ValorIVA/100);
                    TxtIvaProducto.Text = IVA1.ToString("N2");
                    MontoTotal = Convert.ToDouble(ImporteNeto+Convert.ToDouble(TxtIvaProducto.Text));
                    Porcentaje = Descuento1;
                }
                else if (TxtTipoCargo.Text == "SIN IVA" && TxtCantidad.Text != string.Empty)
                {
                    Importe = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text); ;
                    Descuento1 = Importe * (Convert.ToDouble(TxtDescuento.Text) / 100);
                    ImporteNeto = Importe - Convert.ToDouble(Descuento1.ToString("N2"));
                    TxtIvaProducto.Text = "0.00";
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
