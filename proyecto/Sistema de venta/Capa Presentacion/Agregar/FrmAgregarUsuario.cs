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
    public partial class FrmAgregarUsuario : FormBase
    {
        public FrmAgregarUsuario(FrmUsuario Usuarios)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Usuario Usuarios = new CDo_Usuario();
        CE_Usuario Usuario = new CE_Usuario();


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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                TxtApellidoUsu.Focus();
                e.Handled = true; 
            }
        }

        private void TxtApellidoUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtUsuario.Focus();
                e.Handled = true;
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtContrasena.Focus();
                e.Handled = true;
            }
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarUsuario.Focus();
                e.Handled = true;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try //para no registrar vacios en la base de datos
            {
                if (TxtNombreUsu.Text == "" || TxtApellidoUsu.Text == "" || TxtUsuario.Text == "" ||
                    TxtContrasena.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Usuario.Nombre_Usuario = TxtNombreUsu.Text.Trim();
                    Usuario.Apellido_Usuario = TxtApellidoUsu.Text.Trim();
                    Usuario.Usuario = TxtUsuario.Text.Trim();
                    Usuario.Password = TxtContrasena.Text.Trim();
                    Usuarios.IngresarAcceso(Usuario);
                    MessageBox.Show("El usuario fue agregadon con exito", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    TxtNombreUsu.Focus();
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Usuario no fue agregado por: " + ex.Message, "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
