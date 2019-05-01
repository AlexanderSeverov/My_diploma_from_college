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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointsdataDataSet4.probtest2' table. You can move, or remove it, as needed.
            this.probtest2TableAdapter.Fill(this.pointsdataDataSet4.probtest2);
            // TODO: This line of code loads data into the 'pointsdataDataSet1.probtest' table. You can move, or remove it, as needed.
            this.probtestTableAdapter.Fill(this.pointsdataDataSet1.probtest);
            // TODO: This line of code loads data into the 'pointsdataDataSet6.worldside' table. You can move, or remove it, as needed.
            this.worldsideTableAdapter.Fill(this.pointsdataDataSet6.worldside);
             
            if (DataTrans.Value45==true)
            {
                label15.Visible = true;

                textBox5.Text = Convert.ToString("0, 463868415975304");
                textBox6.Text = Convert.ToString("1, 39160524792591");
                textBox7.Text = Convert.ToString("0, 463868415975304");
                textBox3.Text = Convert.ToString("1, 34160524792591");
                textBox4.Text = Convert.ToString("2, 31934207987652");

                DataTrans.Value46 = Convert.ToDouble(textBox5.Text);
                DataTrans.Value47 = Convert.ToDouble(textBox6.Text);
                DataTrans.Value50 = Convert.ToDouble(textBox7.Text);
                DataTrans.Value48 = Convert.ToDouble(textBox3.Text);
                DataTrans.Value49 = Convert.ToDouble(textBox4.Text);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rast1 = Convert.ToDouble(listBox2.SelectedValue.ToString());
            double rast2 = Convert.ToDouble(listBox3.SelectedValue.ToString());

            DataTrans.Value23 = rast1;
            DataTrans.Value24 = rast2;

            double koncen1 = Convert.ToDouble(textBox1.Text);
            double koncen2 = Convert.ToDouble(textBox2.Text);
        
            DataTrans.Value25 = koncen2;
            DataTrans.Value26 = koncen1;

            DataTrans.Value27 = listBox1.SelectedValue.ToString().Replace(" ", string.Empty);
            label7.Text = listBox1.SelectedValue.ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tmp1 = 0.5 * DataTrans.Value37;
            textBox5.Text = Convert.ToString(tmp1);
            DataTrans.Value46 = tmp1;

            double tmp2 = 1.5 * DataTrans.Value37;
            textBox6.Text = Convert.ToString(tmp2);
            DataTrans.Value47 = tmp2;

            double tmp3 = DataTrans.Value47 - 0.05;
            textBox3.Text = Convert.ToString(tmp3);
            DataTrans.Value48 = tmp3;

            double tmp4 = 2.5 * DataTrans.Value37;
            textBox4.Text = Convert.ToString(tmp4);
            DataTrans.Value49 = tmp2;

            double tmp5 = 0.5 * DataTrans.Value37;
            textBox7.Text = Convert.ToString(tmp5);
            DataTrans.Value50 = tmp5;

        }
    }
}
