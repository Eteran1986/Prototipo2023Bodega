using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Capa_Dominio
{
    public class CDo_Ventas
    {
        CD_Ventas ObjVentas = new CD_Ventas();
        public void AgregarVentas(CE_Ventas Ventas)
        {
            ObjVentas.AgregarVentas(Ventas);
        }

        public void AnularVentas(CE_Ventas Ventas)
        {
            ObjVentas.AnularVentas(Ventas);
        }

        public DataTable MostrarVentas()
        {
            return ObjVentas.MostrarVentas();
        }
        public DataTable Mostrar_ProduVentas()
        {
            return ObjVentas.Mostrar_ProduVentas();
        }

        public DataTable Buscar_Ventas_Usuario(CE_Ventas Ventas)
        {
            return ObjVentas.Buscar_Ventas_Usuario(Ventas);
        }

        //Metodo permite buscar los compra por nombre
        public DataTable Buscar_Ventas_Nombre(CE_Ventas Ventas)
        {
            return ObjVentas.Buscar_Ventas_Nombre(Ventas);
        }

        //Metodo permite buscar los compra por comprobante
        public DataTable Buscar_Ventas_Comprobante(CE_Ventas Ventas)
        {
            return ObjVentas.Buscar_Ventas_Comprobante(Ventas);
        }
        public DataTable MostrarInforme(CE_Ventas Ventas)
        {
            return ObjVentas.MostrarInforme(Ventas);
        }

    }
}
