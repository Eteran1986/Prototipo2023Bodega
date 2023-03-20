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
    public class CDo_Productos
    {
        CD_Productos ObjProductos = new CD_Productos();
        
        //Metodo permite agregar los productos
        public void AgregarProducto(CE_Productos productos)
        {
            ObjProductos.AgregarProducto(productos);
        }
        
        //Metodo permite editar los productos
        public void EditarProducto(CE_Productos productos)
        {
            ObjProductos.EditarProducto(productos);
        }

        //Metodo permite eliminar los productos
        public void EliminarProducto(CE_Productos productos)
        {
            ObjProductos.EliminarProducto(productos);
        }

        //Metodo permite buscar los productos por còdigo
        public DataTable Buscar_Prod_Codigo(CE_Productos productos)
        {
            return ObjProductos.Buscar_Prod_Codigo(productos);
        }

        //Metodo permite buscar los productos por descripcion
        public DataTable Buscar_Prod_Descripcion(CE_Productos productos)
        {
            return ObjProductos.Buscar_Prod_Descripcion(productos);
        }

        //Metodo permite buscar los productos por nombre
        public DataTable Buscar_Prod_Nombre(CE_Productos productos)
        {
            return ObjProductos.Buscar_Prod_Nombre(productos);
        }

        public DataTable Buscar_Inventario_Nombre(CE_Productos productos)
        {
            return ObjProductos.Buscar_Inventario_Nombre(productos);
        }

        public DataTable Buscar_Inventario_Categoria(CE_Productos productos)
        {
            return ObjProductos.Buscar_Inventario_Categoria(productos);
        }
        public DataTable Buscar_ProductoVentas_Codigo(CE_Productos productos)
        {
            return ObjProductos.Buscar_ProductoVentas_Codigo(productos);
        }
        public DataTable Buscar_ProductoVentas_Nombre(CE_Productos productos)
        {
            return ObjProductos.Buscar_ProductoVentas_Nombre(productos);
        }

    }
}
