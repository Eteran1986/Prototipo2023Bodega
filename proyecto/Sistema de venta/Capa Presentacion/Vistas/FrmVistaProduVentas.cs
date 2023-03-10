using Capa_Dominio;
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
    public partial class FrmVistaProduVentas : FormBase
    {
        public FrmVistaProduVentas()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Ventas Ventas =new CDo_Ventas();


        private void FrmVistaProduVentas_Load(object sender, EventArgs e)
        {
            MostrarPorducVentas();
            dataGridView1.Columns[0].Visible = false; //idproducto
            
            dataGridView1.Columns[1].Width = 130; //codigo del producto
            dataGridView1.Columns[2].Width = 300; //nombre del producto
            dataGridView1.Columns[3].Width = 130; //tipo de cargo
            dataGridView1.Columns[4].Width = 100; //precio venta
            dataGridView1.Columns[5].Width = 100; //cantidad
            dataGridView1.Columns[6].Width = 140; //presentacion

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,##0.00";

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void MostrarPorducVentas()
        {
            dataGridView1.DataSource = Ventas.Mostrar_ProduVentas();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
