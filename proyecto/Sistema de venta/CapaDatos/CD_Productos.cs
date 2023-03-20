using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //se agrego 
using System.Data.SqlClient; //se agrego 
using Capa_Entidad; //se agrego 
using System.Windows.Forms; //se agrego 

namespace CapaDatos
{
    public class CD_Productos
    {
        //metodo de conexion
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //metodo que me permita agregar, editar y eliminar un producto a la base de datos
        public void AgregarProducto(CE_Productos Productos)
        {
            int Existencia = 0;
            Cmd = new SqlCommand("select C.ID_Categoria from Categoria C where C.Categoria='" + Productos.Categoria + "'", Con.Abrir());
            Cmd.CommandType = CommandType.Text;
            SqlDataReader Dr = Cmd.ExecuteReader();
            Dr.Read();
            Existencia = Convert.ToInt32(Dr["ID_Categoria"].ToString());
            Dr.Close();
            Cmd = new SqlCommand("AgregarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_venta", Productos.Precio_venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.Parameters.Add(new SqlParameter("@ID_Categoria", Existencia));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("EditarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Producto", Productos.ID_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_venta", Productos.Precio_venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }

        public void EliminarProducto(CE_Productos Productos)
        {
            int Existencia = 0;
            Cmd = new SqlCommand("Select Cantidad From Inventarios Where ID_Inventario =" + Productos.ID_Producto +"", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr= Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Existencia = Convert.ToInt32(Dr["Cantidad"].ToString());
            }
            Dr.Close();
            
            if (Existencia!=0) 
            {
                MessageBox.Show("No se puede eliminar, hay producto en el sistema", "Eliminar Producto", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Producto", Productos.ID_Producto));
                Cmd.ExecuteNonQuery();
                MessageBox.Show("El producto fue eliminado de nuestro sistema", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Cerrar();
            }
        }

        //Buscar un producto por codigo
        public DataTable Buscar_Prod_Codigo(CE_Productos productos)
        {
            Dt =new DataTable("Codigo");
            Cmd= new SqlCommand("Buscar_Producto_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un producto por descripcion
        public DataTable Buscar_Prod_Descripcion(CE_Productos productos)
        {
            Dt = new DataTable("Descripcion");
            Cmd = new SqlCommand("Buscar_Producto_Descripcion", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un producto por nombre
        public DataTable Buscar_Prod_Nombre(CE_Productos productos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Producto_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        public DataTable Buscar_Inventario_Nombre(CE_Productos productos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Inventario_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        public DataTable Buscar_Inventario_Categoria(CE_Productos productos)
        {
            Dt = new DataTable("Categoria");
            Cmd = new SqlCommand("Buscar_Inventario_Categoria", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        public DataTable Buscar_ProductoVentas_Codigo(CE_Productos productos)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_ProductoVentas_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
        public DataTable Buscar_ProductoVentas_Nombre(CE_Productos productos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_ProductoVentas_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
