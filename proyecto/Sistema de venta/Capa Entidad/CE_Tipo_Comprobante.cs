using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Tipo_Comprobante
    {
        private int _ID_Comprobante;
        private string _Nombre_Comprobante;
        private string _Tipo_Comprobante;
        private int _Correlativo;

        public int ID_Comprobante { get => _ID_Comprobante; set => _ID_Comprobante = value; }
        public string Nombre_Comprobante { get => _Nombre_Comprobante; set => _Nombre_Comprobante = value; }
        public string Tipo_Comprobante { get => _Tipo_Comprobante; set => _Tipo_Comprobante = value; }
        public int Correlativo { get => _Correlativo; set => _Correlativo = value; }
    }
}
