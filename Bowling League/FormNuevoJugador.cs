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
    public partial class FormNuevoJugador : Form
    {
        public FormNuevoJugador()
        {
            InitializeComponent();
        }

        private void jugadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBDataSet);

        }

        private void FormNuevoJugador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBDataSet.Jugadores' table. You can move, or remove it, as needed.
            this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);

        }

        private void button1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Por favor ingrese la contraseña en ambos campos");
                }
                else if (passwordTextBox.Text != txtConfirmpass.Text)//Revisar que coincidan
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                {
                    jugadoresTableAdapter.NuevoJugador(Convert.ToInt16(no_jugadorTextBox.Text), nombreTextBox.Text, apellidoPaternoTextBox.Text, apellidoMaternoTextBox.Text, ciudadNacimientoTextBox.Text,
                        estadoNacimientoTextBox.Text, fechaNacimientoDateTimePicker.Text, cbSexo.Text, cbPuesto.Text, Convert.ToInt16(nmPinosEnt.Value), Convert.ToInt16(nmHandycap.Value),
                        Convert.ToInt16(nmHGS.Value), Convert.ToInt16(nmHSS.Value), Convert.ToInt16(nmHGH.Value), Convert.ToInt16(nmPinos.Value), Convert.ToInt16(nmJuegosJugados.Value), nmPromedio.Value, passwordTextBox.Text);
                    MessageBox.Show("Datos ingresados correctamente");
                    this.Close();
                }
                this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);
            }
            catch (Exception)
            {

                MessageBox.Show("Error durante la insersion, asegurese de que el numero sea valido y no este repetido con el de otro jugador");
            }
        }

        private void no_jugadorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (jugadoresTableAdapter.ExistNumJugador(Convert.ToInt32(no_jugadorTextBox.Text)) == 1)
                {
                    Validacion.SetHighlightColor(no_jugadorTextBox, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
         
                }
                else if (jugadoresTableAdapter.ExistNumJugador(Convert.ToInt32(no_jugadorTextBox.Text)) == 0)
                {
                    Validacion.SetHighlightColor(no_jugadorTextBox, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
                  
                }
            }
            catch (Exception)
            {
                Validacion.SetHighlightColor(no_jugadorTextBox, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                
            }
        }
    }
}
