using Capa_Entidad.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;


namespace Capa_Presentacion
{
    public partial class FrmPrincipal : Form
    {
        bool MenuExpandir;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (MenuExpandir)
            {
                MenuPanel.Width -= 10;
                LbPrototipo.Visible = false;
                lblfecha.Visible = false;
                lbldia.Visible = false;
                //BtnCompras.Visible = true;
                if (MenuPanel.Width == MenuPanel.MinimumSize.Width)
                {
                    MenuExpandir = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                MenuPanel.Width += 10;
                //BtnCompras.Visible = false;
                if (MenuPanel.Width == MenuPanel.MaximumSize.Width)
                {
                    MenuExpandir = true;
                    MenuTimer.Stop();
                    LbPrototipo.Visible = true;
                    lblfecha.Visible = true;
                    lbldia.Visible = true;
                }
            }
        }
        /*        private void tmTiempo_Tick(object sender, EventArgs e)
                {
                    lblfecha.Text = DateTime.Now.ToLongTimeString();
                    lbldia.Text = DateTime.Now.ToLongDateString();
                }*/

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos Productos= new FrmProductos();
            Productos.ShowDialog();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario Inventarios = new FrmInventario();
            Inventarios.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores Proveedores = new FrmProveedores();
            Proveedores.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa Empresa = new FrmEmpresa();
            Empresa.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras Compra = new FrmCompras();
            Compra.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario Usuarios = new FrmUsuario();
            Usuarios.ShowDialog();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAcceso Acceso = new FrmAcceso();
            Acceso.Show();
            this.Hide();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Fechacaducidad FechaCaduciada = new Frm_Fechacaducidad();
            FechaCaduciada.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            /*if (InformacionUsuario.Administrador == 1)
            {
                menuStrip1.Visible = true;
            }*/
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDashboardcs Dashboard = new FrmDashboardcs();
            Dashboard.ShowDialog();
        }

        private void tiposDeComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoComprobante Comprobantes = new FrmTipoComprobante();
            Comprobantes.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVentas Ventas = new FrmVentas();
            Ventas.ShowDialog();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion Fac = new FrmFacturacion();
            Fac.ShowDialog();
        }

        private void IconoMenu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }
    }
}
