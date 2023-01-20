using Capa_Dominio;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmAgregarCliente : FormBase
    {
        public FrmAgregarCliente(FrmClientes Clientes)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Clientes Clientes = new CDo_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

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

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            TxtCodCliente.Text = "CLI" + Procedimientos.GenerarCodigo("Clientes");
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRUCCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtRUCCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDirCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtDirCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MtxtTelefonoCliente.Focus();
                e.Handled = true;
            }
        }

        private void MtxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailCliente.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CboEstadoCliente.Focus();
                e.Handled = true;
            }
        }

        private void CboEstadoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.Focus();
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try //para no registrar vacios en la base de datos
            {
                if (TxtCodCliente.Text == "" || TxtNombreCliente.Text == "" || TxtRUCCliente.Text == "" ||
                    TxtDirCliente.Text == "" || MtxtTelefonoCliente.Text == "" || TxtEmailCliente.Text == "" ||
                    CboEstadoCliente.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cliente.Codigo = TxtCodCliente.Text.Trim();
                    Cliente.Nombre = TxtNombreCliente.Text.Trim();
                    Cliente.RUC_Cliente = TxtRUCCliente.Text.Trim();
                    Cliente.Direccion = TxtDirCliente.Text.Trim();
                    Cliente.Telefono = MtxtTelefonoCliente.Text.Trim();
                    Cliente.Email = TxtEmailCliente.Text.Trim();
                    Cliente.Estado = CboEstadoCliente.Text.Trim();

                    Clientes.AgregarCliente(Cliente);
                    MessageBox.Show("El cliente fue agregadon con exito", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    MtxtTelefonoCliente.Text = string.Empty;
                    GenerarCodigo();
                    TxtNombreCliente.Focus();
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no fue agregado por: " + ex.Message, "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
