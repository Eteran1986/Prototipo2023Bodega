using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Informes
{
    public partial class FrmMostrar_IngresoProducto : Form
    {
        public FrmMostrar_IngresoProducto()
        {
            InitializeComponent();
        }

        private int _Id_Ingreso;

        public int Id_Ingreso { get => _Id_Ingreso; set => _Id_Ingreso = value; }

        private void Frm_Mostrar_IngresoProducto_Load(object sender, EventArgs e)
        {
            this.mostrar_IngresoProductoTableAdapter.Fill(this.datos_Generales.Mostrar_IngresoProducto, Id_Ingreso);
            this.reportViewer1.RefreshReport();
        }
    }
}
