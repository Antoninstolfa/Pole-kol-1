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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {
                int N = Convert.ToInt32(numericUpDownN.Value);
                int B = Convert.ToInt32(numericUpDownB.Value);
                int[] pole = new int[N];
                int[] poleMensi = new int[N];
                int[] poleVetsi = new int[N];
                int a = 0,b = 0;
                for (int i = 0; i < N; i++)
                {
                    Random rng = new Random();
                    int cislo = Convert.ToInt32(rng.Next(0,100));
                    pole[i] = cislo;
                    if(pole[i] < B)
                    {
                        poleMensi = pole.Take(i).ToArray();
                        a++;
                    }
                    if(pole[i]>B)
                    {
                        poleVetsi = pole.Take(i).ToArray();
                        b++;
                    }
                }
                foreach(int cislo in pole)
                {
                    listBox1.Items.Add(cislo);
                }
                Array.Sort(poleMensi);
                foreach(int cislo in poleMensi)
                {
                    listBox2.Items.Add(cislo);
                }
                Array.Sort(poleVetsi);
                foreach(int cislo in poleVetsi)
                {
                    listBox3.Items.Add(cislo);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
