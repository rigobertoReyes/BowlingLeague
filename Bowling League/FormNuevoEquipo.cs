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
    public partial class FormNuevoEquipo : Form
    {
        public FormNuevoEquipo()
        {
            InitializeComponent();
        }

        private void FormNuevoEquipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBEquiposDS.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.bL_DBEquiposDS.Equipos);

        }
        //
        public int idi1 = 0;
        public int idi2 = 0;
        public int idi3 = 0;
        public int idi4 = 0;
        public int idi5 = 0;
        public int ids1 = 0;
        public int ids2 = 0;
        private void btnagregari1_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombrei1.Text = "Nombre:" + fs.nombre;
            numeroi1.Text = "No Jugador" + fs.numero;
            idi1 = fs.id;

        }

        private void btnagregari2_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombrei2.Text = "Nombre:" + fs.nombre;
            numeroi2.Text = "No Jugador" + fs.numero;
            idi2 = fs.id;
        }

        private void btnagregari3_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombrei3.Text = "Nombre:" + fs.nombre;
            numeroi3.Text = "No Jugador" + fs.numero;
            idi3 = fs.id;
        }

        private void btnagregari4_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombrei4.Text = "Nombre:" + fs.nombre;
            numeroi4.Text = "No Jugador" + fs.numero;
            idi4 = fs.id;
        }

        private void btnagregari5_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombrei5.Text = "Nombre:" + fs.nombre;
            numeroi5.Text = "No Jugador" + fs.numero;
            idi5 = fs.id;
        }

        private void btnagregars1_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombres1.Text = "Nombre:" + fs.nombre;
            numeros1.Text = "No Jugador" + fs.numero;
            ids1 = fs.id;
        }

        private void btnagregars2_Click(object sender, EventArgs e)
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "integrante";
            //Darle como parametro a los jugadores ya registrados para evitar duplicados
            fs.i1 = idi1;
            fs.i2 = idi2;
            fs.i3 = idi3;
            fs.i4 = idi4;
            fs.i5 = idi5;
            fs.s1 = ids1;
            fs.s2 = ids2;

            fs.ShowDialog();
            nombres2.Text = "Nombre:" + fs.nombre;
            numeros2.Text = "No Jugador" + fs.numero;
            ids2 = fs.id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombre_de_equipoTextBox.Text == "" || no_EquipoTextBox.Text == "")//Revisar que tenga nombre y numero de equipo
                {
                    MessageBox.Show("Por favor ingrese nombre y numero de equipo");
                }
                else if (idi1 == 0)
                {
                    MessageBox.Show("Por favor ingrese un jugador en integrante 1");
                }
                else
                {
                    equiposTableAdapter.NuevoEquipo(Convert.ToInt16(no_EquipoTextBox.Text), nombre_de_equipoTextBox.Text, idi1, idi2, idi3, idi4,
                        idi5, ids1, ids2);
                    MessageBox.Show("Datos ingresados correctamente");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error durante la insersion, asegurese de que el numero sea valido y no este repetido con el de otro equipo");
            }
            
           
        }

        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBEquiposDS);

        }

        private void no_EquipoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (equiposTableAdapter.Existsnumero(Convert.ToInt32(no_EquipoTextBox.Text)) == 1)
                {
                    no_EquipoTextBox.BackColor = Color.Red;
                    no_EquipoTextBox.ForeColor = Color.White;
                }
                else if (equiposTableAdapter.Existsnumero(Convert.ToInt32(no_EquipoTextBox.Text)) == 0)
                {
                    no_EquipoTextBox.BackColor = Color.Lime;
                    no_EquipoTextBox.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {
                no_EquipoTextBox.BackColor = SystemColors.Window;
                no_EquipoTextBox.ForeColor = SystemColors.WindowText;
            }
            
           
        }
    }
}
