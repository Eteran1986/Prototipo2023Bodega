using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Capa_Entidad;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad.Cache;

namespace Capa_Dominio
{
    public class CDo_Usuario
    {
        CD_Usuario ObjAcceso = new CD_Usuario();
        
        public void IngresarAcceso(CE_Usuario Accesos)
        {
            ObjAcceso.IngresarAcceso(Accesos);
        }
        public void EditAcceso(CE_Usuario Accesos)
        {
            ObjAcceso.EditAcceso(Accesos);
        }
        public void ElimAcceso(CE_Usuario Accesos)
        {
            ObjAcceso.ElimAcceso(Accesos);
        }

        public void LoginAcceso(CE_Usuario Login)
        {
            ObjAcceso.LoginAcceso(Login);
        }

    }
}
