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
    public partial class FrmEditarProveedor : FormBase
    {
        public FrmEditarProveedor(FrmProveedores Proveedores)
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

        protected void Actualizar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmEditarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRUCProveedor.Focus();
                e.Handled = true;
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
                btnEditar.Focus();
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try //para no registrar vacios en la base de datos 
            {
                if (TxtCodProveedor.Text == "" || TxtNombreProveedor.Text == "" || TxtRUCProveedor.Text == "" ||
                    TxtDirProveedor.Text == "" || MtxtTelefondoProveedor.Text == "" || TxtEmailProveedor.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Proveedor.ID_Proveedor = Convert.ToInt32(TextID_Proveedores.Text.Trim());
                    Proveedor.Codigo = TxtCodProveedor.Text.Trim();
                    Proveedor.Nombre = TxtNombreProveedor.Text.Trim();
                    Proveedor.RUC_Proveedor = TxtRUCProveedor.Text.Trim();
                    Proveedor.Direccion = TxtDirProveedor.Text.Trim();
                    Proveedor.Telefono = MtxtTelefondoProveedor.Text.Trim();
                    Proveedor.Email = TxtEmailProveedor.Text.Trim();

                    Proveedores.EditarProveedor(Proveedor);
                    MessageBox.Show("El proveedor fue editado con éxito", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    this.Close();
                    Actualizar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El proveedor no fue editado por: " + ex.Message, "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
