using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_DetalleIngreso
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleIngreso(CE_DetalleIngreso Detalle)
        {
            Cmd = new SqlCommand("Agregar_Det_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalle.Id_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalle.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalle.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_caducidad", Detalle.Fecha_caducidad));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalle.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalle.Sub_Total));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void AnularDetalleIngreso(CE_DetalleIngreso Detalle)
        {
            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ingreso_Producto Where ID_Ingreso =" + Detalle.Id_Ingreso + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }
            Dr.Close();

            if (Estado == "Anular")
            {
                return;
            }
            else
            {
                Cmd = new SqlCommand("Anular_Det_Producto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Detalle", Detalle.ID_Detalle));
                Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalle.Id_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalle.Id_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalle.Cantidad));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_caducidad", Detalle.Fecha_caducidad));
                Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalle.Costo_Unitario));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalle.Sub_Total));
                Cmd.ExecuteNonQuery();

                Con.Cerrar();
            }
        }

        public DataTable MostrarIngresoProducto(int Id_Ingreso)
        {
            DataTable Dt = new DataTable("Detalle Ingreso");
            Cmd = new SqlCommand("MostrarDetalleIngresos", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Id_Ingreso));
            Cmd.ExecuteNonQuery();

            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }
    }
}
