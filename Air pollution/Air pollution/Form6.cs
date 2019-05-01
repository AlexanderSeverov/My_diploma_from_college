using System;
using System.Windows.Forms;


namespace Air_pollution
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
           


        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rast1 = Convert.ToDouble(listBox1.SelectedValue.ToString());
            double rast2 = Convert.ToDouble(listBox2.SelectedValue.ToString());
            double rast3 = Convert.ToDouble(listBox3.SelectedValue.ToString());
         

            DataTrans.Valuemm1 = rast1;
            DataTrans.Value2 = rast2;
            DataTrans.Value3 = rast3;

            double koncen1 = Convert.ToDouble(textBox1.Text);
            double koncen2 = Convert.ToDouble(textBox2.Text);
            double koncen3 = Convert.ToDouble(textBox3.Text);

            DataTrans.Value4 = koncen3;
            DataTrans.Value5 = koncen2;
            DataTrans.Value6 = koncen1;

            DataTrans.Value7 = listBox4.SelectedValue.ToString().Replace(" ", string.Empty);
            label6.Text = listBox4.SelectedValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointsdataDataSet5.probtest3' table. You can move, or remove it, as needed.
            this.probtest3TableAdapter.Fill(this.pointsdataDataSet5.probtest3);
            // TODO: This line of code loads data into the 'pointsdataDataSet4.probtest2' table. You can move, or remove it, as needed.
            this.probtest2TableAdapter.Fill(this.pointsdataDataSet4.probtest2);
            // TODO: This line of code loads data into the 'pointsdataDataSet1.probtest' table. You can move, or remove it, as needed.
            this.probtestTableAdapter.Fill(this.pointsdataDataSet1.probtest);
            // TODO: This line of code loads data into the 'pointsdataDataSet6.worldside' table. You can move, or remove it, as needed.
            this.worldsideTableAdapter.Fill(this.pointsdataDataSet6.worldside);
            // TODO: This line of code loads data into the 'pointsdataDataSet6.worldside' table. You can move, or remove it, as needed.
            this.worldsideTableAdapter.Fill(this.pointsdataDataSet6.worldside);
            // TODO: This line of code loads data into the 'pointsdataDataSet3.polarvalue' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet5.probtest3' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet4.probtest2' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet4.probtest2' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet2.probtest' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet2.probtest' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pointsdataDataSet1.probtest' table. You can move, or remove it, as needed.

            if (DataTrans.Value45 == true)
            {
                label18.Visible = true;

                
                double prob1pointstart = 0.2 * DataTrans.Value37;
                double prob2pointstart = 0.6 * DataTrans.Value37;
                double prob3pointstart = 1.25 * DataTrans.Value37;

                double prob1pointend = prob2pointstart - 0.05;
                double prob2pointend = prob3pointstart - 0.05;
                double prob3pointend = 3 * DataTrans.Value37;


                DataTrans.Value38 = prob1pointstart;
                DataTrans.Value39 = prob2pointstart;
                DataTrans.Value40 = prob3pointstart;

                DataTrans.Value41 = prob1pointend;
                DataTrans.Value42 = prob2pointend;
                DataTrans.Value43 = prob3pointend;

                double distance1and2 = 0.5 * DataTrans.Value37;
                DataTrans.Value44 = distance1and2;

                textBox4.Text = Convert.ToString(prob1pointstart);
                textBox5.Text = Convert.ToString(prob2pointstart);
                textBox6.Text = Convert.ToString(prob3pointstart);

                textBox7.Text = Convert.ToString(prob1pointend);
                textBox8.Text = Convert.ToString(prob2pointend);
                textBox9.Text = Convert.ToString(prob3pointend);

                textBox10.Text = Convert.ToString(distance1and2);
                textBox11.Text = Convert.ToString(distance1and2);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double prob1pointstart = 0.2 * DataTrans.Value37;
            double prob2pointstart = 0.6 * DataTrans.Value37;
            double prob3pointstart = 1.25 * DataTrans.Value37;

            double prob1pointend = prob2pointstart - 0.05;
            double prob2pointend = prob3pointstart - 0.05;
            double prob3pointend = 3 * DataTrans.Value37;


            DataTrans.Value38 = prob1pointstart;
            DataTrans.Value39 = prob2pointstart;
            DataTrans.Value40 = prob3pointstart;

            DataTrans.Value41 = prob1pointend;
            DataTrans.Value42 = prob2pointend;
            DataTrans.Value43 = prob3pointend;

            double distance1and2 = 0.5 * DataTrans.Value37;
            DataTrans.Value44 = distance1and2;

            textBox4.Text = Convert.ToString(prob1pointstart);
            textBox5.Text = Convert.ToString(prob2pointstart);
            textBox6.Text = Convert.ToString(prob3pointstart);

            textBox7.Text = Convert.ToString(prob1pointend);
            textBox8.Text = Convert.ToString(prob2pointend);
            textBox9.Text = Convert.ToString(prob3pointend);

            textBox10.Text = Convert.ToString(distance1and2);
            textBox11.Text = Convert.ToString(distance1and2);
        }
    }
}
