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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointsdataDataSet.pointroz' table. You can move, or remove it, as needed.
            this.pointrozTableAdapter.Fill(this.pointsdataDataSet.pointroz);
            // TODO: This line of code loads data into the 'pointsdataDataSet.pointroz' table. You can move, or remove it, as needed.
            this.pointrozTableAdapter.Fill(this.pointsdataDataSet.pointroz);
            // TODO: This line of code loads data into the 'pointsdataDataSet.pointroz' table. You can move, or remove it, as needed.
            this.pointrozTableAdapter.Fill(this.pointsdataDataSet.pointroz);

            this.polarvalueTableAdapter.Fill(this.pointsdataDataSet3.polarvalue);
          

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double params1 = Convert.ToDouble(listBox1.SelectedValue.ToString());
            double params2 = Convert.ToDouble(listBox2.SelectedValue.ToString());
            double params3 = Convert.ToDouble(listBox3.SelectedValue.ToString());
            double params4 = Convert.ToDouble(listBox4.SelectedValue.ToString());
            double params5 = Convert.ToDouble(listBox5.SelectedValue.ToString());
            double params6 = Convert.ToDouble(listBox6.SelectedValue.ToString());
            double params7 = Convert.ToDouble(listBox7.SelectedValue.ToString());
            double params8 = Convert.ToDouble(listBox8.SelectedValue.ToString());
            double params9 = Convert.ToDouble(listBox9.SelectedValue.ToString());
            double params10 = Convert.ToDouble(listBox10.SelectedValue.ToString());
            double params11 = Convert.ToDouble(listBox11.SelectedValue.ToString());
            double params12 = Convert.ToDouble(listBox12.SelectedValue.ToString());
            double params13 = Convert.ToDouble(listBox13.SelectedValue.ToString());
            double params14 = Convert.ToDouble(listBox14.SelectedValue.ToString());
            double params15 = Convert.ToDouble(listBox15.SelectedValue.ToString());

            DataTrans.Value8 = params1;
            DataTrans.Value9 = params2;
            DataTrans.Value10 = params3;
            DataTrans.Value11 = params4;
            DataTrans.Value12 = params5;
            DataTrans.Value13 = params6;
            DataTrans.Value14 = params7;
            DataTrans.Value15 = params8;
            DataTrans.Value16 = params9;
            DataTrans.Value17 = params10;
            DataTrans.Value18 = params11;
            DataTrans.Value19 = params12;
            DataTrans.Value20 = params13;
            DataTrans.Value21 = params14;
            DataTrans.Value22 = params15;
           

        }

      

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
            pointrozTableAdapter.Update(pointsdataDataSet.pointroz);

           

        }

        
    }
}
