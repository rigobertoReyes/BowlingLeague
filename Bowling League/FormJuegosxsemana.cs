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
    public partial class FormJuegosxsemana : Form
    {
        public FormJuegosxsemana()
        {
            InitializeComponent();
        }
        public int idrol = 0;
        public string Permiso = "";
        public int idjugador = 0;
        public int idliga = 0;
        int ideq1 = 0, ideq2 = 0;
        int jueq1j1,
            jueq1j2,
            jueq1j3,
            jueq1j4,
            jueq1j5,
            jueq1s1,
            jueq1s2;
        int jueq2j1,
            jueq2j2,
            jueq2j3,
            jueq2j4,
            jueq2j5,
            jueq2s1,
            jueq2s2;
        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_RolesDS);

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

        //Lenara los datos de juego por semana de cada jugador
        public void llenarjuegoxsemana(int eq,int idint,TextBox txtid,TextBox hcp,NumericUpDown res1, NumericUpDown res2,
            NumericUpDown res3,TextBox total)
        {
            //Si no hay intregrante, no se setean los datos y se deshabilitan incluyendo el boton para guardar
            if (idint == 0)
            {
                txtid.Text = "-";
                hcp.Text = "0";
                res1.Value = 0;
                res1.Enabled = false;
                res2.Value = 0;
                res2.Enabled = false;
                res3.Value = 0;
                res3.Enabled = false;
                total.Text = "0";
            }
            else
            {
                txtid.Text = jugadoresTableAdapter.Getnombre(idint);
                hcp.Text = juegosxSemanaTableAdapter.Gethandycap(idrol, eq, idint).ToString();
                res1.Value = Convert.ToInt16(juegosxSemanaTableAdapter.Getresultado1(idrol, eq, idint));
                res1.Enabled = true;
                res2.Value = Convert.ToInt16(juegosxSemanaTableAdapter.Getresultado2(idrol, eq, idint));
                res2.Enabled = true;
                res3.Value = Convert.ToInt16(juegosxSemanaTableAdapter.Getresultado3(idrol, eq, idint));
                res3.Enabled = true;
                total.Text = juegosxSemanaTableAdapter.Gettotalpinos(idrol, eq, idint).ToString();
            }
        }

        public void llenardatos(int eq1, int eq2)
        {
            //Obtener los ids y nombres de los jugadores del equipo 1
            int ideq1i1 = Convert.ToInt16(equiposTableAdapter.Getidi1(eq1));
            int ideq1i2 = Convert.ToInt16(equiposTableAdapter.Getidi2(eq1));
            int ideq1i3 = Convert.ToInt16(equiposTableAdapter.Getidi3(eq1));
            int ideq1i4 = Convert.ToInt16(equiposTableAdapter.Getidi4(eq1));
            int ideq1i5 = Convert.ToInt16(equiposTableAdapter.Getidi5(eq1));
            int ideq1s1 = Convert.ToInt16(equiposTableAdapter.Getids1(eq1));
            int ideq1s2 = Convert.ToInt16(equiposTableAdapter.Getids2(eq1));

            //Obtener el idjuego de los jugadores del equipo 1, si almacena 0 no se actualizara
            jueq1j1 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1i1));
            jueq1j2 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1i2));
            jueq1j3 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1i3));
            jueq1j4 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1i4));
            jueq1j5 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1i5));
            jueq1s1 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1s1));
            jueq1s2 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq1, ideq1s2));


            //Llenar los datos de los integrantes del equipo 1 en los textbox
            llenarjuegoxsemana(eq1, ideq1i1, txteq1j1, txteq1hcpj1, nmeq1r1j1, nmeq1r2j1, nmeq1r3j1, txteq1tpj1);
            llenarjuegoxsemana(eq1, ideq1i2, txteq1j2, txteq1hcpj2, nmeq1r1j2, nmeq1r2j2, nmeq1r3j2, txteq1tpj2);
            llenarjuegoxsemana(eq1, ideq1i3, txteq1j3, txteq1hcpj3, nmeq1r1j3, nmeq1r2j3, nmeq1r3j3, txteq1tpj3);
            llenarjuegoxsemana(eq1, ideq1i4, txteq1j4, txteq1hcpj4, nmeq1r1j4, nmeq1r2j4, nmeq1r3j4, txteq1tpj4);
            llenarjuegoxsemana(eq1, ideq1i5, txteq1j5, txteq1hcpj5, nmeq1r1j5, nmeq1r2j5, nmeq1r3j5, txteq1tpj5);

            llenarjuegoxsemana(eq1, ideq1s1, txteq1s1, txteq1hcps1, nmeq1r1s1, nmeq1r2s1, nmeq1r3s1, txteq1tps1);
            llenarjuegoxsemana(eq1, ideq1s2, txteq1s2, txteq1hcps2, nmeq1r1s2, nmeq1r2s2, nmeq1r3s2, txteq1tps2);


            //Obtener los ids y nombres de los jugadores del equipo 2
            int ideq2i1 = Convert.ToInt16(equiposTableAdapter.Getidi1(eq2));
            int ideq2i2 = Convert.ToInt16(equiposTableAdapter.Getidi2(eq2));
            int ideq2i3 = Convert.ToInt16(equiposTableAdapter.Getidi3(eq2));
            int ideq2i4 = Convert.ToInt16(equiposTableAdapter.Getidi4(eq2));
            int ideq2i5 = Convert.ToInt16(equiposTableAdapter.Getidi5(eq2));
            int ideq2s1 = Convert.ToInt16(equiposTableAdapter.Getids1(eq2));
            int ideq2s2 = Convert.ToInt16(equiposTableAdapter.Getids2(eq2));

            //Obtener el idjuego de los jugadores del equipo 1, si almacena 0 no se actualizara
            jueq2j1 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2i1));
            jueq2j2 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2i2));
            jueq2j3 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2i3));
            jueq2j4 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2i4));
            jueq2j5 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2i5));
            jueq2s1 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2s1));
            jueq2s2 = Convert.ToInt16(juegosxSemanaTableAdapter.Getidjuego(idrol, eq2, ideq2s2));

            //Llenar los datos de los integrantes del equipo 1 en los textbox
            llenarjuegoxsemana(eq2, ideq2i1, txteq2j1, txteq2hcpj1, nmeq2r1j1, nmeq2r2j1, nmeq2r3j1, txteq2tpj1);
            llenarjuegoxsemana(eq2, ideq2i2, txteq2j2, txteq2hcpj2, nmeq2r1j2, nmeq2r2j2, nmeq2r3j2, txteq2tpj2);
            llenarjuegoxsemana(eq2, ideq2i3, txteq2j3, txteq2hcpj3, nmeq2r1j3, nmeq2r2j3, nmeq2r3j3, txteq2tpj3);
            llenarjuegoxsemana(eq2, ideq2i4, txteq2j4, txteq2hcpj4, nmeq2r1j4, nmeq2r2j4, nmeq2r3j4, txteq2tpj4);
            llenarjuegoxsemana(eq2, ideq2i5, txteq2j5, txteq2hcpj5, nmeq2r1j5, nmeq2r2j5, nmeq2r3j5, txteq2tpj5);

            llenarjuegoxsemana(eq2, ideq2s1, txteq2s1, txteq2hcps1, nmeq2r1s1, nmeq2r2s1, nmeq2r3s1, txteq2tps1);
            llenarjuegoxsemana(eq2, ideq2s2, txteq2s2, txteq2hcps2, nmeq2r1s2, nmeq2r2s2, nmeq2r3s2, txteq2tps2);

            cargartotales();
        }

        public void cargartotales()
        {
            //Totales del equipo 1
            //Total de pinos
            txteq1tpj1.Text =(
                Convert.ToInt16(nmeq1r1j1.Value) +
                Convert.ToInt16(nmeq1r2j1.Value) +
                Convert.ToInt16(nmeq1r3j1.Value)).ToString();
            txteq1tpj2.Text =(
                Convert.ToInt16(nmeq1r1j2.Value) +
                Convert.ToInt16(nmeq1r2j2.Value) +
                Convert.ToInt16(nmeq1r3j2.Value)).ToString();
            txteq1tpj3.Text =(
                Convert.ToInt16(nmeq1r1j3.Value) +
                Convert.ToInt16(nmeq1r2j3.Value) +
                Convert.ToInt16(nmeq1r3j3.Value)).ToString();
            txteq1tpj4.Text =(
                Convert.ToInt16(nmeq1r1j4.Value) +
                Convert.ToInt16(nmeq1r2j4.Value) +
                Convert.ToInt16(nmeq1r3j4.Value)).ToString();
            txteq1tpj5.Text =(
                Convert.ToInt16(nmeq1r1j5.Value) +
                Convert.ToInt16(nmeq1r2j5.Value) +
                Convert.ToInt16(nmeq1r3j5.Value)).ToString();
            txteq1tps1.Text =(
                Convert.ToInt16(nmeq1r1s1.Value) +
                Convert.ToInt16(nmeq1r2s1.Value) +
                Convert.ToInt16(nmeq1r3s1.Value)).ToString();
            txteq1tps2.Text =(
                Convert.ToInt16(nmeq1r1s2.Value) +
                Convert.ToInt16(nmeq1r2s2.Value) +
                Convert.ToInt16(nmeq1r3s2.Value)).ToString();
            //Total Scratch
            txteq1tsr1.Text =(
                Convert.ToInt16(nmeq1r1j1.Value) +
                Convert.ToInt16(nmeq1r1j2.Value) +
                Convert.ToInt16(nmeq1r1j3.Value) +
                Convert.ToInt16(nmeq1r1j4.Value) +
                Convert.ToInt16(nmeq1r1j5.Value) +
                Convert.ToInt16(nmeq1r1s1.Value) +
                Convert.ToInt16(nmeq1r1s2.Value)).ToString();
            txteq1tsr2.Text = (
                Convert.ToInt16(nmeq1r2j1.Value) +
                Convert.ToInt16(nmeq1r2j2.Value) +
                Convert.ToInt16(nmeq1r2j3.Value) +
                Convert.ToInt16(nmeq1r2j4.Value) +
                Convert.ToInt16(nmeq1r2j5.Value) +
                Convert.ToInt16(nmeq1r2s1.Value) +
                Convert.ToInt16(nmeq1r2s2.Value)).ToString();
            txteq1tsr3.Text = (
                Convert.ToInt16(nmeq1r3j1.Value) +
                Convert.ToInt16(nmeq1r3j2.Value) +
                Convert.ToInt16(nmeq1r3j3.Value) +
                Convert.ToInt16(nmeq1r3j4.Value) +
                Convert.ToInt16(nmeq1r3j5.Value) +
                Convert.ToInt16(nmeq1r3s1.Value) +
                Convert.ToInt16(nmeq1r3s2.Value)).ToString();
            //Handycap
            int hceq1j1 = 0;
            int hceq1j2 = 0;
            int hceq1j3 = 0;
            int hceq1j4 = 0;
            int hceq1j5 = 0;
            int hceq1s1 = 0;
            int hceq1s2 = 0;
            //Si la puntuacion es 0 quiere decir que no participo, por lo que no le contara el handycap
            if (nmeq1r1j1.Value != 0) { hceq1j1 = Convert.ToInt16(txteq1hcpj1.Text); } else { hceq1j1 = 0; }
            if (nmeq1r1j2.Value != 0) { hceq1j2 = Convert.ToInt16(txteq1hcpj2.Text); } else { hceq1j2 = 0; }
            if (nmeq1r1j3.Value != 0) { hceq1j3 = Convert.ToInt16(txteq1hcpj3.Text); } else { hceq1j3 = 0; }
            if (nmeq1r1j4.Value != 0) { hceq1j4 = Convert.ToInt16(txteq1hcpj4.Text); } else { hceq1j4 = 0; }
            if (nmeq1r1j5.Value != 0) { hceq1j5 = Convert.ToInt16(txteq1hcpj5.Text); } else { hceq1j5 = 0; }
            if (nmeq1r1s1.Value != 0) { hceq1s1 = Convert.ToInt16(txteq1hcps1.Text); } else { hceq1s1 = 0; }
            if (nmeq1r1s2.Value != 0) { hceq1s2 = Convert.ToInt16(txteq1hcps2.Text); } else { hceq1s2 = 0; }
            txteq1hcpr1.Text = (hceq1j1+hceq1j2+hceq1j3+hceq1j4+hceq1j5+hceq1s1+hceq1s2).ToString();

            if (nmeq1r2j1.Value != 0) { hceq1j1 = Convert.ToInt16(txteq1hcpj1.Text); } else { hceq1j1 = 0; }
            if (nmeq1r2j2.Value != 0) { hceq1j2 = Convert.ToInt16(txteq1hcpj2.Text); } else { hceq1j2 = 0; }
            if (nmeq1r2j3.Value != 0) { hceq1j3 = Convert.ToInt16(txteq1hcpj3.Text); } else { hceq1j3 = 0; }
            if (nmeq1r2j4.Value != 0) { hceq1j4 = Convert.ToInt16(txteq1hcpj4.Text); } else { hceq1j4 = 0; }
            if (nmeq1r2j5.Value != 0) { hceq1j5 = Convert.ToInt16(txteq1hcpj5.Text); } else { hceq1j5 = 0; }
            if (nmeq1r2s1.Value != 0) { hceq1s1 = Convert.ToInt16(txteq1hcps1.Text); } else { hceq1s1 = 0; }
            if (nmeq1r2s2.Value != 0) { hceq1s2 = Convert.ToInt16(txteq1hcps2.Text); } else { hceq1s2 = 0; }
            txteq1hcpr2.Text = (hceq1j1 + hceq1j2 + hceq1j3 + hceq1j4 + hceq1j5 + hceq1s1 + hceq1s2).ToString();

            if (nmeq1r3j1.Value != 0) { hceq1j1 = Convert.ToInt16(txteq1hcpj1.Text); } else { hceq1j1 = 0; }
            if (nmeq1r3j2.Value != 0) { hceq1j2 = Convert.ToInt16(txteq1hcpj2.Text); } else { hceq1j2 = 0; }
            if (nmeq1r3j3.Value != 0) { hceq1j3 = Convert.ToInt16(txteq1hcpj3.Text); } else { hceq1j3 = 0; }
            if (nmeq1r3j4.Value != 0) { hceq1j4 = Convert.ToInt16(txteq1hcpj4.Text); } else { hceq1j4 = 0; }
            if (nmeq1r3j5.Value != 0) { hceq1j5 = Convert.ToInt16(txteq1hcpj5.Text); } else { hceq1j5 = 0; }
            if (nmeq1r3s1.Value != 0) { hceq1s1 = Convert.ToInt16(txteq1hcps1.Text); } else { hceq1s1 = 0; }
            if (nmeq1r3s2.Value != 0) { hceq1s2 = Convert.ToInt16(txteq1hcps2.Text); } else { hceq1s2 = 0; }
            txteq1hcpr3.Text = (hceq1j1 + hceq1j2 + hceq1j3 + hceq1j4 + hceq1j5 + hceq1s1 + hceq1s2).ToString();

            //Totales
            txteq1totr1.Text = (Convert.ToInt16(txteq1tsr1.Text) + Convert.ToInt16(txteq1hcpr1.Text)).ToString();
            txteq1totr2.Text = (Convert.ToInt16(txteq1tsr2.Text) + Convert.ToInt16(txteq1hcpr2.Text)).ToString();
            txteq1totr3.Text = (Convert.ToInt16(txteq1tsr3.Text) + Convert.ToInt16(txteq1hcpr3.Text)).ToString();
            txteq1totr4.Text = (Convert.ToInt16(txteq1totr1.Text) + Convert.ToInt16(txteq1totr2.Text) + Convert.ToInt16(txteq1totr3.Text)).ToString();


            //Totales del equipo 2
            //Total de pinos
            txteq2tpj1.Text =
                (Convert.ToInt16(nmeq2r1j1.Value) +
                Convert.ToInt16(nmeq2r2j1.Value) +
                Convert.ToInt16(nmeq2r3j1.Value)).ToString();
            txteq2tpj2.Text =(
                Convert.ToInt16(nmeq2r1j2.Value) +
                Convert.ToInt16(nmeq2r2j2.Value) +
                Convert.ToInt16(nmeq2r3j2.Value)).ToString();
            txteq2tpj3.Text =(
                Convert.ToInt16(nmeq2r1j3.Value) +
                Convert.ToInt16(nmeq2r2j3.Value) +
                Convert.ToInt16(nmeq2r3j3.Value)).ToString();
            txteq2tpj4.Text =(
                Convert.ToInt16(nmeq2r1j4.Value) +
                Convert.ToInt16(nmeq2r2j4.Value) +
                Convert.ToInt16(nmeq2r3j4.Value)).ToString();
            txteq2tpj5.Text =(
                Convert.ToInt16(nmeq2r1j5.Value) +
                Convert.ToInt16(nmeq2r2j5.Value) +
                Convert.ToInt16(nmeq2r3j5.Value)).ToString();
            txteq2tps1.Text =(
                Convert.ToInt16(nmeq2r1s1.Value) +
                Convert.ToInt16(nmeq2r2s1.Value) +
                Convert.ToInt16(nmeq2r3s1.Value)).ToString();
            txteq2tps2.Text =(
                Convert.ToInt16(nmeq2r1s2.Value) +
                Convert.ToInt16(nmeq2r2s2.Value) +
                Convert.ToInt16(nmeq2r3s2.Value)).ToString();
            //Total Scratch
            txteq2tsr1.Text = (
                Convert.ToInt16(nmeq2r1j1.Value) +
                Convert.ToInt16(nmeq2r1j2.Value) +
                Convert.ToInt16(nmeq2r1j3.Value) +
                Convert.ToInt16(nmeq2r1j4.Value) +
                Convert.ToInt16(nmeq2r1j5.Value) +
                Convert.ToInt16(nmeq2r1s1.Value) +
                Convert.ToInt16(nmeq2r1s2.Value)).ToString();
            txteq2tsr2.Text = (
                Convert.ToInt16(nmeq2r2j1.Value) +
                Convert.ToInt16(nmeq2r2j2.Value) +
                Convert.ToInt16(nmeq2r2j3.Value) +
                Convert.ToInt16(nmeq2r2j4.Value) +
                Convert.ToInt16(nmeq2r2j5.Value) +
                Convert.ToInt16(nmeq2r2s1.Value) +
                Convert.ToInt16(nmeq2r2s2.Value)).ToString();
            txteq2tsr3.Text = (
                Convert.ToInt16(nmeq2r3j1.Value) +
                Convert.ToInt16(nmeq2r3j2.Value) +
                Convert.ToInt16(nmeq2r3j3.Value) +
                Convert.ToInt16(nmeq2r3j4.Value) +
                Convert.ToInt16(nmeq2r3j5.Value) +
                Convert.ToInt16(nmeq2r3s1.Value) +
                Convert.ToInt16(nmeq2r3s2.Value)).ToString();
            //Handycap
            int hceq2j1 = 0;
            int hceq2j2 = 0;
            int hceq2j3 = 0;
            int hceq2j4 = 0;
            int hceq2j5 = 0;
            int hceq2s1 = 0;
            int hceq2s2 = 0;
            //Si la puntuacion es 0 quiere decir que no participo, por lo que no le contara el handycap
            if (nmeq2r1j1.Value != 0) { hceq2j1 = Convert.ToInt16(txteq2hcpj1.Text); } else { hceq2j1 = 0; }
            if (nmeq2r1j2.Value != 0) { hceq2j2 = Convert.ToInt16(txteq2hcpj2.Text); } else { hceq2j2 = 0; }
            if (nmeq2r1j3.Value != 0) { hceq2j3 = Convert.ToInt16(txteq2hcpj3.Text); } else { hceq2j3 = 0; }
            if (nmeq2r1j4.Value != 0) { hceq2j4 = Convert.ToInt16(txteq2hcpj4.Text); } else { hceq2j4 = 0; }
            if (nmeq2r1j5.Value != 0) { hceq2j5 = Convert.ToInt16(txteq2hcpj5.Text); } else { hceq2j5 = 0; }
            if (nmeq2r1s1.Value != 0) { hceq2s1 = Convert.ToInt16(txteq2hcps1.Text); } else { hceq2s1 = 0; }
            if (nmeq2r1s2.Value != 0) { hceq2s2 = Convert.ToInt16(txteq2hcps2.Text); } else { hceq2s2 = 0; }
            txteq2hcpr1.Text = (hceq2j1 + hceq2j2 + hceq2j3 + hceq2j4 + hceq2j5 + hceq2s1 + hceq2s2).ToString();

            if (nmeq2r2j1.Value != 0) { hceq2j1 = Convert.ToInt16(txteq2hcpj1.Text); } else { hceq2j1 = 0; }
            if (nmeq2r2j2.Value != 0) { hceq2j2 = Convert.ToInt16(txteq2hcpj2.Text); } else { hceq2j2 = 0; }
            if (nmeq2r2j3.Value != 0) { hceq2j3 = Convert.ToInt16(txteq2hcpj3.Text); } else { hceq2j3 = 0; }
            if (nmeq2r2j4.Value != 0) { hceq2j4 = Convert.ToInt16(txteq2hcpj4.Text); } else { hceq2j4 = 0; }
            if (nmeq2r2j5.Value != 0) { hceq2j5 = Convert.ToInt16(txteq2hcpj5.Text); } else { hceq2j5 = 0; }
            if (nmeq2r2s1.Value != 0) { hceq2s1 = Convert.ToInt16(txteq2hcps1.Text); } else { hceq2s1 = 0; }
            if (nmeq2r2s2.Value != 0) { hceq2s2 = Convert.ToInt16(txteq2hcps2.Text); } else { hceq2s2 = 0; }
            txteq2hcpr2.Text = (hceq2j1 + hceq2j2 + hceq2j3 + hceq2j4 + hceq2j5 + hceq2s1 + hceq2s2).ToString();

            if (nmeq2r3j1.Value != 0) { hceq2j1 = Convert.ToInt16(txteq2hcpj1.Text); } else { hceq2j1 = 0; }
            if (nmeq2r3j2.Value != 0) { hceq2j2 = Convert.ToInt16(txteq2hcpj2.Text); } else { hceq2j2 = 0; }
            if (nmeq2r3j3.Value != 0) { hceq2j3 = Convert.ToInt16(txteq2hcpj3.Text); } else { hceq2j3 = 0; }
            if (nmeq2r3j4.Value != 0) { hceq2j4 = Convert.ToInt16(txteq2hcpj4.Text); } else { hceq2j4 = 0; }
            if (nmeq2r3j5.Value != 0) { hceq2j5 = Convert.ToInt16(txteq2hcpj5.Text); } else { hceq2j5 = 0; }
            if (nmeq2r3s1.Value != 0) { hceq2s1 = Convert.ToInt16(txteq2hcps1.Text); } else { hceq2s1 = 0; }
            if (nmeq2r3s2.Value != 0) { hceq2s2 = Convert.ToInt16(txteq2hcps2.Text); } else { hceq2s2 = 0; }
            txteq2hcpr3.Text = (hceq2j1 + hceq2j2 + hceq2j3 + hceq2j4 + hceq2j5 + hceq2s1 + hceq2s2).ToString();

            //Totales
            txteq2totr1.Text = (Convert.ToInt16(txteq2tsr1.Text) + Convert.ToInt16(txteq2hcpr1.Text)).ToString();
            txteq2totr2.Text = (Convert.ToInt16(txteq2tsr2.Text) + Convert.ToInt16(txteq2hcpr2.Text)).ToString();
            txteq2totr3.Text = (Convert.ToInt16(txteq2tsr3.Text) + Convert.ToInt16(txteq2hcpr3.Text)).ToString();
            txteq2totr4.Text = (Convert.ToInt16(txteq2totr1.Text) + Convert.ToInt16(txteq2totr2.Text) + Convert.ToInt16(txteq2totr3.Text)).ToString();
            //Colores de victoria y derrota por rondas
            int toteq1r1 = Convert.ToInt16(txteq1totr1.Text);
            int toteq1r2 = Convert.ToInt16(txteq1totr2.Text);
            int toteq1r3 = Convert.ToInt16(txteq1totr3.Text);
            int toteq1r4 = Convert.ToInt16(txteq1totr4.Text);

            int toteq2r1 = Convert.ToInt16(txteq2totr1.Text);
            int toteq2r2 = Convert.ToInt16(txteq2totr2.Text);
            int toteq2r3 = Convert.ToInt16(txteq2totr3.Text);
            int toteq2r4 = Convert.ToInt16(txteq2totr4.Text);

            if (toteq1r1 > toteq2r1) { txteq1totr1.BackColor = Color.Lime; txteq2totr1.BackColor = Color.Orange; }
            else if (toteq1r1 < toteq2r1) { txteq1totr1.BackColor = Color.Orange; txteq2totr1.BackColor = Color.Lime; }
            else { txteq1totr1.BackColor = Color.White; txteq2totr1.BackColor = Color.White; }

            if (toteq1r2 > toteq2r2){txteq1totr2.BackColor = Color.Lime; txteq2totr2.BackColor = Color.Orange;}
            else if(toteq1r2 < toteq2r2) { txteq1totr2.BackColor = Color.Orange; txteq2totr2.BackColor = Color.Lime;}
            else { txteq1totr2.BackColor = Color.White; txteq2totr2.BackColor = Color.White; }

            if (toteq1r3 > toteq2r3){txteq1totr3.BackColor = Color.Lime; txteq2totr3.BackColor = Color.Orange;}
            else if (toteq1r3 < toteq2r3) { txteq1totr3.BackColor = Color.Orange; txteq2totr3.BackColor = Color.Lime;}
            else { txteq1totr3.BackColor = Color.White; txteq2totr3.BackColor = Color.White; }

            if (toteq1r4 > toteq2r4){txteq1totr4.BackColor = Color.Lime; txteq2totr4.BackColor = Color.Orange;}
            else if (toteq1r4 < toteq2r4) { txteq1totr4.BackColor = Color.Orange; txteq2totr4.BackColor = Color.Lime;}
            else { txteq1totr4.BackColor = Color.White; txteq2totr4.BackColor = Color.White; }

        }
        #region Eventos para cada campo de juegos
        //Cada que se cambia un valor en los resultados, cambian los totales
        private void nmeq1r1j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r1s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r2s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq1r3s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }

        private void nmeq2r1j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3j1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3j2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3j3_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3j4_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3j5_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3s1_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r1s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r2s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        private void nmeq2r3s2_ValueChanged(object sender, EventArgs e)
        {
            cargartotales();
        }
        #endregion


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si este juego ya se jugo, las victorias/derrotas se acumularan junto con las anteriores \nEsta seguro de que desea continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Actualizar los datos de juego por semana
                //Equipo 1
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1j1.Value),
                    Convert.ToInt16(nmeq1r2j1.Value),
                    Convert.ToInt16(nmeq1r3j1.Value),
                    0,
                    Convert.ToInt16(txteq1tpj1.Text),
                    jueq1j1);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1j2.Value),
                    Convert.ToInt16(nmeq1r2j2.Value),
                    Convert.ToInt16(nmeq1r3j2.Value),
                    0,
                    Convert.ToInt16(txteq1tpj2.Text),
                    jueq1j2);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1j3.Value),
                    Convert.ToInt16(nmeq1r2j3.Value),
                    Convert.ToInt16(nmeq1r3j3.Value),
                    0,
                    Convert.ToInt16(txteq1tpj3.Text),
                    jueq1j3);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1j4.Value),
                    Convert.ToInt16(nmeq1r2j4.Value),
                    Convert.ToInt16(nmeq1r3j4.Value),
                    0,
                    Convert.ToInt16(txteq1tpj4.Text),
                    jueq1j4);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1j5.Value),
                    Convert.ToInt16(nmeq1r2j5.Value),
                    Convert.ToInt16(nmeq1r3j5.Value),
                    0,
                    Convert.ToInt16(txteq1tpj5.Text),
                    jueq1j5);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1s1.Value),
                    Convert.ToInt16(nmeq1r2s1.Value),
                    Convert.ToInt16(nmeq1r3s1.Value),
                    0,
                    Convert.ToInt16(txteq1tps1.Text),
                    jueq1s1);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq1r1s2.Value),
                    Convert.ToInt16(nmeq1r2s2.Value),
                    Convert.ToInt16(nmeq1r3s2.Value),
                    0,
                    Convert.ToInt16(txteq1tps2.Text),
                    jueq1s2);

                //Equipo 2
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1j1.Value),
                    Convert.ToInt16(nmeq2r2j1.Value),
                    Convert.ToInt16(nmeq2r3j1.Value),
                    0,
                    Convert.ToInt16(txteq2tpj1.Text),
                    jueq2j1);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1j2.Value),
                    Convert.ToInt16(nmeq2r2j2.Value),
                    Convert.ToInt16(nmeq2r3j2.Value),
                    0,
                    Convert.ToInt16(txteq2tpj2.Text),
                    jueq2j2);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1j3.Value),
                    Convert.ToInt16(nmeq2r2j3.Value),
                    Convert.ToInt16(nmeq2r3j3.Value),
                    0,
                    Convert.ToInt16(txteq2tpj3.Text),
                    jueq2j3);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1j4.Value),
                    Convert.ToInt16(nmeq2r2j4.Value),
                    Convert.ToInt16(nmeq2r3j4.Value),
                    0,
                    Convert.ToInt16(txteq2tpj4.Text),
                    jueq2j4);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1j5.Value),
                    Convert.ToInt16(nmeq2r2j5.Value),
                    Convert.ToInt16(nmeq2r3j5.Value),
                    0,
                    Convert.ToInt16(txteq2tpj5.Text),
                    jueq2j5);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1s1.Value),
                    Convert.ToInt16(nmeq2r2s1.Value),
                    Convert.ToInt16(nmeq2r3s1.Value),
                    0,
                    Convert.ToInt16(txteq2tps1.Text),
                    jueq2s1);
                juegosxSemanaTableAdapter.Updatejuego(
                    Convert.ToInt16(nmeq2r1s2.Value),
                    Convert.ToInt16(nmeq2r2s2.Value),
                    Convert.ToInt16(nmeq2r3s2.Value),
                    0,
                    Convert.ToInt16(txteq2tps2.Text),
                    jueq2s2);

                //Revisar que equipo gano y que equipo perdio para acumular sus pinos y victorias/Derrotas en la tabla LigasDetalles
                //Verificar juego alto y serie alta de ambos equipos
                //Juego Alto
                int eq1j1 = Convert.ToInt16(txteq1totr1.Text);
                int eq1j2 = Convert.ToInt16(txteq1totr2.Text);
                int eq1j3 = Convert.ToInt16(txteq1totr3.Text);
                int jaeq1 = Math.Max(Math.Max(eq1j1, eq1j2), eq1j3);
                int njaeq1 = Math.Max(jaeq1, Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetJuegoAlto(idliga, ideq1)));

                int eq2j1 = Convert.ToInt16(txteq2totr1.Text);
                int eq2j2 = Convert.ToInt16(txteq2totr2.Text);
                int eq2j3 = Convert.ToInt16(txteq2totr3.Text);
                int jaeq2 = Math.Max(Math.Max(eq2j1, eq2j2), eq2j3);
                int njaeq2 = Math.Max(jaeq2, Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetJuegoAlto(idliga, ideq2)));
                //Serie Alta
                int eq1j4 = Convert.ToInt16(txteq1totr4.Text);
                int nsaeq1 = Math.Max(eq1j4, Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetSerieAlta(idliga, ideq1)));

                int eq2j4 = Convert.ToInt16(txteq2totr4.Text);
                int nsaeq2 = Math.Max(eq2j4, Convert.ToInt16(ligas_DetalleXEquiposTableAdapter.GetSerieAlta(idliga, ideq2)));

                int win1 = Convert.ToInt16(txteq1totr4.Text);
                int win2 = Convert.ToInt16(txteq2totr4.Text);
                if (win1 > win2)
                {
                    //1 victoria para el equipo 1 y 1 derrota para el equipo 2
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(1, 0, win1, 1, 0, njaeq1, nsaeq1, idliga, ideq1, Convert.ToInt16(cbSemana.Text));
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(0, 1, win2, 0, 1, njaeq2, nsaeq2, idliga, ideq2, Convert.ToInt16(cbSemana.Text));
                }
                else if (win1 < win2)
                {
                    //1 victoria para el equipo 2 y 1 derrota para el equipo 1
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(1, 0, win2, 1, 0, njaeq2, nsaeq1, idliga, ideq2, Convert.ToInt16(cbSemana.Text));
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(0, 1, win1, 0, 1, njaeq1, nsaeq2, idliga, ideq1, Convert.ToInt16(cbSemana.Text));
                }
                else
                {
                    //Ambos equipos empatan y se les asigna 0.5 a la victoria y derrota
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(Convert.ToDecimal(0.5), Convert.ToDecimal(0.5), win2, Convert.ToDecimal(0.5), Convert.ToDecimal(0.5), njaeq2, nsaeq1, idliga, ideq2, Convert.ToInt16(cbSemana.Text));
                    ligas_DetalleXEquiposTableAdapter.UpdateLigasDetalle(Convert.ToDecimal(0.5), Convert.ToDecimal(0.5), win1, Convert.ToDecimal(0.5), Convert.ToDecimal(0.5), njaeq1, nsaeq2, idliga, ideq1, Convert.ToInt16(cbSemana.Text));
                }

                MessageBox.Show("Juego actualizado correctamente");
                buscarjuego();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios actuales se van a revertir \nEsta seguro de que desea continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                buscarjuego();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buscarjuego();
        }
        public void todoenblanco()
        {
            //Labels de equipo
            lblequipo1.Text = "Equipo 1:";
            lblequipo2.Text = "Equipo 2:";
            lblwiner.Text = "Equipo Ganador:";
            //Equipo 1
            //Handycap
            txteq1hcpj1.Text = "0";
            txteq1hcpj2.Text = "0";
            txteq1hcpj3.Text = "0";
            txteq1hcpj4.Text = "0";
            txteq1hcpj5.Text = "0";
            txteq1hcps1.Text = "0";
            txteq1hcps2.Text = "0";
            //Nombres
            txteq1j1.Text = "";
            txteq1j2.Text = "";
            txteq1j3.Text = "";
            txteq1j4.Text = "";
            txteq1j5.Text = "";
            txteq1s1.Text = "";
            txteq1s2.Text = "";
            //Resultado 1
            nmeq1r1j1.Value = 0;
            nmeq1r1j2.Value = 0;
            nmeq1r1j3.Value = 0;
            nmeq1r1j4.Value = 0;
            nmeq1r1j5.Value = 0;
            nmeq1r1s1.Value = 0;
            nmeq1r1s2.Value = 0;
            //Resultado 2
            nmeq1r2j1.Value = 0;
            nmeq1r2j2.Value = 0;
            nmeq1r2j3.Value = 0;
            nmeq1r2j4.Value = 0;
            nmeq1r2j5.Value = 0;
            nmeq1r2s1.Value = 0;
            nmeq1r2s2.Value = 0;
            //Resultado 3
            nmeq1r3j1.Value = 0;
            nmeq1r3j2.Value = 0;
            nmeq1r3j3.Value = 0;
            nmeq1r3j4.Value = 0;
            nmeq1r3j5.Value = 0;
            nmeq1r3s1.Value = 0;
            nmeq1r3s2.Value = 0;
            //Total Pinos
            txteq1tpj1.Text = "0";
            txteq1tpj2.Text = "0";
            txteq1tpj3.Text = "0";
            txteq1tpj4.Text = "0";
            txteq1tpj5.Text = "0";
            txteq1tps1.Text = "0";
            txteq1tps2.Text = "0";
            //Total scratch
            txteq1tsr1.Text = "";
            txteq1tsr2.Text = "";
            txteq1tsr3.Text = "";
            txteq1tstp.Text = "";
            //Total Handycap
            txteq1hcpr1.Text = "";
            txteq1hcpr2.Text = "";
            txteq1hcpr3.Text = "";
            txteq1hcptp.Text = "";
            //Total
            txteq1totr1.Text = "";
            txteq1totr2.Text = "";
            txteq1totr3.Text = "";
            txteq1totr4.Text = "";

            //Equipo 2
            //Handycap
            txteq2hcpj1.Text = "0";
            txteq2hcpj2.Text = "0";
            txteq2hcpj3.Text = "0";
            txteq2hcpj4.Text = "0";
            txteq2hcpj5.Text = "0";
            txteq2hcps1.Text = "0";
            txteq2hcps2.Text = "0";
            //Nombres
            txteq2j1.Text = "";
            txteq2j2.Text = "";
            txteq2j3.Text = "";
            txteq2j4.Text = "";
            txteq2j5.Text = "";
            txteq2s1.Text = "";
            txteq2s2.Text = "";
            //Resultado 1
            nmeq2r1j1.Value = 0;
            nmeq2r1j2.Value = 0;
            nmeq2r1j3.Value = 0;
            nmeq2r1j4.Value = 0;
            nmeq2r1j5.Value = 0;
            nmeq2r1s1.Value = 0;
            nmeq2r1s2.Value = 0;
            //Resultado 2
            nmeq2r2j1.Value = 0;
            nmeq2r2j2.Value = 0;
            nmeq2r2j3.Value = 0;
            nmeq2r2j4.Value = 0;
            nmeq2r2j5.Value = 0;
            nmeq2r2s1.Value = 0;
            nmeq2r2s2.Value = 0;
            //Resultado 3
            nmeq2r3j1.Value = 0;
            nmeq2r3j2.Value = 0;
            nmeq2r3j3.Value = 0;
            nmeq2r3j4.Value = 0;
            nmeq2r3j5.Value = 0;
            nmeq2r3s1.Value = 0;
            nmeq2r3s2.Value = 0;
            //Total Pinos
            txteq2tpj1.Text = "0";
            txteq2tpj2.Text = "0";
            txteq2tpj3.Text = "0";
            txteq2tpj4.Text = "0";
            txteq2tpj5.Text = "0";
            txteq2tps1.Text = "0";
            txteq2tps2.Text = "0";
            //Total scratch
            txteq2tsr1.Text = "";
            txteq2tsr2.Text = "";
            txteq2tsr3.Text = "";
            txteq2tstp.Text = "";
            //Total Handycap
            txteq2hcpr1.Text = "";
            txteq2hcpr2.Text = "";
            txteq2hcpr3.Text = "";
            txteq2hcptp.Text = "";
            //Total
            txteq2totr1.Text = "";
            txteq2totr2.Text = "";
            txteq2totr3.Text = "";
            txteq2totr4.Text = "";
        }
        public void buscarjuego()
        {
            //Obtener el primer idrol de la semana seleccionada
            int idprimerrol = Convert.ToInt16(rolesTableAdapter.Getprimeridrol(Convert.ToInt16(cbSemana.Text), idliga));
            //Generar valor id base para usarlo de referencia y obtener el idrol de el numero de juego seleccionado
            int idbase = idprimerrol - 1;
            //Obtener el idrol con el idbase y el cb de numero de juego
            idrol = idbase + Convert.ToInt16(cbJuegos.Text);
            DateTime dat = Convert.ToDateTime(rolesTableAdapter.Getfecharol(idrol));
            lblfecha.Text = "(" + dat.ToString("dd/MM/yyyy") + ")";

            //Capturar id de equipo 1 y 2 y mostrar el nombre en el textbox
            ideq1 = Convert.ToInt16(rolesTableAdapter.GetidEquipo1(idrol));
            ideq2 = Convert.ToInt16(rolesTableAdapter.GetidEquipo2(idrol));
            if (ideq1 == 0 || ideq2 == 0 ||
                Convert.ToInt16(juegosxSemanaTableAdapter.IsJuegosemanal(idrol)) == 0)
            {
                MessageBox.Show("No hay jugadores asignados a este rol de juegos, por favor asigne los equipos en la seccion de rol de juegos");
                btnGuardar.Enabled = false;
                todoenblanco();
            }
            else
            {
                llenardatos(ideq1, ideq2);
                lblequipo1.Text = "Equipo 1: " + rolesTableAdapter.GetnombreEquipo1(idrol);
                lblequipo2.Text = "Equipo 2: " + rolesTableAdapter.GetnombreEquipo2(idrol);
                btnGuardar.Enabled = true;
                int win1 = Convert.ToInt16(txteq1totr4.Text);
                int win2 = Convert.ToInt16(txteq2totr4.Text);
                if (win1 > win2)
                {
                    lblwiner.Text = "Equipo Ganador: \n" + rolesTableAdapter.GetnombreEquipo1(idrol);
                }
                else if (win1 < win2)
                {
                    lblwiner.Text = "Equipo Ganador: \n" + rolesTableAdapter.GetnombreEquipo2(idrol);
                }
                else
                {
                    lblwiner.Text = "Equipo Ganador: \nEMPATE ";
                }
            }
        }
        private void FormJuegosxsemana_Load(object sender, EventArgs e)
        {
            string nombreliga = ligasTableAdapter.Getnombreliga(idliga);
            lblliga.Text = "Juego Semanal " + "(" + nombreliga + ")";
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
            buscarjuego();
        }
    }
}



