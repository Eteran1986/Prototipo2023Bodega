using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Entidad.Cache;

namespace CapaDatos
{
    public class CD_DetalleVentas
    {
        CD_DetalleVentas ObjDetalleVentas = new CD_DetalleVentas();
        public void AgregarDetalleVentas(CE_DetalleVentas DetalleVentas)
        {
            ObjDetalleVentas.AgregarDetalleVentas(DetalleVentas);
        }

        public void AnularDetalleVentas(CE_DetalleVentas DetalleVentas)
        {
            ObjDetalleVentas.AnularDetalleVentas(DetalleVentas);
        }

        public DataTable Mostrar_DetalleVentas(int ID_Ventas)
        {
            return ObjDetalleVentas.Mostrar_DetalleVentas(ID_Ventas);
        }
    }
}
