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
    public partial class FrmClientes : FormBase
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        CDo_Clientes Clientes = new CDo_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

        private void FrmClientes_Load(object sender, EventArgs e)
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

            procedimiento.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = procedimiento.CargarDatos("Clientes");
            dataGridView1.ClearSelection();
        }

        private void AgCli_UpdateEventHandler(object sender, FrmAgregarCliente.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void EdCli_UpdateEventHandler(object sender, FrmEditarCliente.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente agregarProducto = new FrmAgregarCliente(this);
            agregarProducto.UpdatedEventHandler += AgCli_UpdateEventHandler;
            agregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro que editar", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try //validación de seleccion de producto para editarlo
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarCliente EditarCliente = new FrmEditarCliente(this);
                        EditarCliente.UpdatedEventHandler += EdCli_UpdateEventHandler;
                        EditarCliente.TextID_Clientes.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarCliente.TxtCodCliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarCliente.TxtNombreCliente.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarCliente.TxtRUCCliente.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarCliente.TxtDirCliente.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarCliente.MtxtTelefonoCliente.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarCliente.TxtEmailCliente.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarCliente.CboEstadoCliente.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarCliente.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un cliente para editar", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public override void Eliminar()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Estas seguro de eliminar este cliente", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Cliente.ID_Cliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Clientes.EliminarCliente(Cliente);

                            MessageBox.Show("El cliente fue eliminado con éxito", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                if (CboTipoBusqueda.Text == "Código")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Codigo(Cliente);
                }
                else if (CboTipoBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }
                else if (CboTipoBusqueda.Text == "RUC")
                {
                    Cliente.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_RUC(Cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente no fue encontrado : " + ex.Message, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
