using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace CapaDatos
{
    public class CD_Acceso
    {
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
    }
}
