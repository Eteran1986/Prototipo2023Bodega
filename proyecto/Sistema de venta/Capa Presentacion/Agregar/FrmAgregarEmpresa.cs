using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio; //se agregaron
using Capa_Entidad; // se agregaron
using System.IO; // Se agregaron


namespace Capa_Presentacion
{
    public partial class FrmAgregarEmpresa : FormBase
    {
        public FrmAgregarEmpresa(FrmEmpresa Empresa)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Empresas Empresas = new CDo_Empresas();
        CE_Empresas Empresa = new CE_Empresas();
        //perimte las carpetas agregar nuestras imagenes en empresas
        OpenFileDialog examinar = new OpenFileDialog(); 

        public delegate void UpdateDelegate(object sender, UpdatedEventArgs args);
        public event UpdateDelegate UpdatedEventHandler;

        public class UpdatedEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmAgregarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarFoto_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult Dres = examinar.ShowDialog();
            if(Dres == DialogResult.Abort)
            {
                return;
            }
            if (Dres == DialogResult.Cancel)
            {
                return;
            }
            TxtExaminar.Text = examinar.FileName;
            PtbLogoAgregar.Image= Image.FromFile(examinar.FileName);
        }
        //23:26
    }
}
