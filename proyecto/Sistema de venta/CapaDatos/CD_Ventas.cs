using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Entidad.Cache;


namespace CapaDatos
{
    public class CD_Ventas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarVentas(CE_Ventas Ventas)
        {
            Cmd = new SqlCommand("AgregarVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Cliente", Ventas.ID_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@ID_Usuario", Ventas.ID_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", Ventas.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", Ventas.Fecha_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ventas.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", Ventas.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@IVA", Ventas.IVA));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ventas.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ventas.Estado));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }

        public void AnularVentas(CE_Ventas Ventas)
        {
            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ventas Where ID_Venta =" + Ventas.ID_Ventas + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }
            Dr.Close();

            if (Estado == "Anular")
            {
                MessageBox.Show("Esta venta ya fue anulada, seleccione otro item en el sistema", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cmd = new SqlCommand("Anular_Ventas", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Venta", Ventas.ID_Ventas));
                //ojo
                Parametros(Ventas);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("La venta fue eliminado de nuestro sistema", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Cerrar();
            }
        }

        public void Parametros(CE_Ventas Ventas)
        {
            Cmd.Parameters.Add(new SqlParameter("@ID_Cliente", Ventas.ID_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@ID_Usuario", Ventas.ID_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", Ventas.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", Ventas.Fecha_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ventas.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", Ventas.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@IVA", Ventas.IVA));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ventas.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ventas.Estado));
        }
        public DataTable MostrarVentas()
        {
            DataTable Dt = new DataTable("Ventas de Producto");
            Cmd = new SqlCommand("Mostrar_ventas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Con.Cerrar();
            Dr.Close();
            return Dt;
        }

        public DataTable Mostrar_ProduVentas()
        {
            DataTable Dt = new DataTable("Mostrar_ProduVentas");
            Cmd = new SqlCommand("Mostrar_ProduVentas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Con.Cerrar();
            Dr.Close();
            return Dt;
        }


    }
}
