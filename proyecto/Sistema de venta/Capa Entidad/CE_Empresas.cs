using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Empresas
    {
        private int _ID_Empresa;
        private string _Nombre;
        private string _RUC_Empresa;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private byte[] _Logo; //porque son imagenes

        public int ID_Empresa { get => _ID_Empresa; set => _ID_Empresa = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RUC_Empresa { get => _RUC_Empresa; set => _RUC_Empresa = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public byte[] Logo { get => _Logo; set => _Logo = value; }
    }
}
