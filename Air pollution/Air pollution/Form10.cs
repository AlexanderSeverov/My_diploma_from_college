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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (DataTrans.Value45==true)
            {
                label9.Visible = true;

                textBox1.Text = Convert.ToString("50");
                textBox2.Text = Convert.ToString("2");
                textBox3.Text = Convert.ToString("5");
                textBox4.Text = Convert.ToString("-15");
                textBox5.Text = Convert.ToString("5");
                textBox6.Text = Convert.ToString("200");
                textBox7.Text = Convert.ToString("61,8491221300405");
                textBox8.Text = Convert.ToString("0,927736831950608");

                DataTrans.Value28 = Convert.ToDouble(textBox1.Text);
                DataTrans.Value29 = Convert.ToDouble(textBox2.Text);
                DataTrans.Value30 = Convert.ToDouble(textBox3.Text);
                DataTrans.Value31 = Convert.ToDouble(textBox4.Text);
                DataTrans.Value32 = Convert.ToDouble(textBox5.Text);
                DataTrans.Value33 = Convert.ToDouble(textBox6.Text);
                DataTrans.Value36 = Convert.ToDouble(textBox7.Text);
                DataTrans.Value37 = Convert.ToDouble(textBox8.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            DataTrans.Value28 = Convert.ToDouble(textBox1.Text);
            DataTrans.Value29 = Convert.ToDouble(textBox2.Text);
            DataTrans.Value30 = Convert.ToDouble(textBox3.Text);
            DataTrans.Value31 = Convert.ToDouble(textBox4.Text);
            DataTrans.Value32 = Convert.ToDouble(textBox5.Text);
            DataTrans.Value33 = Convert.ToDouble(textBox6.Text);
            
//
            double tmp1 = DataTrans.Value28 + 1.9 * DataTrans.Value32 / DataTrans.Value30 * DataTrans.Value29 + 4.95 * 9.8 * DataTrans.Value32 * Math.Pow(DataTrans.Value29, 2) * (DataTrans.Value33 + 274.15 - DataTrans.Value31 - 274.15) / 4 / (DataTrans.Value31 + 274.15) / Math.Pow(DataTrans.Value30, 2);
            textBox7.Text = Convert.ToString(tmp1);
            DataTrans.Value36 = tmp1;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tmp2 = DataTrans.Value36 * 15 / 1000; 
            textBox8.Text = Convert.ToString(tmp2);
            DataTrans.Value37 = tmp2;
        }
    }
}
