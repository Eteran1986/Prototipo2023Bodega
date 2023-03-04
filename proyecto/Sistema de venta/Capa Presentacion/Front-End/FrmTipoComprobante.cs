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
    public partial class FrmTipoComprobante : FormBase
    {
        public FrmTipoComprobante()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();

        private void FrmTipoComprobante_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible= false;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource= Procedimientos.CargarDatos("TipoComprobante");
            dataGridView1.ClearSelection();
        }

        private void AgCom_UpdateEventHandler(object sender, FrmAgregarComponentes.UpdatedEventArgs args)
        {
            CargarDatos();
        }
        private void EdCom_UpdateEventHandler(object sender, FrmEditarComprobante.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarComponentes AgregarComponente = new FrmAgregarComponentes(this);
            AgregarComponente.UpdatedEventHandler += AgCom_UpdateEventHandler;
            AgregarComponente.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro que editar", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarComprobante editarComrpobante = new FrmEditarComprobante(this);
                        editarComrpobante.UpdatedEventHandler += EdCom_UpdateEventHandler;
                        editarComrpobante.Txtidcompro.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarComrpobante.TxtNombreComprobante.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarComrpobante.TxtTipoComprobante.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarComrpobante.TxtCorrelativo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarComrpobante.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un comprobante para editar", "Editar Comprobante" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
