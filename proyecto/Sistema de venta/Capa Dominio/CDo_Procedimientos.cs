using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //se añade esta condición
using CapaDatos; //se añade esta condición
using System.Data.SqlClient; //se añade esta condición
using System.Windows.Forms; //se añade esta condición
using System.Security.AccessControl;

namespace Capa_Dominio
{
    public class CDo_Procedimientos
    {
        CD_Procedimientos ObjProcedimientos =new CD_Procedimientos();

        //Metodo que permite cargar datos de una tabla a un datagridview
        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }

        //Metodo que permite alternar los colores
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);
        }

        //Metodo que permite generar codigo
        public String GenerarCodigo(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigo(Tabla);
        }

        //Metodo que permite generar id
        public String GenerarCodigoID(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigoID(Tabla);
        }

        //metodo para formato moneda a un textbox
        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedimientos.FormatoMoneda(xTBox);
        }

        //metodo para limpiar textbox
        public void LimpiarTexto(Form xForm)
        {
            ObjProcedimientos.LimpiarTexto(xForm);
        }

        //metodo para limpiar textbox
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCBox)
        {
            ObjProcedimientos.LlenarComboBox(Tabla, Nombre, xCBox);
        }
        //Codigo Facturacion
        public String GenerarCodigoFact(string Campo)
        {
            return ObjProcedimientos.GenerarCodigoFact(Campo);
        }

    }
}
