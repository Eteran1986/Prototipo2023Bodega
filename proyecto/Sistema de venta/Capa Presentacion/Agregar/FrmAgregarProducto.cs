using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio; //se agregan
using Capa_Entidad; //se agregan


namespace Capa_Presentacion
{
    public partial class FrmAgregarProducto : FormBase
    {
        public FrmAgregarProducto(FrmProductos Productos)
        {
            InitializeComponent();
        }

        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        CDo_Productos productos = new CDo_Productos();
        CE_Productos producto = new CE_Productos();


        public delegate void UpdateDelegate(object sender, UpdatedEventArgs args);
        public event UpdateDelegate UpdatedEventHandler;

        public class UpdatedEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdatedEventArgs args= new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            txtCodProducto.Text = "PROD" + procedimiento.GenerarCodigo("Productos");
        }


        private void txtNomProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescripcionProducto.Focus();
                e.Handled = true;
            }
        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPresentacion.Focus();
                e.Handled = true;
            }
        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVenta.Focus();
                e.Handled = true;
            }
        }

        private void txtCostoUnitario_Leave(object sender, EventArgs e)
        {
            procedimiento.FormatoMoneda(txtCostoUnitario);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cboTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            procedimiento.FormatoMoneda(txtPrecioVenta);
        }

        private void cboTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try //para no registrar vacios en la base de datos
            {
                if(txtCodProducto.Text == "" || txtNomProducto.Text == "" || txtDescripcionProducto.Text == "" ||
                    txtPresentacion.Text == "" || txtCostoUnitario.Text == "" || txtPrecioVenta.Text == "" ||
                   cboTipoCargo.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    producto.Codigo = txtCodProducto.Text.Trim();
                    producto.Nombre = txtNomProducto.Text.Trim();
                    producto.Descripcion = txtDescripcionProducto.Text.Trim();
                    producto.Presentacion = txtPresentacion.Text.Trim();
                    producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnitario.Text.Trim());//convertimos de texto a decimal o float
                    producto.Precio_venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());//convertimos de texto a decimal o float
                    producto.Tipo_Cargo = cboTipoCargo.Text.Trim();
                    producto.Categoria = CboCategoria.Text.Trim();

                    productos.AgregarProducto(producto);
                    MessageBox.Show("El producto fue agregadon con exito", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    procedimiento.LimpiarTexto(this);
                    GenerarCodigo();
                    txtNomProducto.Focus();
                    Agregar();
                    return true;
                }
                
            }
            catch (Exception ex)
            { 
                MessageBox.Show("El producto no fue agregado por: " +ex.Message,"Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
              
    }
}
