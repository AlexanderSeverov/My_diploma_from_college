using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_pollution
{
    partial class ugol
    {
        public void st()
        {
            double xist = 5 + 0.000001;
            double yist = 5 + 0.000001;


            double Pi = 3.1415926536;

            double x= 10;
            double y = 10;

            double ugol = Math.Round(180 / Pi * Math.Atan((y - yist) / (x - xist)), 1);


            if ((x - xist) <= 0)
            {
                ugol = 180 + ugol;
            }


           if(ugol < 0)
            {
                ugol = 360 + ugol;
            }
     

        }
    }
}
