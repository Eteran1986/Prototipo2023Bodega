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
    public class CDo_Proveedores
    {
        //se conecta mediante la base de datos mediante objetos
        CD_Proveedores ObjProveedores = new CD_Proveedores();

        //Metodo permite agregar los proveedores
        public void AgregarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.AgregarProveedor(Proveedores);
        }

        //Metodo permite editar los proveedores
        public void EditarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.EditarProveedor(Proveedores);
        }

        //Metodo permite eliminar los proveedores
        public void EliminarProveedor(CE_Proveedores Proveedores)
        {
            ObjProveedores.EliminarProveedor(Proveedores);
        }

        //Metodo permite buscar los proveedores por còdigo
        public DataTable Buscar_Prov_Codigo(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Prov_Codigo(Proveedores);
        }

        //Metodo permite buscar los proveedores por descripcion
        public DataTable Buscar_Prov_RUC(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Prov_RUC(Proveedores);
        }

        //Metodo permite buscar los proveedores por nombre
        public DataTable Buscar_Prov_Nombre(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Prov_Nombre(Proveedores);
        }

        //Metodo permite buscar los compra por codigo
        public DataTable Buscar_Compra_Codigo(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Compra_Codigo(Proveedores);
        }
        
        //Metodo permite buscar los compra por nombre
        public DataTable Buscar_Compras_Nombre(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Compras_Nombre(Proveedores);
        }

        //Metodo permite buscar los compra por comprobante
        public DataTable Buscar_Compras_Comprobante(CE_Proveedores Proveedores)
        {
            return ObjProveedores.Buscar_Compras_Comprobante(Proveedores);
        }


    }
}
