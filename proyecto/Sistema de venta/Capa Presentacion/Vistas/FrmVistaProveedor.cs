using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Entidad;


namespace Capa_Presentacion
{
    public partial class FrmVistaProveedor : FormBase
    {
        public FrmVistaProveedor()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedmientos = new CDo_Procedimientos();
        CDo_Proveedores Proveedores = new CDo_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();
        private void FrmVistaProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible = false; //idproveedor
            dataGridView1.Columns[1].Width = 120; //codigo del proveedor
            dataGridView1.Columns[2].Width = 180; //nombre del proveedor
            dataGridView1.Columns[3].Width = 130; //ruc del proveedor
            dataGridView1.Columns[4].Width = 350; //direccion del proveedor
            dataGridView1.Columns[5].Width = 120; //telefono del proveedor
            dataGridView1.Columns[6].Width = 240; //email del proveedor

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedmientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedmientos.CargarDatos("Proveedores");
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if (CboTipoBusqueda.Text == "Codigo")
                {
                    Proveedor.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Prov_Codigo(Proveedor);
                }
                else if (CboTipoBusqueda.Text == "Nombre")
                {
                    Proveedor.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Prov_Nombre(Proveedor);
                }
                else if (CboTipoBusqueda.Text == "RUC")
                {
                    Proveedor.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Prov_RUC(Proveedor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Compra no fue encontrado : " + ex.Message, "Buscar Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
