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
    public partial class FormNuevaLiga : Form
    {
        public FormNuevaLiga()
        {
            InitializeComponent();
        }
        public string Permiso = "";
        public int idpresid;
        public int idsecret;
        public int idtesor;
        public DateTime[] fechas;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();

            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();
        }

        private void FormNuevaLiga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_RolesDS.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.bL_RolesDS.Roles);
            // TODO: This line of code loads data into the 'bL_LigasDS.Ligas' table. You can move, or remove it, as needed.
            DateTime dayvalue = fechaInicioDateTimePicker.Value;
            lbldia.Text = ("(Se jugara cada " + diasemana(dayvalue) + ")");

        }

        private void fechaInicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dayvalue = fechaInicioDateTimePicker.Value;
            lbldia.Text = ("(Se jugara cada " + diasemana(dayvalue) + ")");

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnRecorrer.Enabled = true;
        }

        private void txtRecorrer_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Las fechas a partir de la semana seleccionada se recorreran una semana \n Desea continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indice = listBox1.SelectedIndex;
                int juegos = Convert.ToInt16(numericUpDown2.Value / 2);
                for (int i = indice; i < listBox1.Items.Count; i++)
                {
                    if (indice != -1)
                    {
                        fechas[i] = fechas[i].AddDays(7);
                        listBox1.Items[i] = "Semana " + i + ": " + fechas[i].ToString("d/MM/yyyy") + ", juegos por semana: " + juegos;
                    }
                    lblfechafin.Text = "Fecha Final: " + fechas[fechas.Length - 1].ToString("d/MM/yyyy");
                }

            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value % 2 != 0)
            {
                MessageBox.Show("La cantidad de equipos debe ser par");
            }
            else 
            {
                //NumericUD1 = Cantidad de semanas
                //NumericUD2 = cantidad de equipos
                btnRecorrer.Enabled = false;
                listBox1.Items.Clear();//Si hay fechas generadas limpia el listbox
                DateTime fecha = fechaInicioDateTimePicker.Value;
                fechas = new DateTime[Convert.ToInt16(numericUpDown1.Value)];//Crear una lista de fechas con la cantidad de semanas
                int juegos = Convert.ToInt16(numericUpDown2.Value / 2);
                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    fechas[i-1] = fecha;//Almacenar fecha en lista 
                    listBox1.Items.Add("Semana " + i + ": " + fecha.ToString("d/MM/yyyy")+", juegos por semana: "+juegos);
                    fecha = fecha.AddDays(7);
                    
                }
                fecha = fecha.AddDays(-7);//Deshacer el ultimo comando del for para mostrar la fecha final
                lblfechafin.Text = "Fecha Final: " + fechas[fechas.Length-1].ToString("d/MM/yyyy");
               

            }
            
        }

        private void button1_Click(object sender, EventArgs e)//Presidente
        {
            
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "Presidente";
            fs.ShowDialog();
            nombrePresidenteTextBox.Text = fs.nombre;
            idpresid = fs.id;
        }

        private void button2_Click(object sender, EventArgs e)//Tesorero
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "Tesorero";
            fs.ShowDialog();
            nombreTesoreroTextBox.Text = fs.nombre;
            idtesor = fs.id;
        }

        private void button3_Click(object sender, EventArgs e)//Secretario General
        {
            FormSeleccionarJugador fs = new FormSeleccionarJugador();
            fs.parameter = "Secretario General";
            fs.ShowDialog();
            nombreSecretarioGralTextBox.Text = fs.nombre;
            idsecret = fs.id;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Permiso = Permiso;
            m.FormClosed += (s, args) => this.Close();
            m.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (nombre_de_ligaTextBox.Text == "" || comboBox1.Text == "" || cbhora.Text == "" || cbminuto.Text == "" || cbampm.Text == "" || nombreBolicheTextBox.Text == "" || ciudadJuegoTextBox.Text == "")//Verificar que el area de datos no este vacia
            {
                MessageBox.Show("Por favor ingrese todos los datos de la liga");
            }
            else if (nombrePresidenteTextBox.Text == "" || nombreTesoreroTextBox.Text == "" || nombreSecretarioGralTextBox.Text == "")//Verificar representantes
            {
                MessageBox.Show("Por favor ingrese a todos los representantes de la liga");
            }
            else if (listBox1.Items.Count == 0)//Solo se necesitan las semanas generadas con los datos previos
            {
                MessageBox.Show("Por favor indique las fechas de la liga");
            }
            else
            {
                try
                {
                    //MessageBox.Show("Las fechas a partir de la semana seleccionada se recorreran una semana \n Desea continuar?", "Confirmar", MessageBoxButtons.OK)

                        //Crear Liga
                    ligasTableAdapter.NuevaLiga(nombre_de_ligaTextBox.Text, nombreBolicheTextBox.Text,
                        ciudadJuegoTextBox.Text, fechaInicioDateTimePicker.Value.ToString(),
                        fechas[fechas.Length - 1].ToString(), (cbhora.Text + ":" + cbminuto.Text + cbampm.Text),
                        comboBox1.Text, Convert.ToInt16(numericUpDown2.Value),
                        idpresid, idtesor, idsecret);

                    //Insertar Roles 

                    int id = Convert.ToInt16(ligasTableAdapter.GetUltimoid());//Obtener el id de la ultima liga ingresada previamente
                    int x = 0;
                    
                    for (int i = 1; i <= numericUpDown1.Value; i++)//Por cada semana
                    {
                        for (int j = 1; j <= (numericUpDown2.Value / 2); j++)//Por cada dupla de equipos
                        {

                            rolesTableAdapter.NuevoRol(id,i,fechas[x].ToString());
                        }
                        x++;//La fecha se va a cambiar cada semana, no cada juego
                    }
                    MessageBox.Show("Datos ingresados correctamente");

                    //Vaciar controles y ids
                    listBox1.Items.Clear();
                    nombre_de_ligaTextBox.Text = "";
                    nombreBolicheTextBox.Text = "";
                    ciudadJuegoTextBox.Text = "";
                    cbhora.Text = "";
                    cbminuto.Text = "";
                    cbampm.Text = "";
                    comboBox1.Text = "";
                    nombrePresidenteTextBox.Text = "";
                    nombreTesoreroTextBox.Text = "";
                    nombreSecretarioGralTextBox.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Error de insersion");

                }

            }
        }
    }
}
