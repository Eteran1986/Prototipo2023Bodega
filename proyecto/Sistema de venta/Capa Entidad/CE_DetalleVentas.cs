using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_DetalleVentas
    {
        private int _ID_Detalle;
        private int _ID_Venta;
        private int _ID_Producto;
        private string _Presentacion;
        private int _Cantidad;
        private decimal _Precio_Venta;
        private decimal _Sub_Total;
        private decimal _Descuento;
        private decimal _IVA;
        private decimal _Monto_Total;
        private int _Buscar;

        public int ID_Detalle { get => _ID_Detalle; set => _ID_Detalle = value; }
        public int ID_Venta { get => _ID_Venta; set => _ID_Venta = value; }
        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Precio_Venta { get => _Precio_Venta; set => _Precio_Venta = value; }
        public decimal Sub_Total { get => _Sub_Total; set => _Sub_Total = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }
        public decimal IVA { get => _IVA; set => _IVA = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
        public int Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
