using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Capa_Entidad;
using Capa_Entidad.Cache;

namespace Capa_Presentacion
{
    public partial class FrmAcceso : Form
    {
        public FrmAcceso()
        {
            InitializeComponent();
        }

        CDo_Usuario Usuarios = new CDo_Usuario();
        CE_Usuario Usuario = new CE_Usuario();

        /* Esto me permite mover mi formulario en el sistema*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPassword.Focus();
                e.Handled = true;
            }
        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnIngresar.Focus();
                e.Handled = true;
            }
        }
        private void FrmAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoGeneral();
        }

        private void FrmAcceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Completar()
        {
            MessageBox.Show("Debe de completar los campos", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtUsuario.Text != string.Empty)
                {
                    if(TxtPassword.Text != string.Empty)
                    {
                        Usuario.Usuario = TxtUsuario.Text.Trim();
                        Usuario.Password = TxtPassword.Text.Trim();
                        Usuarios.LoginAcceso(Usuario);
                        if(_ = InformacionUsuario.Usuario == TxtUsuario.Text.Trim())
                        {
                            FrmPrincipal FormularioPrincipal = new FrmPrincipal();
                            FormularioPrincipal.Show();
                            this.Hide();
                            this.NotFechaCaducidad.ShowBalloonTip(1000, "Productos pronto a Caducar", "Tiene " + InformacionUsuario.numeroFecha + " Productos con fecha: " + InformacionUsuario.Fecha_Caducidad, ToolTipIcon.Info);
                        }
                        else
                        {
                            TxtUsuario.Clear();
                            TxtPassword.Clear();
                            TxtUsuario.Focus();
                        }
                    }
                    else
                    {
                        Completar();
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    Completar();
                    TxtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede Ingresar al sistema " +ex.Message, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoGeneral();
        }
        private void FrmAcceso_Click(object sender, EventArgs e)
        {
            MovimientoGeneral();
        }
        private void MovimientoGeneral()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoGeneral();
        }

    }
}
