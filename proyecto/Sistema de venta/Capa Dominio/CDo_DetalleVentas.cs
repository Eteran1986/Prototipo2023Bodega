using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class CDo_DetalleVentas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleVentas(CE_DetalleVentas DetalleVentas)
        {
            Cmd = new SqlCommand("Agregar_DetalleVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Venta", DetalleVentas.ID_Venta));
            Cmd.Parameters.Add(new SqlParameter("@ID_Producto", DetalleVentas.ID_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", DetalleVentas.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", DetalleVentas.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", DetalleVentas.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", DetalleVentas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", DetalleVentas.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@IVA", DetalleVentas.IVA));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", DetalleVentas.Monto_Total));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }

        public void AnularDetalleVentas(CE_DetalleVentas DetalleVentas)
        {
            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ventas Where ID_Venta =" + DetalleVentas.ID_Venta + "", Con.Abrir());
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
                Cmd = new SqlCommand("Anular_DetalleVentas", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Detalle", DetalleVentas.ID_Detalle));
                Cmd.Parameters.Add(new SqlParameter("@ID_Venta", DetalleVentas.ID_Venta));
                Cmd.Parameters.Add(new SqlParameter("@ID_Producto", DetalleVentas.ID_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Presentacion", DetalleVentas.Presentacion));
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", DetalleVentas.Cantidad));
                Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", DetalleVentas.Precio_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", DetalleVentas.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Descuento", DetalleVentas.Descuento));
                Cmd.Parameters.Add(new SqlParameter("@IVA", DetalleVentas.IVA));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", DetalleVentas.Monto_Total));
                Cmd.ExecuteNonQuery();
                Con.Cerrar();
            }
        }

        public DataTable Mostrar_DetalleVentas(int ID_Ventas)
        {
            DataTable Dt = new DataTable("Detalle Ventas");
            Cmd = new SqlCommand("Mostrar_DetalleVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Ventas", ID_Ventas));
            Cmd.ExecuteNonQuery();
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);
            Con.Cerrar();
            return Dt;
        }
    }
}
