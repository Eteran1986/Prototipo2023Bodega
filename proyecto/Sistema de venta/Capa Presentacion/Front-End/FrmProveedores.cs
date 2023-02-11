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
    public partial class FrmProveedores : FormBase
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        CDo_Proveedores Proveedores = new CDo_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();

        private void FrmProveedores_Load(object sender, EventArgs e)
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

            procedimiento.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = procedimiento.CargarDatos("Proveedores");
            dataGridView1.ClearSelection();
        }

        private void EdProv_UpdateEventHandler(object sender, FrmEditarProveedor.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void AgProv_UpdateEventHandler(object sender, FrmAgregarProveedor.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor AgregarProveedor = new FrmAgregarProveedor(this);
            AgregarProveedor.UpdatedEventHandler += AgProv_UpdateEventHandler;
            AgregarProveedor.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro que editar", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarProveedor EditarProveeedor = new FrmEditarProveedor(this);
                        EditarProveeedor.UpdatedEventHandler += EdProv_UpdateEventHandler;
                        EditarProveeedor.TextID_Proveedores.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProveeedor.TxtCodProveedor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProveeedor.TxtNombreProveedor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProveeedor.TxtRUCProveedor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProveeedor.TxtDirProveedor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProveeedor.MtxtTelefondoProveedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProveeedor.TxtEmailProveedor.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProveeedor.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un proveedor para editar"+ex.Message, "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("No hay registros para eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        DialogResult Resultados = MessageBox.Show("Estas seguro de eliminar este proveedor", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Proveedor.ID_Proveedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            
                            Proveedores.EliminarProveedor(Proveedor);

                            MessageBox.Show("El proveedor fue eliminado con éxito", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("El Proveedor no fue encontrado : " + ex.Message, "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
