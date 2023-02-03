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
    public partial class FrmAcceso : FormBase
    {
        public FrmAcceso()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos=new CDo_Procedimientos();
        CDo_Acceso Accesos=new CDo_Acceso();
        CE_Acceso Acceso =new CE_Acceso();


        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            MostrarAcceso();
        }

        private void MostrarAcceso()
        {

        }
    }
}
