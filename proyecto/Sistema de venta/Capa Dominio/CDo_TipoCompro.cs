using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Dominio;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Dominio
{
    public class CDo_TipoCompro
    {
        CD_TipoCompro ObjTipoCompro = new CD_TipoCompro();

        public void AgregarTipoCompro(CE_Tipo_Comprobante Comprobante)
        {
            ObjTipoCompro.AgregarTipoCompro(Comprobante);
        }
        public void EditarTipoCompro(CE_Tipo_Comprobante Comprobante)
        {
            ObjTipoCompro.EditarTipoCompro(Comprobante);
        }
        public void ActComprobante(CE_Tipo_Comprobante Comprobante)
        {
            ObjTipoCompro.ActComprobante(Comprobante);
        }
    }
}
