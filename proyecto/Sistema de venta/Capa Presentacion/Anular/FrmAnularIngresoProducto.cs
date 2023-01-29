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
    }
}
