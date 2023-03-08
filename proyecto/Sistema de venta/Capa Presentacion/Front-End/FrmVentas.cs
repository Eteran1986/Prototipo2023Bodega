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
    public partial class FrmVentas : FormBase
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Ventas Ventas = new CDo_Ventas();
        CE_Ventas Venta = new CE_Ventas();
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible= false;
            dataGridView1.Columns[1].Width = 100; //No. Factura
            dataGridView1.Columns[2].Width = 150; //Nombre
            dataGridView1.Columns[3].Width = 150; //fechaventa
            dataGridView1.Columns[4].Width = 100; //comprobante
            dataGridView1.Columns[5].Width = 80;//subtotal
            dataGridView1.Columns[6].Width = 80;//descuento
            dataGridView1.Columns[7].Width = 80;//iva
            dataGridView1.Columns[8].Width = 150;//montototal
            dataGridView1.Columns[9].Width = 80;//usuario

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Ventas.MostrarVentas();
            dataGridView1.ClearSelection();
        }

        private void AgVent_UpdateEventHandler(Object sender, FrmAgregarVentas.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarVentas Agregarventas = new FrmAgregarVentas(this);
            Agregarventas.UpdatedEventHandler += AgVent_UpdateEventHandler;
            Agregarventas.Show();
        }
    }
}
