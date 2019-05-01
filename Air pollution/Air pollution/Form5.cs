using System;
using System.Windows.Forms;

namespace Air_pollution
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pi = 3.1415926536;
            double h = 0.01;
            int k = 0;
            
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double pp = 0;

            double rr2 = 1 / DataTrans.Value3 - 1 / DataTrans.Value2;
            double rr1 = 1 / DataTrans.Value2 - 1 / DataTrans.Valuemm1;

            double qq1 = Math.Log(DataTrans.Value4 / DataTrans.Value5);
            double qq2 = Math.Log(DataTrans.Value5 / DataTrans.Value6);

            double ss1 = Math.Log(DataTrans.Value2 / DataTrans.Valuemm1);
            double ss2 = Math.Log(DataTrans.Value3 / DataTrans.Value2);

            double tt2 = (qq1 * rr2 - qq2 * rr1) / (ss1 * rr2 - ss2 * rr1);
            double tt3 = (qq1 * ss2 - qq2 * ss1) / (ss2 * rr1 - ss1 * rr2);

            double tt1 = DataTrans.Value4 * Math.Pow(DataTrans.Valuemm1,tt2) * Math.Exp(tt3 / DataTrans.Valuemm1);

      //      Console.WriteLine("Value7_ = " + DataTrans.Value7 + "|" + DataTrans.Value17 + "|");
            if (DataTrans.Value7 == "С")
            {
              //  Console.WriteLine("!!!");
                pp = DataTrans.Value16;
            }
            else if (DataTrans.Value7 == "CСВ")
            {
                pp = DataTrans.Value17;
            }
            else if (DataTrans.Value7 == "СВ")
            {
                pp = DataTrans.Value18;
            }
            else if (DataTrans.Value7 == "ВСВ")
            {
                pp = DataTrans.Value19;
            }
            else if (DataTrans.Value7 == "В")
            {
                pp = DataTrans.Value20;
            }
            else if (DataTrans.Value7 == "ВЮВ")
            {
                pp = DataTrans.Value21;
            }
            else if (DataTrans.Value7 == "Ю")
            {
                pp = DataTrans.Value8;
            }
            else if (DataTrans.Value7 == "ЮЮЗ")
            {
                pp = DataTrans.Value9;
            }
            else if (DataTrans.Value7 == "ЮЗ")
            {
                pp = DataTrans.Value10;
            }
            else if (DataTrans.Value7 == "ЗЮЗ")
            {
                pp = DataTrans.Value11;
            }
            else if (DataTrans.Value7 == "З")
            {
                pp = DataTrans.Value12;
            }
            else if (DataTrans.Value7 == "ЗСЗ")
            {
                pp = DataTrans.Value13;
            }
            else if (DataTrans.Value7 == "СЗ")
            {
                pp = DataTrans.Value14;
            }
            else if (DataTrans.Value7 == "ССЗ")
            {
                pp = DataTrans.Value15;
            }
           
          
            for (k = 1; k<(5/h); k++)
                {
                double rr = k*h ;
     
                if ((rr < 1) && (rr > 0.01))
                {
                    sum1 = sum1 + 1 / Math.Pow(rr, tt2 - 1) * Math.Exp(-tt3 / rr);
                }
                else if (rr < 2)
                {
                    sum2 = sum2 + 1 / Math.Pow(rr, tt2 - 1) * Math.Exp(-tt3 / rr);
                }
                else if ((rr < 3) && (rr > 2))
                {
                    sum3 = sum3 + 1 / Math.Pow(rr, tt2 - 1) * Math.Exp(-tt3 / rr);
                }
                else if ((rr < 4) && (rr > 3))
                {
                    sum4 = sum4 + 1 / Math.Pow(rr, tt2 - 1) * Math.Exp(-tt3 / rr);
                }
                else if ((rr < 5) && (rr > 4))
                {
                    sum5 = sum5 + 1 / Math.Pow(rr, tt2 - 1) * Math.Exp(-tt3 / rr);
                }


                



            }

            sum1 = sum1 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum2 = sum1 + sum2 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum3 = sum2 + sum3 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum4 = sum3 + sum4 * 2 * Pi / 16 * tt1 / pp * 100 * h;
            sum5 = sum4 + sum5 * 2 * Pi / 16 * tt1 / pp * 100 * h;

          //  Math.Round(sum1, 5);

//            Console.WriteLine(sum1);

            label2.Text = sum1.ToString();
            label3.Text = sum2.ToString();
            label4.Text = sum3.ToString();
            label5.Text = sum4.ToString();
            label6.Text = sum5.ToString();


        }
    }
}
