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
using static System.Net.WebRequestMethods;

namespace Capa_Presentacion
{
    public partial class FrmAgregarIngresoPro : FormBase
    {
        
        public FrmAgregarIngresoPro(FrmCompras Compras)
        {
            InitializeComponent();
            DtpFechaCaducidad.MinDate = DateTime.Now.AddDays(5);// Se agrego 5 dia por la empresa
        }
        
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_IngresoProducto Ingresos = new CDo_IngresoProducto();
        CE_IngresoProducto Ingreso = new CE_IngresoProducto();
        CDo_DetalleIngreso DetalleIngresos = new CDo_DetalleIngreso();
        CE_DetalleIngreso DetalleIngreso = new CE_DetalleIngreso();

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

        private void FrmAgregarIngresoPro_Load(object sender, EventArgs e)
        {
            MejorarVista();
            TxtTotalPagar.Text= "0.00";
            Correlativo();
        }

        private void MejorarVista()
        {
            dataGridView1.Columns[0].Visible = false;//idproducto
            dataGridView1.Columns[1].Width = 350;//nombre del producto
            dataGridView1.Columns[2].Width = 150;//cantidad
            dataGridView1.Columns[3].Width = 150;//costo unitario
            dataGridView1.Columns[4].Width = 150;//subtotal
            dataGridView1.Columns[5].Width = 150;//fechacaducidad

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void Correlativo()
        {
            TxtIdIngreso.Text = Procedimientos.GenerarCodigoID("Ingreso_Producto");
            TxtNoIngreso.Text = "ING" + Procedimientos.GenerarCodigo("Ingreso_Producto");
            TxtIdDetalleIngreso.Text = Procedimientos.GenerarCodigoID("Detalle_Producto");
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor VistaProveedor = new FrmVistaProveedor();
            VistaProveedor.ShowDialog();
            try
            {
                if(VistaProveedor.DialogResult==DialogResult.OK)
                {
                    TxtIdProveedor.Text = VistaProveedor.dataGridView1.Rows[VistaProveedor.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNomProveedor.Text = VistaProveedor.dataGridView1.Rows[VistaProveedor.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtComprobante.Focus();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Debe seleccionar un Proveedor en la vista" + ex,"Seleccionar Proveedor",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        public static int ContFila = 0;
        public static decimal Total;
        public static decimal SubTotal;
        private void AgregarDetalle()
        {
            SubTotal = 0;
            try
            {
                if (TxtIdProducto.Text == "" || TxtNombreProducto.Text == "" || TxtCantidad.Text == ""
                || TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("Debe de completar todo los campos", "Agregar Detalle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    bool Existe = false;
                    int No_Fila = 0;

                    if (ContFila == 0)
                    {
                        SubTotales();
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == TxtIdProducto.Text)
                            {
                                Existe = true;
                                No_Fila = row.Index;
                            }
                        }

                        if (Existe == true)
                        {
                            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCostoUnitario.Text);
                            dataGridView1.Rows[No_Fila].Cells[2].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[No_Fila].Cells[2].Value.ToString());
                            dataGridView1.Rows[No_Fila].Cells[4].Value = (SubTotal + Convert.ToDecimal(dataGridView1.Rows[No_Fila].Cells[4].Value)).ToString("N2");
                            LimpiarDetalle();
                        }
                        else
                        {
                            SubTotales();
                        }
                    }
                    Total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[4].Value);
                    }
                    TxtTotalPagar.Text = Total.ToString("N2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue agregado" +ex,"Agregar Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }   
        
        private void LimpiarDetalle()
        {
            TxtIdProducto.Text= string.Empty;
            TxtCodProducto.Text = string.Empty;
            TxtNombreProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtCostoUnitario.Text = string.Empty;
            TxtCodProducto.Focus();
        }

        private void LimpiarCampos()
        {
            TxtIdIngreso.Text = string.Empty;
            TxtComprobante.Text = string.Empty;
            TxtNomProveedor.Text = string.Empty;
            TxtNoIngreso.Text = string.Empty;
            TxtIdProveedor.Text= string.Empty;
            dataGridView1.Rows.Clear();
        }
        private void SubTotales()
        {
            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCostoUnitario.Text);
            dataGridView1.Rows.Add(TxtIdProducto.Text, TxtNombreProducto.Text, TxtCantidad.Text, TxtCostoUnitario.Text, SubTotal.ToString("N2"), Convert.ToDateTime(DtpFechaCaducidad.Text));
            LimpiarDetalle();
            BtnAgregarProducto.Focus();
            ContFila++;
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmVistaProducto VistaProducto = new FrmVistaProducto();
            VistaProducto.ShowDialog();
            try
            {
                if (VistaProducto.DialogResult == DialogResult.OK)
                {
                    TxtIdProducto.Text = VistaProducto.dataGridView1.Rows[VistaProducto.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtCodProducto.Text = VistaProducto.dataGridView1.Rows[VistaProducto.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtNombreProducto.Text = VistaProducto.dataGridView1.Rows[VistaProducto.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TxtCostoUnitario.Text = VistaProducto.dataGridView1.Rows[VistaProducto.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                    TxtCantidad.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Producto en la vista" + ex, "Seleccionar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContFila >0)
                {
                    Total = Total - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                    TxtTotalPagar.Text = Total.ToString("N2");

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ContFila--;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Producto para eliminar" + ex, "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void TxtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                BtnBuscarProducto.Focus();
                e.Handled= true;
            }
        }
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnAgregarProducto.Focus();
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if (TxtIdIngreso.Text == "" || TxtNoIngreso.Text == "" || TxtIdProveedor.Text == "" ||
                    TxtNomProveedor.Text == "" || TxtComprobante.Text == "")
                {
                    MessageBox.Show("Debe de llenar todo los campos", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Ingreso.No_Ingreso = TxtNoIngreso.Text;
                    Ingreso.Id_Proveedor = Convert.ToInt32(TxtIdProveedor.Text);
                    Ingreso.Fecha_Ingreso = Convert.ToDateTime(DtpFechaIngreso.Text);
                    Ingreso.Comprobante = TxtComprobante.Text;
                    Ingreso.Monto_Total = Convert.ToDecimal(TxtTotalPagar.Text);
                    Ingreso.Estado = "Emitir";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DetalleIngreso.Id_Ingreso = Convert.ToInt32(TxtIdIngreso.Text);
                        DetalleIngreso.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        TxtNombreProducto.Text = Convert.ToString(row.Cells[1].Value.ToString());
                        DetalleIngreso.Cantidad = Convert.ToInt32(row.Cells[2].Value.ToString());
                        DetalleIngreso.Costo_Unitario = Convert.ToDecimal(row.Cells[3].Value.ToString());
                        DetalleIngreso.Sub_Total = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        DetalleIngreso.Fecha_caducidad = Convert.ToDateTime(row.Cells[5].Value.ToString());

                        DetalleIngresos.AgregarDetalleIngreso(DetalleIngreso);
                    }
                    Ingresos.AgregarIngreso(Ingreso);//Ingreso compras
                    MessageBox.Show("Se ingresaron los productos correctamente ", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    TxtIdDetalleIngreso.Text= " ";
                    TxtTotalPagar.Text = "0.00";
                    Agregar();
                    LimpiarDetalle();
                    LimpiarCampos();
                    Correlativo();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El ingreso de Producto no fue agregado por: " + ex.Message, "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void DtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaIngreso.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
