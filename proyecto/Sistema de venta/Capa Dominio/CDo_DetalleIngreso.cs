using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //se agregaron
using CapaDatos; //se agregaron
using Capa_Entidad; //se agregaron
using System.Data.SqlClient; //se agregaron

namespace CapaDatos
{
    public class CDo_DetalleIngreso
    {
        CD_DetalleIngreso ObjDetalleIngreso = new CD_DetalleIngreso();

        public void AgregarDetalleIngreso(CE_DetalleIngreso Detalles)
        {
            ObjDetalleIngreso.AgregarDetalleIngreso(Detalles);
        }
        public void AnularDetalleingreso(CE_DetalleIngreso Detalles)
        {
            ObjDetalleIngreso.AnularDetalleIngreso(Detalles);
        }

        public DataTable MostrarIngresoProducto(int Id_Ingreso)
        {
            return ObjDetalleIngreso.MostrarIngresoProducto(Id_Ingreso);
        }

    }
}