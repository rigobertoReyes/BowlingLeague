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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }
        public string Permiso = "";
        int idteam;
        public int idi1 = 0;
        public int idi2 = 0;
        public int idi3 = 0;
        public int idi4 = 0;
        public int idi5 = 0;
        public int ids1 = 0;
        public int ids2 = 0;
        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBEquiposDS);

        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBEquiposDS.Jugadores' table. You can move, or remove it, as needed.
            this.jugadoresTableAdapter.Fill(this.bL_DBEquiposDS.Jugadores);
            // TODO: This line of code loads data into the 'bL_DBEquiposDS.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.Fill(this.bL_DBEquiposDS.Equipos);

            //Poner texto de integrante 1
            nombrei1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1);
            numeroi1.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1);
            idi1 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1;
            //Poner texto de integrante 2
            try
            {
                nombrei2.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2);
                numeroi2.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2);
                idi2 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2;
            }
            catch (Exception)
            {
                nombrei2.Text = "Nombre:";
                numeroi2.Text = "Numero";
                idi2 = 0;
            }
            //Poner texto de integrante 3
            try
            {
                nombrei3.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3);
                numeroi3.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3);
                idi3 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3;
            }
            catch (Exception)
            {
                nombrei3.Text = "Nombre:";
                numeroi3.Text = "Numero";
                idi3 = 0;
            }
            //Poner texto de integrante 4
            try
            {
                nombrei4.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4);
                numeroi4.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4);
                idi4 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4;

            }
            catch (Exception)
            {
                nombrei4.Text = "Nombre:";
                numeroi4.Text = "Numero";
                idi4 = 0;
            }
            //Poner texto de integrante 5
            try
            {
                nombrei5.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5);
                numeroi5.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5);
                idi5 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5;
            }
            catch (Exception)
            {
                nombrei5.Text = "Nombre:";
                numeroi5.Text = "Numero";
                idi4 = 0;
            }
            //Poner texto de suplente 1
            try
            {
                nombres1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1);
                numeros1.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1);
                ids1 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1;
            }
            catch (Exception)
            {
                nombres1.Text = "Nombre:";
                numeros1.Text = "Numero";
                ids1 = 0;
            }
            //Poner texto de suplente 2
            try
            {
                nombres1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2);
                numeros2.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2);
                ids2 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2;
            }
            catch (Exception)
            {
                nombres1.Text = "Nombre:";
                numeros2.Text = "Numero";
                ids2 = 0;
            }

        }

        private void equiposDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Regresa a menu
            this.Hide();
            Menu m = new Menu();
            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();
        }

        private void equiposDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Poner texto de integrante 1
            nombrei1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1);
            numeroi1.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1);
            idi1 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante1;
            //Poner texto de integrante 2
            try
            {
                nombrei2.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2);
                numeroi2.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2);
                idi2 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante2;
            }
            catch (Exception)
            {
                nombrei2.Text = "Nombre:";
                numeroi2.Text = "Numero";
                idi2 = 0;
            }
            //Poner texto de integrante 3
            try
            {
                nombrei3.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3);
                numeroi3.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3);
                idi3 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante3;
            }
            catch (Exception)
            {
                nombrei3.Text = "Nombre:";
                numeroi3.Text = "Numero";
                idi3 = 0;
            }
            //Poner texto de integrante 4
            try
            {
                nombrei4.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4);
                numeroi4.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4);
                idi4 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante4;
        
            }
            catch (Exception)
            {
                nombrei4.Text = "Nombre:";
                numeroi4.Text = "Numero";
                idi4 = 0;
            }
            //Poner texto de integrante 5
            try
            {
                nombrei5.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5);
                numeroi5.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5);
                idi5 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Integrante5;
            }
            catch (Exception)
            {
                nombrei5.Text = "Nombre:";
                numeroi5.Text = "Numero";
                idi4 = 0;
            }
            //Poner texto de suplente 1
            try
            {
                nombres1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1);
                numeros1.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1);
                ids1 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente1;
            }
            catch (Exception)
            {
                nombres1.Text = "Nombre:";
                numeros1.Text = "Numero";
                ids1 = 0;
            }
            //Poner texto de suplente 2
            try
            {
                nombres1.Text = "Nombre: " + jugadoresTableAdapter.Getnombre(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2);
                numeros2.Text = "No Jugador: " + jugadoresTableAdapter.Getnumero(bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2);
                ids2 = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Suplente2;
            }
            catch (Exception)
            {
                nombres1.Text = "Nombre:";
                numeros2.Text = "Numero";
                ids2 = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            nombrei1.Text ="Nombre:" + fs.nombre;
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                idteam = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Id_Equipo;
                if (no_EquipoTextBox.Text == "" || nombre_de_equipoTextBox.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el numero y nombre del equipo");
                }
                else if (idi1 == 0)//Si no hay integrante 1 (Obligario)
                {
                    MessageBox.Show("Por favor ingrese un jugador en integrante 1");
                }
                else
                {

                    equiposTableAdapter.UpdateEquipo(Convert.ToInt16(no_EquipoTextBox.Text), nombre_de_equipoTextBox.Text,
                        idi1, Convert.ToInt16(idi2), Convert.ToInt16(idi3), Convert.ToInt16(idi4), idi5,
                        Convert.ToInt16(ids1), Convert.ToInt16(ids2), idteam);
                    MessageBox.Show("Datos actualizados correctamente");
                    this.equiposTableAdapter.Fill(this.bL_DBEquiposDS.Equipos);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error durante la insersion, asegurese de que el numero sea valido y no este repetido con el de otro equipo");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormNuevoEquipo ne = new FormNuevoEquipo();
            ne.ShowDialog();
            this.equiposTableAdapter.Fill(this.bL_DBEquiposDS.Equipos);
        }
    }
}