using Capa_Entidad.Cache;
using System;
using System.CodeDom;
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
        private int menu = 0;
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
                LUsuario.Visible = false;
                if (MenuPanel.Width == MenuPanel.MinimumSize.Width)
                {
                    MenuExpandir = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                if(menu==0)
                {
                    MenuPanel.Width -= 150;
                    LbPrototipo.Visible = false;
                    MenuExpandir = false;
                    LUsuario.Visible = false;
                    MenuTimer.Stop();
                    menu++;
                }
                else
                {
                    MenuPanel.Width += 10;
                    if (MenuPanel.Width == MenuPanel.MaximumSize.Width)
                    {
                        MenuExpandir = true;
                        LUsuario.Visible = true;
                        MenuTimer.Stop();
                        LbPrototipo.Visible = true;
                    }
                }
            }
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos Productos= new FrmProductos();
            Productos.Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario Inventarios = new FrmInventario();
            Inventarios.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores Proveedores = new FrmProveedores();
            Proveedores.Show();
            this.Hide();
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
            Compra.Show();
            this.Hide();
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
            this.Hide();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LUsuario.Text = InformacionUsuario.Nombre_Usuario;
            if (InformacionUsuario.Administrador == 1)//administrador
            {
                menuStrip1.Visible = true;
            }
            if (InformacionUsuario.Administrador == 0)//ventas
            {
                PDashboard.Visible= false;
                PCompras.Visible= false;
                PReportes.Visible= false;
                PProductos.Visible= false;
            }
            if (InformacionUsuario.Administrador == 2)//bodega
            {
                PDashboard.Visible = false;
                PReportes.Visible = false;
                Pventas.Visible= false;
            }
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
            Ventas.Show();
            this.Hide();
        }
        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion Fac = new FrmFacturacion();
            Fac.Show();
            this.Hide();
        }
        private void IconoMenu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }
    }
}