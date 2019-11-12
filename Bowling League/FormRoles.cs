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
    public partial class FormRoles : Form
    {
        public FormRoles()
        {
            InitializeComponent();
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
        public int idrol = 0;
        public string Permiso = "";
        public int idliga = 0;
        int ideq1 = 0, ideq2 = 0;
        public int idjugador = 0;
        private void FormRoles_Load(object sender, EventArgs e)
        {
            
            string nombreliga = ligasTableAdapter.Getnombreliga(idliga);
            lblliga.Text = "Roles de liga\n" + "(" + nombreliga+")";

            
            //Lenar el combobox de semana con la cantidad de semanas de la liga
            int cantidadsemanas = Convert.ToInt16(rolesTableAdapter.Getcantidadsemanas(idliga));
            for (int i = 1; i <= cantidadsemanas; i++)
            {
                cbSemana.Items.Add(i);
            }
            //Lenar el combobox de juegos con la cantidad de juegos por semana de la liga
            int cantidadjuegos = Convert.ToInt16(rolesTableAdapter.Getcantidadjuegos(idliga));
            for (int i = 1; i <= cantidadjuegos; i++)
            {
                cbJuegos.Items.Add(i);
            }
            //Setear los combobox con el valor 1 por default
            cbSemana.Text = "" + 1;
            cbJuegos.Text = "" + 1;
            
            //Obtener el primer idrol de la semana seleccionada
            int idprimerrol = Convert.ToInt16(rolesTableAdapter.Getprimeridrol(Convert.ToInt16(cbSemana.Text), idliga));
            //Generar valor id base para usarlo de referencia y obtener el idrol de el numero de juego seleccionado
            int idbase = idprimerrol - 1;
            //Obtener el idrol con el idbase y el cb de numero de juego
            idrol = idbase + Convert.ToInt16(cbJuegos.Text);
            DateTime dat = Convert.ToDateTime( rolesTableAdapter.Getfecharol(idrol));
            lblfecha.Text = "(" + dat.ToString("dd/MM/yyyy") + ")";
            //Capturar id de equipo 1 y mostrar el nombre en el textbox
            ideq1 = Convert.ToInt16(rolesTableAdapter.GetidEquipo1(idrol));
            if (ideq1 == 0)
            {
                txtEquipo1.Text = "Sin asignar";
            }
            else
            {
                txtEquipo1.Text = rolesTableAdapter.GetnombreEquipo1(idrol).ToString();
            }

            //Capturar id de equipo 2 y mostrar el nombre en el textbox
            ideq2 = Convert.ToInt16(rolesTableAdapter.GetidEquipo2(idrol));
            if (ideq2 == 0)
            {
                txtEquipo2.Text = "Sin asignar";
            }
            else
            {
                txtEquipo2.Text = rolesTableAdapter.GetnombreEquipo2(idrol).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSeleccionarEquipo fs = new FormSeleccionarEquipo();
            //Darle como parametro a el equipo ya registrado para evitar duplicados
            fs.idparam = ideq2;
            fs.idequipo = ideq1;
            fs.nombreequipo = txtEquipo1.Text;
            fs.ShowDialog();
            txtEquipo1.Text = fs.nombreequipo;
            ideq1 = fs.idequipo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSeleccionarEquipo fs = new FormSeleccionarEquipo();
            //Darle como parametro a los equipos ya registrados para evitar duplicados
            fs.idparam = ideq1;
            fs.idequipo = ideq2;
            fs.nombreequipo = txtEquipo2.Text;
            fs.ShowDialog();
            txtEquipo2.Text = fs.nombreequipo;
            ideq2 = fs.idequipo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int eq1 = Convert.ToInt16(rolesTableAdapter.GetidEquipo1(idrol));
            int eq2 = Convert.ToInt16(rolesTableAdapter.GetidEquipo2(idrol));
            if (ideq1 == 0 || ideq2 == 0)
            {
                MessageBox.Show("Por favor seleccione a ambos equipos");
            }
            //Si ese rol ya tiene equipos asignados se rechaza la insersion
            else if ( eq1 != 0 || eq2 != 0)
            {
                MessageBox.Show("Ya hay equipos asignados a este rol de juegos, favor de seleccionar otro");
                ideq1 = Convert.ToInt16(rolesTableAdapter.GetidEquipo1(idrol));
                if (ideq1 == 0)
                {
                    txtEquipo1.Text = "Sin asignar";
                }
                else
                {
                    txtEquipo1.Text = rolesTableAdapter.GetnombreEquipo1(idrol).ToString();
                }

                //Capturar id de equipo 2 y mostrar el nombre en el textbox
                ideq2 = Convert.ToInt16(rolesTableAdapter.GetidEquipo2(idrol));
                if (ideq2 == 0)
                {
                    txtEquipo2.Text = "Sin asignar";
                }
                else
                {
                    txtEquipo2.Text = rolesTableAdapter.GetnombreEquipo2(idrol).ToString();
                }
            }
            else
            {
                //Asignar equipos al rol de juegos
                rolesTableAdapter.UpdateRol(ideq1,ideq2,idrol);
                MessageBox.Show("Equipos registrados correctamente");
                //Generar LigasDetallexEquipos de la semana seleccionada, solo si no existe
                int idligadetalleeq1 =Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetIdligasdetalle(Convert.ToInt16(cbSemana.Text),idliga,ideq1));
                int idligadetalleeq2 = Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetIdligasdetalle(Convert.ToInt16(cbSemana.Text), idliga, ideq2));
                if (idligadetalleeq1 == 0)
                {
                    ligas_DetalleXEquiposTableAdapter.Nuevaligasdetalle(idliga,ideq1, Convert.ToInt16(cbSemana.Text), 0, 0, 0, 0, 0, 0, 0);
                }
                if (idligadetalleeq2 == 0)
                {
                    ligas_DetalleXEquiposTableAdapter.Nuevaligasdetalle(idliga, ideq2, Convert.ToInt16(cbSemana.Text), 0, 0, 0, 0, 0, 0, 0);
                }
                //Generar juegos x semana por cada miembro de ambos equipos
                int eq1i1, eq1i2, eq1i3, eq1i4, eq1i5, eq1s1, eq1s2;
                //Guardar los ids de los integrantes del equipo 1
                eq1i1 =Convert.ToInt16(equiposTableAdapter.Getidi1(ideq1));
                eq1i2 = Convert.ToInt16(equiposTableAdapter.Getidi2(ideq1));
                eq1i3 = Convert.ToInt16(equiposTableAdapter.Getidi3(ideq1));
                eq1i4 = Convert.ToInt16(equiposTableAdapter.Getidi4(ideq1));
                eq1i5 = Convert.ToInt16(equiposTableAdapter.Getidi5(ideq1));
                eq1s1 = Convert.ToInt16(equiposTableAdapter.Getids1(ideq1));
                eq1s2 = Convert.ToInt16(equiposTableAdapter.Getids2(ideq1));
                //Verificar si hay un jugador en ese puesto, si es asi, generarle su registro en juegosxsemana
                if (eq1i1 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc=Convert.ToInt16( jugadoresTableAdapter.GetHC(eq1i1));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1i1, hc, 0, 0, 0, 0, 0);
                }
                if (eq1i2 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1i2));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1i2, hc, 0, 0, 0, 0, 0);
                }
                if (eq1i3 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1i3));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1i3, hc, 0, 0, 0, 0, 0);
                }
                if (eq1i4 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1i4));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1i4, hc, 0, 0, 0, 0, 0);
                }
                if (eq1i5 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1i5));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1i5, hc, 0, 0, 0, 0, 0);
                }
                if (eq1s1 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1s1));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1s1, hc, 0, 0, 0, 0, 0);
                }
                if (eq1s2 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq1s2));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq1, eq1s2, hc, 0, 0, 0, 0, 0);
                }


                int eq2i1, eq2i2, eq2i3, eq2i4, eq2i5, eq2s1, eq2s2;
                //Guardar los ids de los integrantes del equipo 2
                eq2i1 = Convert.ToInt16(equiposTableAdapter.Getidi1(ideq2));
                eq2i2 = Convert.ToInt16(equiposTableAdapter.Getidi2(ideq2));
                eq2i3 = Convert.ToInt16(equiposTableAdapter.Getidi3(ideq2));
                eq2i4 = Convert.ToInt16(equiposTableAdapter.Getidi4(ideq2));
                eq2i5 = Convert.ToInt16(equiposTableAdapter.Getidi5(ideq2));
                eq2s1 = Convert.ToInt16(equiposTableAdapter.Getids1(ideq2));
                eq2s2 = Convert.ToInt16(equiposTableAdapter.Getids2(ideq2));
                //Verificar si hay un jugador en ese puesto, si es asi, generarle su registro en juegosxsemana
                if (eq2i1 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2i1));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2i1, hc, 0, 0, 0, 0, 0);
                }
                if (eq2i2 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2i2));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2i2, hc, 0, 0, 0, 0, 0);
                }
                if (eq2i3 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2i3));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2i3, hc, 0, 0, 0, 0, 0);
                }
                if (eq2i4 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2i4));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2i4, hc, 0, 0, 0, 0, 0);
                }
                if (eq2i5 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2i5));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2i5, hc, 0, 0, 0, 0, 0);
                }
                if (eq2s1 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2s1));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2s1, hc, 0, 0, 0, 0, 0);
                }
                if (eq2s2 != 0)
                {
                    //Sacar el handycap actual del jugador
                    int hc = Convert.ToInt16(jugadoresTableAdapter.GetHC(eq2s2));
                    juegosxSemanaTableAdapter.Nuevojuego(idrol, ideq2, eq2s2, hc, 0, 0, 0, 0, 0);
                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            //Obtener el primer idrol de la semana seleccionada
            int idprimerrol = Convert.ToInt16(rolesTableAdapter.Getprimeridrol(Convert.ToInt16(cbSemana.Text), idliga));
            //Generar valor id base para usarlo de referencia y obtener el idrol de el numero de juego seleccionado
            int idbase = idprimerrol - 1;
            //Obtener el idrol con el idbase y el cb de numero de juego
            idrol = idbase + Convert.ToInt16(cbJuegos.Text);
            DateTime dat = Convert.ToDateTime(rolesTableAdapter.Getfecharol(idrol));
            lblfecha.Text = "(" + dat.ToString("dd/MM/yyyy") + ")";
            //Capturar id de equipo 1 y mostrar el nombre en el textbox
            ideq1 = Convert.ToInt16(rolesTableAdapter.GetidEquipo1(idrol));
            
            if (ideq1 == 0)
            {
                txtEquipo1.Text = "Sin asignar";
            }
            else
            {
                txtEquipo1.Text = rolesTableAdapter.GetnombreEquipo1(idrol).ToString();
            }

            //Capturar id de equipo 2 y mostrar el nombre en el textbox
            ideq2 = Convert.ToInt16(rolesTableAdapter.GetidEquipo2(idrol));
            if (ideq2 == 0)
            {
                txtEquipo2.Text = "Sin asignar";
            }
            else
            {
                txtEquipo2.Text = rolesTableAdapter.GetnombreEquipo2(idrol).ToString();
            }
        }

    
    }
}
