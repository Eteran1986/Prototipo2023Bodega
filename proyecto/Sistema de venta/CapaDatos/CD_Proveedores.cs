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
    public class CD_Proveedores
    {
        //metodo de conexion
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //metodo que me permita agregar, editar y eliminar un proveedor a la base de datos

        public void AgregarProveedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("AgregarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Proveedor", Proveedores.RUC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditarProveedor(CE_Proveedores Proveedores)
        {
            Cmd = new SqlCommand("EditarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Proveedor", Proveedores.ID_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Proveedor", Proveedores.RUC_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Proveedores.Email));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EliminarProveedor(CE_Proveedores Proveedores)
        {
                Cmd = new SqlCommand("EliminarProveedores", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Proveedor", Proveedores.ID_Proveedor));
                Cmd.ExecuteNonQuery();

                Con.Cerrar();
        }

        //Buscar un Proveedor por codigo
        public DataTable Buscar_Prov_Codigo(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Proveedor_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un Proveedor por descripcion
        public DataTable Buscar_Prov_RUC(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("RUC");
            Cmd = new SqlCommand("Buscar_Proveedor_RUC", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un Proveedor por nombre
        public DataTable Buscar_Prov_Nombre(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Proveedor_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Compra por codigo
        public DataTable Buscar_Compra_Codigo(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Compras_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Compra por Nombre
        public DataTable Buscar_Compras_Nombre(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Compras_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Compra por comprobante
        public DataTable Buscar_Compras_Comprobante(CE_Proveedores Proveedores)
        {
            Dt = new DataTable("Comprobante");
            Cmd = new SqlCommand("Buscar_Compras_Comprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

    }
}
