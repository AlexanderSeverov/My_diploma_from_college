using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_pollution
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hh = 0.05;
            
            double xpoli = Convert.ToDouble(listBox1.SelectedItem.ToString());
            double ypoli = Convert.ToDouble(listBox2.SelectedItem.ToString());
            double tmpxpoli = (xpoli / hh) + 2;
            double tmpypoli = (ypoli / hh) + 2;
            double partialxypoli = 0;
            label7.Text = partialxypoli.ToString();


            double snowpoli = Convert.ToDouble(listBox3.SelectedItem.ToString());
            double partialsnowpoli = partialxypoli / snowpoli;
           // label14.Text = partialsnowpoli.ToString();

        }
    }
}
