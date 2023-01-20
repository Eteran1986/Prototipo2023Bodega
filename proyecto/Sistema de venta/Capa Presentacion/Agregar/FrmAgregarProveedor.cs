using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;//se agregaron
using Capa_Entidad;//se agregaron

namespace Capa_Presentacion
{
    public partial class FrmAgregarProveedor : FormBase
    {
        public FrmAgregarProveedor(FrmProveedores Proveedores)
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Proveedores Proveedores = new CDo_Proveedores();
        CE_Proveedores Proveedor = new CE_Proveedores();


        public delegate void UpdateDelegate(object sender, UpdatedEventArgs args);
        public event UpdateDelegate UpdatedEventHandler;

        public class UpdatedEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            TxtCodProveedor.Text = "PROV" + Procedimientos.GenerarCodigo("Proveedores");
        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                TxtRUCProveedor.Focus();
                e.Handled= true;
            }
        }

        private void TxtRUCProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDirProveedor.Focus();
                e.Handled = true;
            }
        }

        private void TxtDirProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MtxtTelefondoProveedor.Focus();
                e.Handled = true;
            }
        }

        private void MtxtTelefondoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailProveedor.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtCodProveedor.Text == "" || TxtNombreProveedor.Text == "" || TxtRUCProveedor.Text == "" ||
                    TxtDirProveedor.Text == "" || MtxtTelefondoProveedor.Text == "" || TxtEmailProveedor.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Proveedor.Codigo = TxtCodProveedor.Text.Trim();
                    Proveedor.Nombre = TxtNombreProveedor.Text.Trim();
                    Proveedor.RUC_Proveedor = TxtRUCProveedor.Text.Trim();
                    Proveedor.Direccion = TxtDirProveedor.Text.Trim();
                    Proveedor.Telefono = MtxtTelefondoProveedor.Text.Trim();
                    Proveedor.Email = TxtEmailProveedor.Text.Trim();
                    
                    Proveedores.AgregarProveedor(Proveedor);
                    MessageBox.Show("El proveedor fue agregado con exito", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    MtxtTelefondoProveedor.Text=string.Empty;
                    GenerarCodigo();
                    TxtNombreProveedor.Focus();
                    Agregar();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El proveedor no fue agregado por: " + ex.Message, "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
