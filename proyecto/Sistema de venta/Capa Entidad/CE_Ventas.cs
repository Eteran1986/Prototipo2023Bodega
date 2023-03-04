using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Ventas
    {
        private int _ID_Ventas;
        private int _ID_Cliente;
        private int _ID_Usuario;
        private string _No_Factura;
        private DateTime _Fecha_Venta;
        private string _Comprobante;
        private decimal _Sub_Total;
        private decimal _Descuento;
        private decimal _IVA;
        private decimal _Monto_Total;
        private string _Estado;
        private int _Buscar;

        public int ID_Ventas { get => _ID_Ventas; set => _ID_Ventas = value; }
        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string No_Factura { get => _No_Factura; set => _No_Factura = value; }
        public DateTime Fecha_Venta { get => _Fecha_Venta; set => _Fecha_Venta = value; }
        public string Comprobante { get => _Comprobante; set => _Comprobante = value; }
        public decimal Sub_Total { get => _Sub_Total; set => _Sub_Total = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }
        public decimal IVA { get => _IVA; set => _IVA = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public int Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
