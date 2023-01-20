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
        // 
        //public OpenFileDialog examinar = new OpenFileDialog();



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
            dataGridView1.ClearSelection();
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
                MemoryStream ms = new MemoryStream();
                PtbLogo.Image = Image.FromStream(ms);
                PtbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CargarImagen();
        }
    }
}
