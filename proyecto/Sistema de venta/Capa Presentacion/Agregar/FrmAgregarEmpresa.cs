﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio; //se agregaron
using Capa_Entidad; // se agregaron
using System.IO; // Se agregaron


namespace Capa_Presentacion
{
    public partial class FrmAgregarEmpresa : FormBase
    {
        public FrmAgregarEmpresa(FrmEmpresa Empresa)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_Empresas Empresas = new CDo_Empresas();
        CE_Empresas Empresa = new CE_Empresas();
        //perimte las carpetas agregar nuestras imagenes en empresas
        OpenFileDialog examinar = new OpenFileDialog(); 

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

        private void FrmAgregarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarFoto_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult Dres = examinar.ShowDialog();
            if(Dres == DialogResult.Abort)
            {
                return;
            }
            if (Dres == DialogResult.Cancel)
            {
                return;
            }
            TxtExaminar.Text = examinar.FileName;
            PtbLogoAgregar.Image= Image.FromFile(examinar.FileName);
        }

        private void TxtNomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtRUCEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtRUCEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDirEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtDirEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MtxtTelefonoEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void MtxtTelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmailEmpresa.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmailEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnGuardarFoto.Focus();
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try
            {
                if (TxtNomEmpresa.Text == "" || TxtRUCEmpresa.Text == "" || TxtDirEmpresa.Text == "" ||
                    MtxtTelefonoEmpresa.Text == "" || TxtEmailEmpresa.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos : ", "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Empresa.Nombre = TxtNomEmpresa.Text.Trim();
                    Empresa.RUC_Empresa = TxtRUCEmpresa.Text.Trim();
                    Empresa.Direccion = TxtDirEmpresa.Text.Trim();
                    Empresa.Telefono = MtxtTelefonoEmpresa.Text.Trim();
                    Empresa.Email = TxtEmailEmpresa.Text.Trim();

                    MemoryStream ms = new MemoryStream();
                    this.PtbLogoAgregar.Image.Save(ms, this.PtbLogoAgregar.Image.RawFormat);
                    Empresa.Logo = ms.GetBuffer();

                    Empresa.Nombre = TxtNomEmpresa.Text.Trim();

                    Empresas.AgregarEmpresa(Empresa);
                    MessageBox.Show("La empresa fue agregado con exito", "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    MtxtTelefonoEmpresa.Text = string.Empty;
                    TxtNomEmpresa.Focus();
                    PtbLogoAgregar.Image = Properties.Resources.sinlogo;
                    Agregar();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La empresa no fue agregada por : " + ex.Message, "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
