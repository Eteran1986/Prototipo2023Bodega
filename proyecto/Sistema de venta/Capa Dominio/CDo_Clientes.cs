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
    public class CDo_Clientes
    {
        //se conecta mediante la base de datos mediante objetos
        CD_Clientes ObjClientes = new CD_Clientes();

        //Metodo permite agregar los clientes
        public void AgregarCliente(CE_Clientes Clientes)
        {
            ObjClientes.AgregarCliente(Clientes);
        }

        //Metodo permite editar los clientes
        public void EditarCliente(CE_Clientes Clientes)
        {
            ObjClientes.EditarCliente(Clientes);
        }

        //Metodo permite eliminar los clientes
        public void EliminarCliente(CE_Clientes Clientes)
        {
            ObjClientes.EliminarCliente(Clientes);
        }

        //Metodo permite buscar los clientes por còdigo
        public DataTable Buscar_Cliente_Codigo(CE_Clientes Clientes)
        {
            return ObjClientes.Buscar_Cliente_Codigo(Clientes);
        }

        //Metodo permite buscar los clientes por descripcion
        public DataTable Buscar_Cliente_RUC(CE_Clientes Clientes)
        {
            return ObjClientes.Buscar_Cliente_RUC(Clientes);
        }

        //Metodo permite buscar los clientes por nombre
        public DataTable Buscar_Cliente_Nombre(CE_Clientes Clientes)
        {
            return ObjClientes.Buscar_Cliente_Nombre(Clientes);
        }
    }
}
