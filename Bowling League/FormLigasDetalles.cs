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
            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
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

                Document myDocument = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter.GetInstance(myDocument, new FileStream(fileName, FileMode.Create));
                myDocument.Open();
                myDocument.Add(new Paragraph("ID:"));
                myDocument.Close();
            }
        }
    }
}
