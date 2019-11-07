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
    public partial class FormSeleccionarEquipo : Form
    {
        public FormSeleccionarEquipo()
        {
            InitializeComponent();
        }
        public int idequipo = 0;
        public int idparam = 0;
        public string nombreequipo = "";
        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bL_DBEquiposDS);

        }

        private void FormSeleccionarEquipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bL_DBEquiposDS.Equipos' table. You can move, or remove it, as needed.
            this.equiposTableAdapter.FillBynoequipo(this.bL_DBEquiposDS.Equipos,idparam,txtBuscar.Text);

        }

        private void equiposDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Una vez seleccionados se captura en las variables el id y el nombre del equipo para mostrarlo en el textbox
            idequipo = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Id_Equipo;
            nombreequipo = bL_DBEquiposDS.Equipos[equiposBindingSource.Position].Nombre_de_equipo;
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.equiposTableAdapter.FillBynoequipo(this.bL_DBEquiposDS.Equipos, idparam, txtBuscar.Text);

        }
    }
}
