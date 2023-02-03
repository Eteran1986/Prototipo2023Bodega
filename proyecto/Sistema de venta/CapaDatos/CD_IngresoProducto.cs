using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using CapaDatos;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_IngresoProducto
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarIngreso(CE_IngresoProducto Ingresos)
        {
            Cmd = new SqlCommand("Agregar_Ing_Producto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@No_Ingreso", Ingresos.No_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ingresos.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void AnularIngreso(CE_IngresoProducto Ingresos)
        {
            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ingreso_Producto Where ID_Ingreso =" + Ingresos.ID_Ingreso + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }
            Dr.Close();

            if (Estado == "Anular")
            {
                MessageBox.Show("Esta compra ya fue anulada, seleccione otro item en el sistema", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cmd = new SqlCommand("Anular_Ing_Producto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@No_Ingreso", Ingresos.No_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@ID_Ingreso", Ingresos.ID_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ingresos.Comprobante));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));
                Cmd.ExecuteNonQuery();
                MessageBox.Show("La compra fue eliminado de nuestro sistema", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Information/*,MessageBoxDefaultButton.Button2*/);
                Con.Cerrar();
            }
        }
        public DataTable MostrarIngProd()
        {
            DataTable Dt= new DataTable("Ingreso Producto");
            Cmd = new SqlCommand("Mostrar_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader Dr=Cmd.ExecuteReader();
            Dt.Load(Dr);

            Con.Cerrar();
            Dr.Close();
            return Dt;
        }

    }
}
