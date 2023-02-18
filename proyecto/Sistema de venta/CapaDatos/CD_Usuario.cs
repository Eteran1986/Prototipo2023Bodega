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
    public class CD_Usuario
    {
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        SqlDataReader Dr;
        //DataTable Dt;

        //metodo que me permita agregar, editar y eliminar un usuario a la base de datos

        public void IngresarAcceso(CE_Usuario Accesos)
        {
            Cmd = new SqlCommand("IngresarAcceso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre_Usuario", Accesos.Nombre_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Apellido_Usuario", Accesos.Apellido_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Usuario", Accesos.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", Accesos.Password));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void EditAcceso(CE_Usuario Accesos)
        {
            Cmd = new SqlCommand("EditAcceso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@ID_Usuario", Accesos.ID_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Nombre_Usuario", Accesos.Nombre_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Apellido_Usuario", Accesos.Apellido_Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Usuario", Accesos.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", Accesos.Password));
            Cmd.ExecuteNonQuery();
            Con.Cerrar();
        }
        public void ElimAcceso(CE_Usuario Accesos)
        {
                Cmd = new SqlCommand("ElimAcceso", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@ID_Usuario", Accesos.ID_Usuario));
                Cmd.ExecuteNonQuery();
                MessageBox.Show("El Usuario fue eliminado de nuestro sistema", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Cerrar();
        }

        //Acceder al sistema
        public void LoginAcceso(CE_Usuario Login)
        {
            Cmd = new SqlCommand("AccesoLogin", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Usuario", Login.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", Login.Password));
            int a = 0;
            Dr=Cmd.ExecuteReader();
            if(Dr.Read())
            {
                InformacionUsuario.IDUsuario = Dr.GetInt32(0);
                InformacionUsuario.Nombre_Usuario = Dr.GetString(1);
                InformacionUsuario.Apellido_Usuario = Dr.GetString(2);
                InformacionUsuario.Usuario = Dr.GetString(3);
                InformacionUsuario.Password = Dr.GetString(4);
                a++;
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorrectos", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Dr.Close();
            Con.Cerrar();
            //Validación de credencial antes de la notificacion para el mensaje de los productos caducados
            if(a==1)
            {
                Cmd = new SqlCommand("SELECT Top 1 Fecha_caducidad, count(*) as ProductoFecha FROM Can_Detalle_Producto where Cantidad>0 group by Fecha_caducidad order by Fecha_caducidad", Con.Abrir());
                Cmd.CommandType = CommandType.Text;
                SqlDataReader Da = Cmd.ExecuteReader();
                Da.Read();
                InformacionUsuario.Fecha_Caducidad = Da["Fecha_caducidad"].ToString();
                InformacionUsuario.numeroFecha = Convert.ToInt32(Da["ProductoFecha"].ToString());
                Da.Close();
            }
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
