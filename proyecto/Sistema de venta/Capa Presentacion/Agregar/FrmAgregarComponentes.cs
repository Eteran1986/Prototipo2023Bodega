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
    public partial class FrmAgregarComponentes : FormBase
    {
        public FrmAgregarComponentes(FrmTipoComprobante TiposComprobantes)
        {
            InitializeComponent();
        }
        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();
        CDo_TipoCompro Comprobantes = new CDo_TipoCompro();
        CE_Tipo_Comprobante Comprobante = new CE_Tipo_Comprobante();

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

        private void FrmAgregarComponentes_Load(object sender, EventArgs e)
        {
            TxtCorrelativo.Text = "0";
        }

        private void TxtNombreComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtTipoComprobante.Focus();
                e.Handled = true;
            }
        }

        private void TxtTipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
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
            try
            {
                if(TxtNombreComprobante.Text== string.Empty || TxtTipoComprobante.Text == string.Empty) 
                {
                    MessageBox.Show("Tiene que completar todo los campos ", "Agregar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Comprobante.Nombre_Comprobante = TxtNombreComprobante.Text.Trim();
                    Comprobante.Tipo_Comprobante = TxtTipoComprobante.Text.Trim();
                    Comprobante.Correlativo = Convert.ToInt32(TxtCorrelativo.Text.Trim());

                    Comprobantes.AgregarTipoCompro(Comprobante);
                    MessageBox.Show("Se agreagó con Exito", "Agregar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarTexto(this);
                    TxtNombreComprobante.Focus();
                    TxtCorrelativo.Text = "0";
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se pudo agregar el comprobante por " +ex.Message, "Agregar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
