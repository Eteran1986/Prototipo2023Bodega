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
    public class CD_Empresas
    {
        //metodo de conexion
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        //SqlDataAdapter Da;
        //DataTable Dt;

        //metodo que me permita agregar, editar y eliminar una empresa a la base de datos

        public void AgregarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("AgregarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Empresa", Empresas.RUC_Empresa));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Empresas.Email));
            Cmd.Parameters.Add(new SqlParameter("@Logo", Empresas.Logo));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("EditarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Empresa", Empresas.ID_Empresa));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@RUC_Empresa", Empresas.RUC_Empresa));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", Empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", Empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", Empresas.Email));
            Cmd.Parameters.Add(new SqlParameter("@Logo", Empresas.Logo));

            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EliminarEmpresa(CE_Empresas Empresas)
        {
            Cmd = new SqlCommand("EliminarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Empresa", Empresas.ID_Empresa));
            
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
    }
}
