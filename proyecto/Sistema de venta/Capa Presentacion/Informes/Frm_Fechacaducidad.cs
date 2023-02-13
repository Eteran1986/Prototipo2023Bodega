using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Informes;

namespace Capa_Presentacion
{
    public partial class Frm_Fechacaducidad : Form
    {
        public Frm_Fechacaducidad()
        {
            InitializeComponent();
        }

        private void Frm_Fechacaducidad_Load(object sender, EventArgs e)
        {

            
        }

        
        private DateTime _Fecha_Inicio;
        //private DateTime _Fecha_Final;

        private int _Id_Ingreso;
        public DateTime Fecha_Inicio { get => _Fecha_Inicio; set => _Fecha_Inicio = value; }
        public int Id_Ingreso { get => _Id_Ingreso; set => _Id_Ingreso = value; }

        //public DateTime Fecha_Final { get => _Fecha_Final; set => _Fecha_Final = value; }



        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            //DTPDesde.Value = Fecha_Inicio;
            //DTPHasta.Value = Fecha_Final;
        }
        
        private void BtnTodos_Click(object sender, EventArgs e)
        {
                this.mostrar_InformeFechacaducidadTableAdapter.Fill(this.datos_Generales.Mostrar_InformeFechacaducidad);
                this.reportViewer1.RefreshReport();
        }

    }
}
