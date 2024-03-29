﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Productos
    {
        private int _ID_Producto;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private string _Presentacion;
        private decimal _Costo_Unitario;
        private decimal _Precio_venta;
        private string _Tipo_Cargo;
        private int _ID_Categoria;
        private string _Categoria;
        private string _Buscar;

        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public decimal Costo_Unitario { get => _Costo_Unitario; set => _Costo_Unitario = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public string Tipo_Cargo { get => _Tipo_Cargo; set => _Tipo_Cargo = value; }
        public int ID_Categoria { get => _ID_Categoria; set => _ID_Categoria = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
    }
}
