using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //se agregaron
using CapaDatos; //se agregaron
using Capa_Entidad; //se agregaron

namespace Capa_Dominio
{
    public class CDo_Empresas
    {
        //se conecta mediante la base de datos mediante objetos
        CD_Empresas ObjProveedores = new CD_Empresas();

        //Metodo permite agregar las empresas
        public void AgregarEmpresa(CE_Empresas Empresas)
        {
            ObjProveedores.AgregarEmpresa(Empresas);
        }

        //Metodo permite editar las empresas
        public void EditarEmpresa(CE_Empresas Empresas)
        {
            ObjProveedores.EditarEmpresa(Empresas);
        }

        //Metodo permite eliminar las empresas
        public void EliminarEmpresa(CE_Empresas Empresas)
        {
            ObjProveedores.EliminarEmpresa(Empresas);
        }
    }
}
