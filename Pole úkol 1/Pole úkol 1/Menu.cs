﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_úkol_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ukol1 ukol1 = new Ukol1();
            ukol1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ukol2 ukol2 = new Ukol2();
            ukol2.Show();
        }
    }
}
