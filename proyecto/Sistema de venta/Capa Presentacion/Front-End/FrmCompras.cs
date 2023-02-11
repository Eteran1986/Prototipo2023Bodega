using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Entidad;
using CapaDatos;
using Capa_Presentacion.Informes;

namespace Capa_Presentacion
{
    public partial class FrmCompras : FormBase
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_IngresoProducto IngresoProductos = new CDo_IngresoProducto();
        CE_IngresoProducto IngresoProducto = new CE_IngresoProducto();

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargaDatos();
            dataGridView1.Columns[0].Visible = false;//id ingreso
            dataGridView1.Columns[1].Visible = false;//Nunemro de ingreso
            dataGridView1.Columns[2].Width = 100;//Nombre proveedor
            dataGridView1.Columns[3].Width = 180;//fecha de ingreso
            dataGridView1.Columns[4].Width = 150;//comprobante
            dataGridView1.Columns[5].Width = 150;//monto total
            dataGridView1.Columns[6].Width = 150;//estado

            //para centrar los texto de los titulos
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";

        }

        private void CargaDatos()
        {
            dataGridView1.DataSource = IngresoProductos.MostrarIngProd();
            dataGridView1.ClearSelection();
        }

        private void AgIn_UpdateEventHandler(object sender, FrmAgregarIngresoPro.UpdatedEventArgs args)
        {
            CargaDatos();
        }
        private void AnIn_UpdateEventHandler(object sender, FrmAnularIngresoProducto.UpdatedEventArgs args)
        {
            CargaDatos();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarIngresoPro AgregarProducto = new FrmAgregarIngresoPro(this);
            AgregarProducto.UpdatedEventHandler += AgIn_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                    if (dataGridView1.Rows.Count != 0)
                {
                    FrmAnularIngresoProducto AnularProducto = new FrmAnularIngresoProducto(this);
                    AnularProducto.UpdatedEventHandler += AnIn_UpdateEventHandler;
                    AnularProducto.TxtIdIngreso.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    AnularProducto.TxtIdProveedor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    AnularProducto.TxtNoIngreso.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    AnularProducto.TxtNomProveedor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    AnularProducto.DtpFechaIngreso.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    AnularProducto.TxtComprobante.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    AnularProducto.TxtTotalPagar.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    AnularProducto.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe se seleccionar un registro", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count !=0)
                {
                    Informes.FrmMostrar_IngresoProducto Mostrar = new Informes.FrmMostrar_IngresoProducto();
                    Mostrar.Id_Ingreso = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Ingreso"].Value.ToString());
                    Mostrar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe se seleccionar un registro" , "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo imprimir por este error: " + ex.Message, "Imprimir", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
