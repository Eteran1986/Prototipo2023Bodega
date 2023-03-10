using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Informes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CapaDatos;
using System.Configuration;
using Capa_Presentacion.Informes.Datos_GeneralesTableAdapters;
using System.CodeDom.Compiler;
using System.Net.Mail;


namespace Capa_Presentacion
{
    public partial class Frm_Fechacaducidad : Form
    {
        public Frm_Fechacaducidad()
        {
            InitializeComponent();
            DTPDesde.MinDate= DateTime.Now;
            DTPHasta.MinDate= DateTime.Now;
        }

        private void Frm_Fechacaducidad_Load(object sender, EventArgs e)
        {

        }

        private int PDF1=0;
        private DateTime _Fecha_Inicio;
        private DateTime _Fecha_Final;

        private int _Id_Ingreso;
        public DateTime Fecha_Inicio { get => _Fecha_Inicio; set => _Fecha_Inicio = value; }
        public int Id_Ingreso { get => _Id_Ingreso; set => _Id_Ingreso = value; }

        public DateTime Fecha_Final { get => _Fecha_Final; set => _Fecha_Final = value; }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            RVRPTFECHA.Visible= false;
            RVRANGOFECHA.Visible= true;
            RVRDias.Visible= false;
            Fecha_Inicio=DTPDesde.Value;
            Fecha_Final = DTPHasta.Value;
            this.mostrar_Inf_FechaTableAdapter.Fill(this.datos_Generales.Mostrar_Inf_Fecha,Fecha_Inicio,Fecha_Final);
            this.RVRANGOFECHA.RefreshReport();
        }
        
        private void BtnTodos_Click(object sender, EventArgs e)
        {
            RVRANGOFECHA.Visible= false;
            RVRPTFECHA.Visible = true;
            RVRDias.Visible = false;
            this.mostrar_InformeFechacaducidadTableAdapter.Fill(this.datos_Generales.Mostrar_InformeFechacaducidad);
            this.RVRPTFECHA.RefreshReport();
        }

        private void BtnAplicarDias_Click(object sender, EventArgs e)
        {
            RVRANGOFECHA.Visible = false;
            RVRPTFECHA.Visible = false;
            RVRDias.Visible = true;
            DTPDesde.MinDate = DateTime.Now;
            DTPHasta.MinDate = DateTime.Now;
            Fecha_Inicio = DTPDesde.MinDate;
            Fecha_Final= DateTime.Now.AddDays(Convert.ToInt32(TxtDias.Text));
            this.mostrar_Inf_FechaTableAdapter.Fill(this.datos_Generales.Mostrar_Inf_Fecha, Fecha_Inicio, Fecha_Final);
            this.RVRDias.RefreshReport();
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            PDF1 = 1;
            PDF();
            PDF1 = 0;
        }

        private void PDF()
        {
            try
            {
                FileStream FS = new FileStream(@"C:\Users\Public\Documents\Reporte.pdf", FileMode.Create);
                Document DOC = new Document(PageSize.LETTER, 13, 13, 13, 13);
                PdfWriter PW = PdfWriter.GetInstance(DOC, FS);

                DOC.Open();
                DOC.AddAuthor("Edgar Terán y Jordan Yanez");
                DOC.AddTitle("Crear PDF");

                iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                DOC.Add(new Paragraph("Informe de Productos por caducar"));
                DOC.Add(new Paragraph("Fecha: "+ DateTime.Now.ToShortDateString()));
                DOC.Add(new Paragraph("Hora: " + DateTime.Now.ToShortTimeString()));
                DOC.Add(Chunk.NEWLINE);
                PdfPTable InformeReporte = new PdfPTable(3);
                InformeReporte.WidthPercentage = 100;

                PdfPCell Cant = new PdfPCell(new Phrase("Cantidad", standarfont));
                Cant.BorderWidth = 0;
                Cant.BorderWidthBottom = 0.75f;

                PdfPCell Nom = new PdfPCell(new Phrase("Nombre", standarfont));
                Nom.BorderWidth = 0;
                Nom.BorderWidthBottom = 0.75f;

                PdfPCell Fechcad = new PdfPCell(new Phrase("Fecha de Caducidad", standarfont));
                Fechcad.BorderWidth = 0;
                Fechcad.BorderWidthBottom = 0.75f;

                InformeReporte.AddCell(Cant);
                InformeReporte.AddCell(Nom);
                InformeReporte.AddCell(Fechcad);

                SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=DBSYSVENBOD;Integrated Security=True");
                SqlCommand Cmd;
                Cmd = new SqlCommand("InformeReporte", Conexion);
                Conexion.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader Dr = Cmd.ExecuteReader();
                while (Dr.Read())
                {
                    Cant = new PdfPCell(new Phrase(Convert.ToString(Dr.GetInt32(0))));
                    Cant.BorderWidth = 0;

                    Nom = new PdfPCell(new Phrase(Dr.GetString(1)));
                    Nom.BorderWidth = 0;

                    Fechcad = new PdfPCell(new Phrase(Convert.ToString(Dr.GetDateTime(2).ToShortDateString())));
                    Fechcad.BorderWidth = 0;

                    InformeReporte.AddCell(Cant);
                    InformeReporte.AddCell(Nom);
                    InformeReporte.AddCell(Fechcad);
                }
                DOC.Add(InformeReporte);
                Conexion.Close();
                Dr.Close();
                DOC.Close();
                PW.Close();
                FS.Close();
                if(PDF1==1)
                {
                    MessageBox.Show("Se creo el pdf con EXITO, Se guardo en el la dirección C:\\Users\\Public\\Documents\\Reporte.pdf", "ReportePDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de cerrar el pdf", "ReportePDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void Correo()
        {
            string EmailOrigen = "eteranb@unemi.edu.ec";
            string EmailDestino = "gusteran1@gmail.com"; //string EmailDestino = "gusteran1@gmail.com, eteranb@unemi.edu.ec"; para dos o mas correos
            string Contraseña = "vuvhaymzdkjnwzfu";
            string DocumentPDF = @"C:\Users\Public\Documents\Reporte.pdf";

            MailMessage Mensaje= new MailMessage(EmailOrigen,EmailDestino,"Informe", "Reporte de los productos prontos a caducar");
            Mensaje.Attachments.Add(new Attachment(DocumentPDF));
            Mensaje.IsBodyHtml= true;

            SmtpClient Cliente= new SmtpClient("smtp.gmail.com");
            Cliente.EnableSsl=true;
            Cliente.UseDefaultCredentials=false;
            Cliente.Port = 587;
            Cliente.Credentials = new System.Net.NetworkCredential(EmailOrigen,Contraseña);

            Cliente.Send(Mensaje);
            Cliente.Dispose();
            Mensaje.Dispose();
            MessageBox.Show("Se envió el correo con EXITO", "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            PDF();
            Correo();
        }

    }
}
