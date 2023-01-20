﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongTimeString();
            lbldia.Text = DateTime.Now.ToLongDateString();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos Productos= new FrmProductos();
            Productos.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}