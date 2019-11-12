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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBDataSet.Jugadores' table. You can move, or remove it, as needed.
            this.jugadoresTableAdapter.Fill(this.bL_DBDataSet.Jugadores);

        }
        private void login()
        {
            try
            {
                if (txtNumero.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Por favor ingrese nombre de usuario o contraseña");
                }
                else if (jugadoresTableAdapter.Logi(Convert.ToInt16(txtNumero.Text), txtPass.Text) == 1)//User and pass correctos
                {
                    this.Hide();
                    Menu m = new Menu();
                    m.idjugador = Convert.ToInt16( jugadoresTableAdapter.GetIdJugador(Convert.ToInt16(txtNumero.Text)));
                    m.Permiso = jugadoresTableAdapter.GetPuesto(Convert.ToInt16(txtNumero.Text), txtPass.Text).ToString();
                    m.FormClosed += (s, args) => this.Close();
                    m.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }

            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, asegurese de que el campo de numero contenga caracteres validos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
                    
        }

        private void jugadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBDataSet);

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
