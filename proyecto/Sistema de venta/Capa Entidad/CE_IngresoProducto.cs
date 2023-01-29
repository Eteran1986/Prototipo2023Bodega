using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_IngresoProducto
    {
        private int _ID_Ingreso;
        private string _No_Ingreso;
        private int _Id_Proveedor;
        private DateTime _Fecha_Ingreso;
        private string _Comprobante;
        private decimal _Monto_Total;
        private string _Estado;

        public int ID_Ingreso { get => _ID_Ingreso; set => _ID_Ingreso = value; }

        public string No_Ingreso { get => _No_Ingreso; set => _No_Ingreso = value; }
        public int Id_Proveedor { get => _Id_Proveedor; set => _Id_Proveedor = value; }
        public DateTime Fecha_Ingreso { get => _Fecha_Ingreso; set => _Fecha_Ingreso = value; }
        public string Comprobante { get => _Comprobante; set => _Comprobante = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        
    }
}
