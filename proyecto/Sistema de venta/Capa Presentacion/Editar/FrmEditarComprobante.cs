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
    public partial class FrmEditarComprobante : FormBase
    {
        public FrmEditarComprobante(FrmTipoComprobante TiposComprobantes)
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

        protected void Actualizar()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            UpdatedEventHandler.Invoke(this, args);
        }

        private void FrmEditarComprobante_Load(object sender, EventArgs e)
        {

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
            try
            {
                if (TxtNombreComprobante.Text == string.Empty || TxtTipoComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Tiene que completar todo los campos ", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Comprobante.ID_Comprobante = Convert.ToInt32(Txtidcompro.Text.Trim());
                    Comprobante.Nombre_Comprobante = TxtNombreComprobante.Text.Trim();
                    Comprobante.Tipo_Comprobante = TxtTipoComprobante.Text.Trim();
                    Comprobante.Correlativo = Convert.ToInt32(TxtCorrelativo.Text.Trim());

                    Comprobantes.EditarTipoCompro(Comprobante);
                    MessageBox.Show("Se editó con Exito", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar el comprobante por " + ex.Message, "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
