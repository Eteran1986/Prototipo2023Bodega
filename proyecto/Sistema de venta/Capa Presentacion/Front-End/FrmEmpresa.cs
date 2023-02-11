using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;//se gregaron
using Capa_Entidad;//se gregaron
using System.IO;//se gregaron para el logo


namespace Capa_Presentacion
{
    public partial class FrmEmpresa : FormBase
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        CDo_Empresas Empresas = new CDo_Empresas();
        CE_Empresas Empresa = new CE_Empresas();
        //perimte las carpetas agregar nuestras imagenes en empresas
        public OpenFileDialog examinar = new OpenFileDialog();

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible = false; //idempresa
            dataGridView1.Columns[1].Width = 180; //nombre del empresa
            dataGridView1.Columns[2].Width = 180; //ruc del empresa
            dataGridView1.Columns[3].Width = 250; //direccion del empresa
            dataGridView1.Columns[4].Width = 120; //telefono del empresa
            dataGridView1.Columns[5].Width = 240; //email del empresa
            dataGridView1.Columns[6].Visible = false; //logo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            procedimiento.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = procedimiento.CargarDatos("Empresas");
        }
        private void AgUpdateEventHandler(object sender, FrmAgregarEmpresa.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void EdUpdateEventHandler(object sender, FrmEditarEmpresa.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarImagen();

        }

        private void CargarImagen()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                PtbLogo.Image = Properties.Resources.sinlogo;
            }
            else
            {
                PtbLogo.BackgroundImage = null;
                byte[] i = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                MemoryStream ms = new MemoryStream(i);
                PtbLogo.Image = Image.FromStream(ms);
                PtbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CargarImagen();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpresa AgregarEmpresa = new FrmAgregarEmpresa(this);
            AgregarEmpresa.UpdatedEventHandler += AgUpdateEventHandler;
            AgregarEmpresa.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro que editar", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try //validación de seleccion de empresa para editarlo
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarEmpresa EditarEmpresa = new FrmEditarEmpresa(this);
                        EditarEmpresa.UpdatedEventHandler += EdUpdateEventHandler;
                        EditarEmpresa.TxtIDEmpresa.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarEmpresa.TxtNomEmpresa.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarEmpresa.TxtRUCEmpresa.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarEmpresa.TxtDirEmpresa.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarEmpresa.MtxtTelefonoEmpresa.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarEmpresa.TxtEmailEmpresa.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                        PtbLogo.BackgroundImage = null;
                        byte[] i = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                        MemoryStream ms = new MemoryStream(i);
                        EditarEmpresa.PtbLogoAgregar.Image = Image.FromStream(ms);
                        PtbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                        EditarEmpresa.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar una empresa para editar :" + ex, "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("No hay registros para eliminar", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        DialogResult Resultados = MessageBox.Show("Estas seguro de eliminar este Empresa", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Empresa.ID_Empresa = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Empresas.EliminarEmpresa(Empresa);

                            MessageBox.Show("La Empresa fue eliminado con éxito", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar" +ex, "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
