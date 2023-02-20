using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Se agregaron
using Capa_Dominio; //Se agregaron
using Capa_Entidad; // Se agregaron

namespace Capa_Presentacion
{
    public partial class FrmProductos : FormBase
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        CDo_Procedimientos procedimiento = new CDo_Procedimientos();
        CDo_Productos Productos= new CDo_Productos();
        CE_Productos Producto = new CE_Productos();         
        private void Frmproductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.Columns[0].Visible= false; //idproducto
            dataGridView1.Columns[1].Visible = false; //idcategoria
            dataGridView1.Columns[2].Width = 130; //codigo del producto
            dataGridView1.Columns[3].Width = 260; //nombre del producto
            dataGridView1.Columns[4].Width = 300; //descripcion del producto
            dataGridView1.Columns[5].Width = 150; //presentacion del producto
            dataGridView1.Columns[6].Width = 140; //costo unitario del producto
            dataGridView1.Columns[7].Width = 140; //precio del producto
            dataGridView1.Columns[8].Width = 150; //Tipo del producto
            
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            procedimiento.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource= procedimiento.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }

        private void AgPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProducto.UpdatedEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregarProducto = new FrmAgregarProducto(this);
            agregarProducto.UpdatedEventHandler += AgPro_UpdateEventHandler;
            agregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro que editar","Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                try //validación de seleccion de producto para editarlo
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarProducto editarProducto = new FrmEditarProducto(this);
                        editarProducto.UpdatedEventHandler += EdPro_UpdateEventHandler;
                        editarProducto.txtID_Productos.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarProducto.txtCodProducto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarProducto.txtNomProducto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarProducto.txtDescripcionProducto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarProducto.txtPresentacion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        editarProducto.txtCostoUnitario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        editarProducto.txtPrecioVenta.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        editarProducto.cboTipoCargo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        editarProducto.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un producto para editar","Editar Producto" + ex.Message, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(); 
        }

        public override void Eliminar()
        {
            if(dataGridView1.Rows.Count== 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Estas seguro de eliminar este producto", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados== DialogResult.Yes)
                        {
                            Producto.ID_Producto= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminar", "Eliminar Producto" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if (CboTipoBusqueda.Text == "Código")
                {
                    Producto.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource= Productos.Buscar_Prod_Codigo(Producto);
                }
                else if(CboTipoBusqueda.Text== "Nombre")
                {
                    Producto.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Prod_Nombre(Producto);
                }
                else if (CboTipoBusqueda.Text == "Descripción")
                {
                    Producto.Buscar = TxtBuscar.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Prod_Descripcion(Producto);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado : " +ex.Message ,"Buscar Producto",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
 