using System;
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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(listBox1.Size);
                int[] pole = new int[a];
                bool nula = false;
                for(int i=0;i < a && nula=false;i++)
                {
                    pole[i] = Convert.ToInt32(listBox1.SelectedIndex);
                    if(pole[i] == 0)
                    {
                        nula = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
