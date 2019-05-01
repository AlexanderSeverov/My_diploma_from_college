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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();

       
                double rmax = DataTrans.Value37;

                double r1 = DataTrans.Value23;
                double r2 = DataTrans.Value24;

                double q1 = DataTrans.Value25;
                double q2 = DataTrans.Value26;

                double tt2 = (Math.Log(q1 / q2) + 2 * rmax * (1 / r1 - 1 / r2)) / Math.Log(r1 / r2);
                double tt1 = q1 * Math.Exp(2 * rmax / r1) / Math.Pow(r1, tt2);

         
            double [] arrayx= new double[201];
            double [] arrayy = new double[201];
            int [] ss = new int[] { 31, 31, 9, 5 , 4, 6, 4, 10 };
            double x = 0.01;
            double y = 0.01;
            int i = 0;
            int m = 0;
            double xist = 5;
            double yist = 5;
            double fi = 0;
            double r = 0;
            double sss = 0;



            for (i = 0; i < arrayx.Length; i++)
            {
                arrayx[i] = x;          
                x = x + 0.05;
            }
            for (m = 0; m < arrayy.Length; m++)
            {
                arrayy[m] = y;
                y = y + 0.05;
            }


            double [,] Q = new double[i,m];
            //double q = 0;

            for (i = 0; i < arrayx.Length; i++)
            {
                for (m = 0; m < arrayy.Length; m++)
                {

                    fi = 180 / 3.14 * Math.Atan((arrayy[m] - yist) / (arrayx[i] - xist));

                    if ((arrayx[i] - xist) <= 0)
                    {
                        fi = 180 + fi;
                    }

                    if (fi < 0)
                    {
                        fi = fi + 360;
                    }
                    if (fi > 360)
                    {
                        fi = fi - 360;
                    }

                    //  q = 0;

                    r = Math.Sqrt((Math.Pow((arrayx[i] - xist), 2)) + (Math.Pow((arrayy[m] - yist), 2)));
                    //q = q + fi * tt1 * Math.Pow(r, tt2) * Math.Exp(-2 * rmax / r);

                    if ((fi >= 0) & (fi <= 45))

                        sss = (ss[1] * fi + ss[0] * (45 - fi)) / 45;

                    else
                        if ((fi >= 45) & (fi <= 90))
                        sss = (ss[2] * (fi - 45) + ss[1] * (90 - fi)) / 45;
                    else
                    if ((fi >= 90) & (fi <= 135))
                        sss = (ss[3] * (fi - 90) + ss[2] * (135 - fi)) / 45;
                    else
                    if ((fi >= 135) & (fi <= 180))
                        sss = (ss[4] * (fi - 135) + ss[3] * (180 - fi)) / 45;
                    else
                    if ((fi >= 180) & (fi <= 225))
                        sss = (ss[5] * (fi - 180) + ss[4] * (225 - fi)) / 45;
                    else
                    if ((fi >= 225) & (fi <= 270))
                        sss = (ss[6] * (fi - 225) + ss[5] * (270 - fi)) / 45;
                    else
                        if ((fi >= 270) & (fi <= 315))
                        sss = (ss[7] * (fi - 270) + ss[6] * (315 - fi)) / 45;
                    else
                    if ((fi >= 315) & (fi <= 360))
                        sss = (ss[0] * (fi - 315) + ss[7] * (360 - fi)) / 45;

                    Q[i, m] = sss * tt1 * Math.Pow(r, tt2) * Math.Exp(-2 * rmax / r);

                    isoSurface1.Add(i, Q[i, m],m);
         

                    isoSurface1.RefreshSeries();
                    isoSurface1.CheckDataSource();
                   

                   
                }
                
            }

            }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void tChart1_Click(object sender, EventArgs e)
        {

        }
    }
}
