using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Capa_Dominio;
using Capa_Entidad.Cache;
using CapaDatos;
namespace Capa_Presentacion
{
    public partial class FrmDashboardcs : FormBase
    {
        public FrmDashboardcs()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Server=DESKTOP-79UE8TF;DataBase=DBSYSVENBOD; Integrated Security=true");
        SqlCommand Cmd;
        SqlDataReader Dr;
        //DataTable Dt;

        ArrayList Categoria = new ArrayList();
        ArrayList CanProd = new ArrayList();
        ArrayList NombrePro = new ArrayList();
        ArrayList CanFechaCad = new ArrayList();
        ArrayList Categoria1 = new ArrayList();
        ArrayList CanFecha = new ArrayList();

        private void FrmDashboardcs_Load(object sender, EventArgs e)
        {
            CategoriaGrafico();
            DashboardPanel();
            CategoriaGrafico2();
        }

        private void CategoriaGrafico()
        {
            Cmd = new SqlCommand("ProducFecha", Conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                Categoria1.Add(Dr.GetString(0));
                CanFecha.Add(Dr.GetInt32(1));
            }
            CircleCF.Series[0].Points.DataBindXY(Categoria1, CanFecha);
            Dr.Close();
            Conexion.Close();
        }
        private void CategoriaGrafico2()
        {
            Cmd = new SqlCommand("ProducCategoria", Conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                Categoria.Add(Dr.GetString(0));
                CanProd.Add(Dr.GetInt32(1));
            }
            CircleCP.Series[0].Points.DataBindXY(Categoria, CanProd);
            Dr.Close();
            Conexion.Close();
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombrePro.Clear();
            CanFechaCad.Clear();
            Cmd = new SqlCommand("FechaCadProduc1", Conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            Dr = Cmd.ExecuteReader();
            string a;
                while (Dr.Read())
                {
                    a= Dr.GetString(2);
                    if (CboCategoria.Text == a)
                        {
                            NombrePro.Add(Dr.GetString(0));
                            CanFechaCad.Add(Dr.GetInt32(1));
                         }
                }
            StackerBar.Series[0].Points.DataBindXY(NombrePro, CanFechaCad);
            Dr.Close();
            Conexion.Close();
        }
        private void DashboardPanel()
        {
            Cmd = new SqlCommand("DashboardDatos", Conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter ComprasT = new SqlParameter("@ComprasT",0.00);
            SqlParameter Productos = new SqlParameter("@Productos",0);
            SqlParameter Usuarios = new SqlParameter("@Usuarios", 0);
            SqlParameter Proveedores = new SqlParameter("@Proveedores", 0);
            SqlParameter categorias = new SqlParameter("@categorias", 0);

            ComprasT.Direction = ParameterDirection.Output;
            Productos.Direction = ParameterDirection.Output;
            Usuarios.Direction = ParameterDirection.Output;
            Proveedores.Direction = ParameterDirection.Output;
            categorias.Direction = ParameterDirection.Output;

            Cmd.Parameters.Add(ComprasT);
            Cmd.Parameters.Add(Productos);
            Cmd.Parameters.Add(Usuarios);
            Cmd.Parameters.Add(Proveedores);
            Cmd.Parameters.Add(categorias);

            Conexion.Open();
            Cmd.ExecuteNonQuery();

            LCompras.Text= Cmd.Parameters["@ComprasT"].Value.ToString();
            LProductos.Text = Cmd.Parameters["@Productos"].Value.ToString();
            LUsuarios.Text = Cmd.Parameters["@Usuarios"].Value.ToString();
            LProveedor.Text = Cmd.Parameters["@Proveedores"].Value.ToString();
            LCategoria.Text = Cmd.Parameters["@categorias"].Value.ToString();
            Conexion.Close();
        }
    }
}
