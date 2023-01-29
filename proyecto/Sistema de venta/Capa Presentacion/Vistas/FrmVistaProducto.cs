using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Se agregaron
using Capa_Dominio; //Se agregaron
using Capa_Entidad; // Se agregaron

namespace Capa_Presentacion
{
    public partial class FrmVistaProducto : FormBase
    {
        public FrmVistaProducto()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();


        private void FrmVistaProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible = false; //idproducto
            dataGridView1.Columns[1].Width = 130; //codigo del producto
            dataGridView1.Columns[2].Width = 260; //nombre del producto
            dataGridView1.Columns[3].Width = 300; //descripcion del producto
            dataGridView1.Columns[4].Width = 150; //presentacion del producto
            dataGridView1.Columns[5].Width = 140; //costo unitario del producto
            dataGridView1.Columns[6].Width = 140; //precio del producto
            dataGridView1.Columns[7].Width = 150; //Tipo del producto

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
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
