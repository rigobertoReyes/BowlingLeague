﻿using System;
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
    public partial class FormVistaPreviaReporte : Form
    {
        public FormVistaPreviaReporte()
        {
            InitializeComponent();
        }
        public string file;
        private void FormVistaPreviaReporte_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = file;
        }
    }
}
