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
    public class CD_Clientes
    {
        //metodo de conexion
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //metodo que me permita agregar, editar y eliminar un cliente a la base de datos

        public void AgregarCliente(CE_Clientes Clientes)
        {
            Cmd = new SqlCommand("AgregarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Cliente", Clientes.RUC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditarCliente(CE_Clientes Clientes)//9;14
        {
            Cmd = new SqlCommand("EditarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Cliente", Clientes.ID_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Clientes.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Clientes.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Cliente", Clientes.RUC_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Clientes.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Clientes.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Clientes.Email));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Clientes.Estado));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EliminarCliente(CE_Clientes Clientes)
        {
            Cmd = new SqlCommand("EliminarCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Cliente", Clientes.ID_Cliente));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Buscar un Clientes por codigo
        public DataTable Buscar_Cliente_Codigo(CE_Clientes Clientes)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Cliente_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un Clientes por descripcion
        public DataTable Buscar_Cliente_RUC(CE_Clientes Clientes)
        {
            Dt = new DataTable("RUC");
            Cmd = new SqlCommand("Buscar_Cliente_RUC", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar un Clientes por nombre
        public DataTable Buscar_Cliente_Nombre(CE_Clientes Clientes)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Cliente_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Clientes.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
