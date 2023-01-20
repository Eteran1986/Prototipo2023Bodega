using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Proveedores
    {
        // private int _ID_Proveedor seleccionamos todos los private y le damos click derecho la cual escogemos la primera opcion y luego encapsulado con sus propiedades
        private int _ID_Proveedor;
        private string _Codigo;
        private string _Nombre;
        private string _RUC_Proveedor;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Buscar;

        public int ID_Proveedor { get => _ID_Proveedor; set => _ID_Proveedor = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RUC_Proveedor { get => _RUC_Proveedor; set => _RUC_Proveedor = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
