using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TipoCompro
    {
        //metodo de conexion
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;


        //metodo que me permita agregar, editar un tipo de comprobante a la base de datos
        public void AgregarTipoCompro(CE_Tipo_Comprobante Comprobante)
        {
            Cmd = new SqlCommand("AgregarTipoCompro", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre_Comprobante", Comprobante.Nombre_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Comprobante", Comprobante.Tipo_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Comprobante.Correlativo));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditarTipoCompro(CE_Tipo_Comprobante Comprobante)
        {
            Cmd = new SqlCommand("EditarTipoCompro", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Comprobante", Comprobante.ID_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Nombre_Comprobante", Comprobante.Nombre_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Comprobante", Comprobante.Tipo_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Comprobante.Correlativo));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }

        public void ActComprobante(CE_Tipo_Comprobante Comprobante)
        {
            Cmd = new SqlCommand("ActComprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Comprobante.Correlativo));
            Cmd.Parameters.Add(new SqlParameter("@ID_Comprobante", Comprobante.ID_Comprobante));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
    }
}
