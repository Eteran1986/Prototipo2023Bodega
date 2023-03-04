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
    public partial class FrmVistaCliente : FormBase
    {
        public FrmVistaCliente()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Clientes Clientes = new CDo_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

        private void FrmVistaCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible = false; //idclientes
            dataGridView1.Columns[1].Width = 120; //codigo del clientes
            dataGridView1.Columns[2].Width = 180; //nombre del clientes
            dataGridView1.Columns[3].Width = 130; //ruc del clientes
            dataGridView1.Columns[4].Width = 250; //direccion del clientes
            dataGridView1.Columns[5].Width = 120; //telefono del clientes
            dataGridView1.Columns[6].Width = 200; //email del clientes
            dataGridView1.Columns[7].Width = 120; //estado del clientes

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Clientes");
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

        public override void Buscar()
        {
            try
            {
                if (CboTipoBusqueda.Text == "Código")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Codigo(Cliente);
                }
                else if (CboTipoBusqueda.Text == "RUC")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_RUC(Cliente);
                }
                else if (CboTipoBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no fue encontrado : " + ex.Message, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
