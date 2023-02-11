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
    public partial class FrmEditarUsuario : FormBase
    {
        public FrmEditarUsuario(FrmUsuario Usuarios)
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

        protected void Actualizar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }


        private void TxtNombreUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
                if (TxtNombreUsu.Text == "" || TxtApellidoUsu.Text == "" || TxtUsuario.Text == "" ||
                    TxtContrasena.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Usuario.ID_Usuario = Convert.ToInt32(TxtID_Usuario.Text.Trim());
                    Usuario.Nombre_Usuario = TxtNombreUsu.Text.Trim();
                    Usuario.Apellido_Usuario = TxtApellidoUsu.Text.Trim();
                    Usuario.Usuario = TxtUsuario.Text.Trim();
                    Usuario.Password = TxtContrasena.Text.Trim();
                    Usuarios.EditAcceso(Usuario);
                    MessageBox.Show("El usuario fue editado con exito", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    this.Close();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Usuario no fue editado por: " + ex.Message, "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
