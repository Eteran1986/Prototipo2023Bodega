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

namespace Capa_Presentacion
{
    public partial class FrmAnularIngresoProducto : FormBase
    {
        public FrmAnularIngresoProducto(FrmCompras Compras)
        {
            InitializeComponent();
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

        protected void Actualizar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmAnularIngresoProducto_Load(object sender, EventArgs e)
        {
            
            MostrarDetalleIngreso();
            MejorarVista();
            Procedimientos.FormatoMoneda(TxtTotalPagar);
        }
        private void MejorarVista()
        {
            dataGridView1.Columns[0].Visible = false;//iddetalle
            dataGridView1.Columns[1].Visible = false;//idingreso
            dataGridView1.Columns[2].Visible = false;//idproducto

            dataGridView1.Columns[3].Width = 300;//nombre del producto
            dataGridView1.Columns[4].Width = 150;//cantidad
            dataGridView1.Columns[5].Width = 150;//costo unitario
            dataGridView1.Columns[6].Width = 150;//subtotal
            dataGridView1.Columns[7].Width = 150;//fechadecaducidad

            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void MostrarDetalleIngreso()
        {
            dataGridView1.DataSource = DetalleIngresos.MostrarIngresoProducto(Convert.ToInt32(TxtIdIngreso.Text));
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtIdIngreso.Text == "" || TxtNoIngreso.Text == "" || TxtIdProveedor.Text == "" ||
                    TxtNomProveedor.Text == "" || TxtComprobante.Text == "")
                {
                    MessageBox.Show("Debe de llenar todo los campos", "Anular Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult Resultados = MessageBox.Show("Estás seguro que quieres eliminar este registro", "Anular Ingreso Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    if (Resultados ==DialogResult.Yes)
                    {
                        Ingreso.ID_Ingreso = Convert.ToInt32(TxtIdIngreso.Text);
                        Ingreso.No_Ingreso = TxtNoIngreso.Text;
                        Ingreso.Id_Proveedor = Convert.ToInt32(TxtIdProveedor.Text);
                        Ingreso.Fecha_Ingreso = Convert.ToDateTime(DtpFechaIngreso.Text);
                        Ingreso.Comprobante = TxtComprobante.Text;
                        Ingreso.Monto_Total = Convert.ToDecimal(TxtTotalPagar.Text);
                        Ingreso.Estado = "Anular";


                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            DetalleIngreso.ID_Detalle = Convert.ToInt32(row.Cells[0].Value.ToString());
                            DetalleIngreso.Id_Ingreso = Convert.ToInt32(TxtIdIngreso.Text);
                            DetalleIngreso.Id_Producto = Convert.ToInt32(row.Cells[2].Value.ToString());
                            TxtNombreProducto.Text = Convert.ToString(row.Cells[3].Value.ToString());
                            DetalleIngreso.Cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
                            DetalleIngreso.Costo_Unitario = Convert.ToDecimal(row.Cells[5].Value.ToString());
                            DetalleIngreso.Sub_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());
                            DetalleIngreso.Fecha_caducidad = Convert.ToDateTime(row.Cells[7].Value.ToString());

                            DetalleIngresos.AnularDetalleingreso(DetalleIngreso);
                        }
                        Ingresos.AnularIngreso(Ingreso);
                        //MessageBox.Show("Se anularon los productos correctamente ", "Anular Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Actualizar();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Anular los Producto por: " + ex.Message, "Anular Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
