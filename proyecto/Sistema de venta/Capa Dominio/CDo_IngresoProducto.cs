using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Capa_Dominio
{
    public class CDo_IngresoProducto
    {
        CD_IngresoProducto ObjIngresoProducto = new CD_IngresoProducto();

        public void AgregarIngreso(CE_IngresoProducto Ingresos)
        {
            ObjIngresoProducto.AgregarIngreso(Ingresos);
        }

        public void AnularIngreso(CE_IngresoProducto Ingresos)
        {
            ObjIngresoProducto.AnularIngreso(Ingresos);
        }
        public DataTable MostrarIngProd()
        {
            return ObjIngresoProducto.MostrarIngProd();
        }
    }
}
