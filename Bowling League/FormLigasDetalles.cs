using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Bowling_League
{
    public partial class FormLigasDetalles : Form
    {
        public FormLigasDetalles()
        {
            InitializeComponent();
        }


        public int idliga = 0;
        public string Permiso = "";
        int idrol = 0;
        public int idjugador = 0;
        public void Buscar()
        {
            //Obtener el primer idrol de la semana seleccionada
            int idprimerrol = Convert.ToInt16(rolesTableAdapter.Getprimeridrol(Convert.ToInt16(cbSemana.Text), idliga));
            //Generar valor id base para usarlo de referencia y obtener el idrol de el numero de juego seleccionado
            int idbase = idprimerrol - 1;
            //Obtener el idrol con el idbase y el cb de numero de juego
            idrol = idbase + 1;
            DateTime dat = Convert.ToDateTime(rolesTableAdapter.Getfecharol(idrol));
            lblfecha.Text = "(" + dat.ToString("dd/MM/yyyy") + ")";
            ligas_DetalleXEquiposTableAdapter.Fill(this.bL_LigasDetalles.Ligas_DetalleXEquipos, Convert.ToInt16(cbSemana.Text), idliga);
            for (int i = 0; i < ligas_DetalleXEquiposDataGridView.Rows.Count; i++)
            {
                ligas_DetalleXEquiposDataGridView.Rows[i].Cells["Posicion"].Value = "#" + (i + 1);
            }
        }
        private void FormLigasDetalles_Load(object sender, EventArgs e)
        {
            
            string nombreliga = ligasTableAdapter.Getnombreliga(idliga);
            lblliga.Text = "Detalles por equipo\n" + "(" + nombreliga + ")";
            //Lenar el combobox de semana con la cantidad de semanas de la liga
            int cantidadsemanas = Convert.ToInt16(rolesTableAdapter.Getcantidadsemanas(idliga));
            for (int i = 1; i <= cantidadsemanas; i++)
            {
                cbSemana.Items.Add(i);
            }
            cbSemana.Text = "" + 1;
            Buscar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.idjugador = idjugador;
            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public string diasemana(DateTime fec)
        {
            if (fec.ToString("ddd") == "Mon")
            {
                return "Lunes";
            }
            else if (fec.ToString("ddd") == "Tue")
            {
                return "Martes";
            }
            else if (fec.ToString("ddd") == "Wed")
            {
                return "Miercoles";
            }
            else if (fec.ToString("ddd") == "Thu")
            {
                return "Jueves";
            }
            else if (fec.ToString("ddd") == "Fri")
            {
                return "Viernes";
            }
            else if (fec.ToString("ddd") == "Sat")
            {
                return "Sabado";
            }
            else if (fec.ToString("ddd") == "Sun")
            {
                return "Domingo";
            }
            return "Dia";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 0;

            string fileName = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                Document myDocument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 12, 35);
                PdfWriter pw = PdfWriter.GetInstance(myDocument, new FileStream(fileName, FileMode.Create));
                myDocument.Open();

                //myDocument.Add(imagen);
                //HEADER
                
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("Logo.png");
                float percentage = 0.0f;
                percentage = 80 / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                PdfPCell icell = new PdfPCell(imagen);
                icell.Border = 0;
                
                PdfPTable tbHeader = new PdfPTable(3);
                tbHeader.WidthPercentage = 100f;
                tbHeader.DefaultCell.Border = 0;
                tbHeader.AddCell(icell);
                
                //Titulo
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                iTextSharp.text.Font fontText = new iTextSharp.text.Font(bf, 18, 1, BaseColor.BLACK);
                string nombreliga = ligasTableAdapter.Getnombreliga(idliga);
                PdfPCell hcell = new PdfPCell(new Paragraph("\n"+nombreliga+"\nResultados Sem. #"+cbSemana.Text, fontText));
                hcell.HorizontalAlignment = Element.ALIGN_CENTER;
                hcell.Border = 0;
                tbHeader.AddCell(hcell);

                //Info de la liga
                bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                fontText = new iTextSharp.text.Font(bf, 10, 2, BaseColor.BLACK);
                //Nombre del boliche
                //Ciudad + estado
                //Presidente
                string boliche = ligasTableAdapter.GetBoliche(idliga);
                string city = ligasTableAdapter.GetCiudadJuego(idliga);
                string presi = ligasTableAdapter.GetPresidente(idliga).ToString();
                DateTime dat = Convert.ToDateTime(ligasTableAdapter.GetFechaInicio(idliga));

                string fechahora = diasemana(dat)+" "+ligasTableAdapter.Gethora(idliga);
                hcell = new PdfPCell(new Paragraph("\n\n" + boliche + "\n" + city+" "+fechahora+"\nPte. "+ presi, fontText));
                hcell.HorizontalAlignment = Element.ALIGN_RIGHT;
                hcell.Border = 0;
                tbHeader.AddCell(hcell);

                myDocument.Add(tbHeader);
                //Crea una tabla de 9 columnas referentes a la del datagridview
                PdfPTable table = new PdfPTable(9);
                table.WidthPercentage = 90f;
                //Elegir tipo de letra, tipo de texto y color, EMBEDDED es para la compatibilidad del font en otros equipos

                #region para la primer colmna
                bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                fontText = new iTextSharp.text.Font(bf, 10, 0, BaseColor.WHITE);
                PdfPCell cell = new PdfPCell();

                cell = new PdfPCell(new Paragraph("Posicion", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112,173,71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Equipo", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Total Juegos Ganados", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Total Juegos Perdidos", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Total Pinos Acumulados", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("JG Ultima Semana", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("JP Ultima Semana", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Juego Alto", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);

                cell = new PdfPCell(new Paragraph("Serie Alta", fontText));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = new BaseColor(112, 173, 71);
                table.AddCell(cell);
                #endregion

                
                iTextSharp.text.Font fontText1 = new iTextSharp.text.Font(bf, 10, 0, BaseColor.BLACK);

                for (int i = 0; i < ligas_DetalleXEquiposDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        cell = new PdfPCell(new Paragraph(ligas_DetalleXEquiposDataGridView.Rows[i].Cells[j].Value.ToString(), fontText1));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = new BaseColor(204, 255, 153);
                        table.AddCell(cell);
                    }
                    

                }

                


                myDocument.Add(table);
                myDocument.Close();

                FormVistaPreviaReporte vp = new FormVistaPreviaReporte();
                vp.file = fileName;
                vp.ShowDialog();
            }
        }
    }
    
}
