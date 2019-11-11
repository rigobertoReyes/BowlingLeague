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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public string Permiso = "Administrador";
        public int idjugaodr = 0;
        public int idliga = 0;
        private void Menu_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'bL_LigasDS.Ligas' table. You can move, or remove it, as needed.

            this.ligasTableAdapter.FillMenu(this.bL_LigasDS.Ligas);
            if (Permiso!="Jugador")
            {
                if (Permiso !="Administrador")
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button5.Visible = false;
                    btnEliminarLiga.Visible = false;
                }
                
            }
            else
            {
                //Dejar solo botones de resultados de liga

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                btnEliminarLiga.Visible = false;
            }
            //Cargar datos de la liga con la primer liga enlistada
            idliga = bL_LigasDS.Ligas[ligasBindingSource.Position].Id_Liga;
            lblNombreLiga.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].Nombre_de_liga.ToString();
            lblPresidente.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NPresidente.ToString();
            lblTesorero.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NTesorero.ToString();
            lblSecretarioG.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NSecretario.ToString();
            lblNombrebol.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NombreBoliche.ToString();
            lblCiudad.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].CiudadJuego.ToString();
            lblFechainicio.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaInicio.ToString("dd/MM/yyyy");
            DateTime dateValue = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaInicio;
            lblDiajuego.Text = (diasemana(dateValue)).ToString();
            lblFechafinal.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaFinal.ToString("dd/MM/yyyy");
            lblHora.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].HoraJuego.ToString();
            lblIndividual.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].IndividualOEquipo.ToString();
            lblCantidad.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].CantidadEquipos.ToString();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Abrir modulo para jugadores
            this.Hide();
            FormJugadores j = new FormJugadores();
            j.FormClosed += (s, args) => this.Close();
            j.Permiso = Permiso;
            j.Show();
        }

        private void ligasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Lenar los labels con la info de la liga seleccionada
            idliga = bL_LigasDS.Ligas[ligasBindingSource.Position].Id_Liga;
            lblNombreLiga.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].Nombre_de_liga.ToString();
            lblPresidente.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NPresidente.ToString();
            lblTesorero.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NTesorero.ToString();
            lblSecretarioG.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NSecretario.ToString();
            lblNombrebol.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].NombreBoliche.ToString();
            lblCiudad.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].CiudadJuego.ToString();
            lblFechainicio.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaInicio.ToString("dd/MM/yyyy");
            DateTime dateValue = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaInicio;
            lblDiajuego.Text = (diasemana(dateValue)).ToString();
            
            lblFechafinal.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].FechaFinal.ToString("dd/MM/yyyy");
            lblHora.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].HoraJuego.ToString();
            lblIndividual.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].IndividualOEquipo.ToString();
            lblCantidad.Text = bL_LigasDS.Ligas[ligasBindingSource.Position].CantidadEquipos.ToString();


        }
        //Devuelve el dia de la semana en español de la fecha ingresada
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
        private void button4_Click(object sender, EventArgs e)
        {
            //Cierra sesion y regresa a la pantalla login
            this.Hide();
            Login l = new Login();
            l.FormClosed += (s, args) => this.Close();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir modulo para crear una nueva liga
            this.Hide();
            FormNuevaLiga nl = new FormNuevaLiga();
            nl.FormClosed += (s, args) => this.Close();
            nl.Permiso = Permiso;
            nl.Show();
        }

        private void btnEliminarLiga_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Al eliminar la liga, tambien se borraran los roles y resultados de la liga \nEsta seguro de que desea continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Elimina la liga seleccionada, todos los roles de la respectiva liga y todos los juegosxsemana respectivos a los roles
                ligasTableAdapter.BorrarLiga(bL_LigasDS.Ligas[ligasBindingSource.Position].Id_Liga);
                MessageBox.Show("Liga eliminada correctamente");
                this.ligasTableAdapter.FillMenu(this.bL_LigasDS.Ligas);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Abrir modulo para equipos
            this.Hide();
            Equipos eq = new Equipos();
            eq.FormClosed += (s, args) => this.Close();
            eq.Permiso = Permiso;
            eq.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrir modulo para roles de juego
            this.Hide();
            FormRoles ro = new FormRoles();
            ro.FormClosed += (s, args) => this.Close();
            ro.Permiso = Permiso;
            ro.idliga = idliga;
            ro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Abrir modulo para roles de juego
            this.Hide();
            FormJuegosxsemana ro = new FormJuegosxsemana();
            ro.FormClosed += (s, args) => this.Close();
            ro.Permiso = Permiso;
            ro.idliga = idliga;
            ro.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Abrir modulo para Detallesxequipos
            this.Hide();
            FormLigasDetalles ro = new FormLigasDetalles();
            ro.FormClosed += (s, args) => this.Close();
            ro.Permiso = Permiso;
            ro.idliga = idliga;
            ro.Show();
        }
    }
}
