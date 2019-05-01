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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pi = 3.1415926536;
            double h = 0.01;
            double k = 0;

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double pp = 0;

            double q1 = DataTrans.Value25;
            double q2 = DataTrans.Value26;


            double r1 = DataTrans.Value23;
            double r2 = DataTrans.Value24;


            double rmax = DataTrans.Value37;


            double tt2 = (Math.Log(q1 / q2) + 2 * rmax * (1 / r1 - 1 / r2)) / Math.Log(r1 / r2);
            double tt1 = q1 * Math.Exp(2 * rmax / r1) / Math.Pow(r1, tt2);

            if (DataTrans.Value27 == "С")
            {
            //    Console.WriteLine("!!!");
                pp = DataTrans.Value16;
            }
            else if (DataTrans.Value27 == "CСВ")
            {
                pp = DataTrans.Value17;
            }
            else if (DataTrans.Value27 == "СВ")
            {
                pp = DataTrans.Value18;
            }
            else if (DataTrans.Value27 == "ВСВ")
            {
                pp = DataTrans.Value19;
            }
            else if (DataTrans.Value27 == "В")
            {
                pp = DataTrans.Value20;
            }
            else if (DataTrans.Value27 == "ВЮВ")
            {
                pp = DataTrans.Value21;
            }
            else if (DataTrans.Value27 == "Ю")
            {
                pp = DataTrans.Value8;
            }
            else if (DataTrans.Value27 == "ЮЮЗ")
            {
                pp = DataTrans.Value9;
            }
            else if (DataTrans.Value27 == "ЮЗ")
            {
                pp = DataTrans.Value10;
            }
            else if (DataTrans.Value27 == "ЗЮЗ")
            {
                pp = DataTrans.Value11;
            }
            else if (DataTrans.Value27 == "З")
            {
                pp = DataTrans.Value12;
            }
            else if (DataTrans.Value27 == "ЗСЗ")
            {
                pp = DataTrans.Value13;
            }
            else if (DataTrans.Value27 == "СЗ")
            {
                pp = DataTrans.Value14;
            }
            else if (DataTrans.Value27 == "ССЗ")
            {
                pp = DataTrans.Value15;
            }

            for (k = 1; k < (5 / h); k++)
            {
                double rr = k * h;

                if ((rr < 1) && (rr > 0.01))
                {
                    sum1 = sum1 + Math.Pow(rr, tt2 + 1) * Math.Exp(-2 * rmax / rr);
                }
                else if (rr < 2)
                {
                    sum2 = sum2 + Math.Pow(rr, tt2 + 1) * Math.Exp(-2 * rmax / rr);
                }
                else if ((rr < 3) && (rr > 2))
                {
                    sum3 = sum3 + Math.Pow(rr, tt2 + 1) * Math.Exp(-2 * rmax / rr);
                }
                else if ((rr < 4) && (rr > 3))
                {
                    sum4 = sum4 + Math.Pow(rr, tt2 + 1) * Math.Exp(-2 * rmax / rr);
                }
                else if ((rr < 5) && (rr > 4))
                {
                    sum5 = sum5 + Math.Pow(rr, tt2 + 1) * Math.Exp(-2 * rmax / rr);
                }



            }
            sum1 = sum1 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum2 = sum1 + sum2 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum3 = sum2 + sum3 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum4 = sum3 + sum4 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum5 = sum4 + sum5 * 2 * Pi / 16 * tt1 / pp * 100 * h;

            //Math.Round(sum1, 5);

          //  Console.WriteLine(sum1);

            label6.Text = sum1.ToString();
            label7.Text = sum2.ToString();
            label8.Text = sum3.ToString();
            label9.Text = sum4.ToString();
            label10.Text = sum5.ToString();


        }
    }
}
