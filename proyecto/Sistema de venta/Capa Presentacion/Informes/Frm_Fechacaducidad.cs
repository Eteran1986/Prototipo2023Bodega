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
            DTPDesde.MinDate= DateTime.Now;
            DTPHasta.MinDate= DateTime.Now;
        }

        private void Frm_Fechacaducidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datos_Generales.Mostrar_InformeFechacaducidad' Puede moverla o quitarla según sea necesario.
            //this.mostrar_InformeFechacaducidadTableAdapter.Fill(this.datos_Generales.Mostrar_InformeFechacaducidad);


            //this.RVRANGOFECHA.RefreshReport();
            //this.RVRDias.RefreshReport();
        }


        private DateTime _Fecha_Inicio;
        private DateTime _Fecha_Final;

        private int _Id_Ingreso;
        public DateTime Fecha_Inicio { get => _Fecha_Inicio; set => _Fecha_Inicio = value; }
        public int Id_Ingreso { get => _Id_Ingreso; set => _Id_Ingreso = value; }

        public DateTime Fecha_Final { get => _Fecha_Final; set => _Fecha_Final = value; }



        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            RVRPTFECHA.Visible= false;
            RVRANGOFECHA.Visible= true;
            RVRDias.Visible= false;
            Fecha_Inicio=DTPDesde.Value;
            Fecha_Final = DTPHasta.Value;
            this.mostrar_Inf_FechaTableAdapter.Fill(this.datos_Generales.Mostrar_Inf_Fecha,Fecha_Inicio,Fecha_Final);
            this.RVRANGOFECHA.RefreshReport();
        }
        
        private void BtnTodos_Click(object sender, EventArgs e)
        {
            RVRANGOFECHA.Visible= false;
            RVRPTFECHA.Visible = true;
            RVRDias.Visible = false;
            this.mostrar_InformeFechacaducidadTableAdapter.Fill(this.datos_Generales.Mostrar_InformeFechacaducidad);
            this.RVRPTFECHA.RefreshReport();
        }

        private void BtnAplicarDias_Click(object sender, EventArgs e)
        {
            RVRANGOFECHA.Visible = false;
            RVRPTFECHA.Visible = false;
            RVRDias.Visible = true;
            DTPDesde.MinDate = DateTime.Now;
            DTPHasta.MinDate = DateTime.Now;
            Fecha_Inicio = DTPDesde.MinDate;
            Fecha_Final= DateTime.Now.AddDays(Convert.ToInt32(TxtDias.Text));
            this.mostrar_Inf_FechaTableAdapter.Fill(this.datos_Generales.Mostrar_Inf_Fecha, Fecha_Inicio, Fecha_Final);
            this.RVRDias.RefreshReport();
        }

        //DtpFechaCaducidad.MinDate = DateTime.Now.AddDays(5)

    }
}
