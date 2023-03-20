using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Dominio;

namespace Capa_Presentacion
{
    public partial class FrmUsuario : FormBase
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos=new CDo_Procedimientos();
        CDo_Usuario Accesos=new CDo_Usuario();
        CE_Usuario Acceso =new CE_Usuario();


        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            MostrarAcceso();
            dataGridView1.Columns[0].Visible= false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 150;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void MostrarAcceso()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Acceso");
            dataGridView1.ClearSelection();
        }
        private void AgUsu_UpdateEventHandler(object sender, FrmAgregarUsuario.UpdatedEventArgs args)
        {
            MostrarAcceso();
        }

        private void EdUsu_UpdateEventHandler(object sender, FrmEditarUsuario.UpdatedEventArgs args)
        {
            MostrarAcceso();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario AgregarUsuario = new FrmAgregarUsuario(this);
            AgregarUsuario.UpdatedEventHandler += AgUsu_UpdateEventHandler;
            AgregarUsuario.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count ==0)
            {
                MessageBox.Show("No hay registro para editar el usuario","Editar Usuario",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarUsuario EditarUsuario = new FrmEditarUsuario(this);
                        EditarUsuario.UpdatedEventHandler += EdUsu_UpdateEventHandler;
                        EditarUsuario.TxtID_Usuario.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarUsuario.TxtNombreUsu.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarUsuario.TxtApellidoUsu.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarUsuario.TxtUsuario.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarUsuario.TxtContrasena.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarUsuario.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No hay registro para editar el usuario"+ ex, "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (CboTipoBusqueda.Text == "Nombre")
                {
                    Acceso.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Accesos.Buscar_Adm_Nombre(Acceso);
                }
                else if (CboTipoBusqueda.Text == "Apellido")
                {
                    Acceso.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Accesos.Buscar_Adm_Apellido(Acceso);
                }
                else if (CboTipoBusqueda.Text == "Usuario")
                {
                    Acceso.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Accesos.Buscar_Admi_Usuario(Acceso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Compra no fue encontrado : " + ex.Message, "Buscar Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
