using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Usuario
    {
        private int _ID_Usuario;
        private string _Nombre_Usuario;
        private string _Apellido_Usuario;
        private string _Usuario;
        private string _Password;
        private int _Administrador;

        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Nombre_Usuario { get => _Nombre_Usuario; set => _Nombre_Usuario = value; }
        public string Apellido_Usuario { get => _Apellido_Usuario; set => _Apellido_Usuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int Administrador { get => _Administrador; set => _Administrador = value; }
    }
}
