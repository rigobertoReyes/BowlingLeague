using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling_League
{
    public partial class FormSeleccionarJugador : Form
    {
        public FormSeleccionarJugador()
        {
            InitializeComponent();
        }
        public string parameter = "";
        public string nombre;
        public string numero;
        public int id;
        public int i1, i2, i3, i4, i5, s1, s2;
        private void FormSeleccionarJugador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBDataSet.Jugadores' table. You can move, or remove it, as needed.
            if (parameter != "integrante")
            {
                this.jugadoresTableAdapter.FillByPuesto(this.bL_DBDataSet.Jugadores, parameter, "");
            }
            else
            {
                jugadoresTableAdapter.FillBynopuesto(this.bL_DBDataSet.Jugadores, textBox1.Text, i1, i2, i3, i4, i5, s1, s2);
            }
            
            
            lblTitulo.Text = "Selecciona un " + parameter;
        }

        private void jugadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBDataSet);

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (parameter != "integrante")
            {
                jugadoresTableAdapter.FillByPuesto(this.bL_DBDataSet.Jugadores, parameter, textBox1.Text);
            }
            else
            {
                jugadoresTableAdapter.FillBynopuesto(this.bL_DBDataSet.Jugadores,textBox1.Text,i1, i2, i3, i4, i5, s1, s2);
            }
            
                

        }

        private void jugadoresDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].Nombre + " " +
               bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].ApellidoPaterno + " " +
               bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].ApellidoMaterno;
            id = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].Id_Jugador;
            numero = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].No_jugador.ToString();


            this.Close();
        }
    }
}
