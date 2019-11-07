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
    public partial class FormJugadores : Form
    {
        public FormJugadores()
        {
            InitializeComponent();
        }

        public string Permiso = "";
        int id = 0;
        private void Search()
        {
                jugadoresTableAdapter.BuscarJugador(this.bL_DBDataSet.Jugadores,txtBuscar.Text);  
        }
        private void FromNuevoJugador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBDataSet.Jugadores' table. You can move, or remove it, as needed.
            this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);
            id = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].Id_Jugador;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (no_jugadorTextBox.Text == "" || nombreTextBox.Text == "" || apellidoPaternoTextBox.Text == "" || apellidoMaternoTextBox.Text == "" ||
                ciudadNacimientoTextBox.Text == "" || estadoNacimientoTextBox.Text == "" || fechaNacimientoDateTimePicker.Text == "" ||
                cbSexo.Text == "" || cbPuesto.Text == "")//Revisar que tenga toda la informacion personal
                {
                    MessageBox.Show("Por favor ingrese todos los datos personales");
                }
                else if (passwordTextBox.Text == "" || txtConfirmpass.Text == "")//Revisar la contraseña, Si no la ingreso, no se cambia la contraseña
                {
                    string contra = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].Password;
                    jugadoresTableAdapter.UpdateJugador(Convert.ToInt16(no_jugadorTextBox.Text), nombreTextBox.Text, apellidoPaternoTextBox.Text, apellidoMaternoTextBox.Text, ciudadNacimientoTextBox.Text,
                        estadoNacimientoTextBox.Text, fechaNacimientoDateTimePicker.Text, cbSexo.Text, cbPuesto.Text, Convert.ToInt16(nmPinosEnt.Value), Convert.ToInt16(nmHandycap.Value),
                        Convert.ToInt16(nmHGS.Value), Convert.ToInt16(nmHSS.Value), Convert.ToInt16(nmHGH.Value), Convert.ToInt16(nmPinos.Value), Convert.ToInt16(nmJuegosJugados.Value), nmPromedio.Value, contra, id);
                    MessageBox.Show("Datos actualizados correctamente");
                }
                else if (passwordTextBox.Text != txtConfirmpass.Text)//Revisar que coincidan
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                {
                    jugadoresTableAdapter.UpdateJugador(Convert.ToInt16(no_jugadorTextBox.Text), nombreTextBox.Text, apellidoPaternoTextBox.Text, apellidoMaternoTextBox.Text, ciudadNacimientoTextBox.Text,
                        estadoNacimientoTextBox.Text, fechaNacimientoDateTimePicker.Text, cbSexo.Text, cbPuesto.Text, Convert.ToInt16(nmPinosEnt.Value), Convert.ToInt16(nmHandycap.Value),
                        Convert.ToInt16(nmHGS.Value), Convert.ToInt16(nmHSS.Value), Convert.ToInt16(nmHGH.Value), Convert.ToInt16(nmPinos.Value), Convert.ToInt16(nmJuegosJugados.Value), nmPromedio.Value, passwordTextBox.Text, id);
                    MessageBox.Show("Datos actualizados correctamente");
                }
                this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);
            }
            catch (Exception ex)//Excepcion del atributo UNIQUE del numero de jugador
            {

                MessageBox.Show("Error durante la actualizacion, asegurese de que el numero no este repetido con el de otro jugador");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoJugador nj = new FormNuevoJugador();
            nj.ShowDialog();
            this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);
        }

        private void jugadoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].Id_Jugador;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Setea los campos del jugador de acuerdo a los datos del jugador seleccionado(Quita Cambios)
            this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);
        }

        private void no_jugadorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Revisar que el numero de jugador ingresado sea igual al que tiene actualmente para descartarlo de la comparacion
                bool ismynumber = Convert.ToInt32(no_jugadorTextBox.Text) == bL_DBDataSet.Jugadores[jugadoresBindingSource.Position].No_jugador;
                if (jugadoresTableAdapter.ExistNumJugador(Convert.ToInt32(no_jugadorTextBox.Text)) == 1)
                {
                    no_jugadorTextBox.BackColor = Color.Red;
                    no_jugadorTextBox.ForeColor = Color.White;
                }
                else if (jugadoresTableAdapter.ExistNumJugador(Convert.ToInt32(no_jugadorTextBox.Text)) == 0 || ismynumber)
                {
                    no_jugadorTextBox.BackColor = Color.Lime;
                    no_jugadorTextBox.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
