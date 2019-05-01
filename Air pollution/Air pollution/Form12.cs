using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_pollution
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e )
        {
              DataTrans.Value45 = true;

            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();

            this.Hide();
        }
    }
}
