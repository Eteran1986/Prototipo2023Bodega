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

            Dr=Cmd.ExecuteReader();
            if(Dr.Read())
            {
                InformacionUsuario.IDUsuario = Dr.GetInt32(0);
                InformacionUsuario.Nombre_Usuario = Dr.GetString(1);
                InformacionUsuario.Apellido_Usuario = Dr.GetString(2);
                InformacionUsuario.Usuario = Dr.GetString(3);
                InformacionUsuario.Password = Dr.GetString(4);
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorrectos", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Dr.Close();
            Con.Cerrar();
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
