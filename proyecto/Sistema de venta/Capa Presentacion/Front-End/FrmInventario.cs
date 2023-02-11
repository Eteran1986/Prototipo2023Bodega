using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio; //Se agregaron
using Capa_Entidad; // Se agregaron
using static System.Net.Mime.MediaTypeNames;

namespace Capa_Presentacion
{
    public partial class FrmInventario : FormBase
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        public static decimal Total;// sumar los valores de mi inventario
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            SumarInventario();
            dataGridView1.Columns[0].Visible = false; //idInventario
            dataGridView1.Columns[1].Width = 150; //codigo del producto
            dataGridView1.Columns[2].Width = 300; //nombre del producto
            dataGridView1.Columns[3].Width = 150; //cantidad del producto
            dataGridView1.Columns[4].Width = 150; //costo unitario del producto
            dataGridView1.Columns[5].Width = 150; //precio de venta
            dataGridView1.Columns[6].Width = 150; //monto total
            dataGridView1.Columns[7].Width = 150; //Tipo del producto

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            procedimiento.AlternarColorFilaDataGridView(dataGridView1);

        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = procedimiento.CargarDatos("Inventarios");
            dataGridView1.ClearSelection();
        }

        private void SumarInventario()
        {
            Total = 0;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                Total += Convert.ToDecimal(Row.Cells[6].Value);
            }
            TxtMontoTotalinventario.Text = Total.ToString("N2");

        }

        public override void Buscar()
        {
            try
            {
                if (CboTipoBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Inventario_Nombre(Producto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado : " + ex.Message, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
