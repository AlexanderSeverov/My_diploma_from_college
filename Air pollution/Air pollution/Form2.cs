using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_pollution
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointsdataDataSet1.probtest' table. You can move, or remove it, as needed.
            this.probtestTableAdapter.Fill(this.pointsdataDataSet1.probtest);
            // TODO: This line of code loads data into the 'pointsdataDataSet6.worldside' table. You can move, or remove it, as needed.
            this.worldsideTableAdapter.Fill(this.pointsdataDataSet6.worldside);
            // TODO: This line of code loads data into the 'pointsdataDataSet3.polarvalue' table. You can move, or remove it, as needed.
            this.polarvalueTableAdapter.Fill(this.pointsdataDataSet3.polarvalue);
            // TODO: This line of code loads data into the 'pointsdataDataSet5.probtest3' table. You can move, or remove it, as needed.
            this.probtest3TableAdapter.Fill(this.pointsdataDataSet5.probtest3);
            // TODO: This line of code loads data into the 'pointsdataDataSet4.probtest2' table. You can move, or remove it, as needed.
            this.probtest2TableAdapter.Fill(this.pointsdataDataSet4.probtest2);
            // TODO: This line of code loads data into the 'pointsdataDataSet.point' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'pointsdataDataSet1.probtest' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'pointsdataDataSet.point' table. You can move, or remove it, as needed.
         





        }





        private void button1_Click(object sender, EventArgs e)
        {      
     
        
          probtest2TableAdapter.Update(pointsdataDataSet4.probtest2);
          probtest3TableAdapter.Update(pointsdataDataSet5.probtest3);
          polarvalueTableAdapter.Update(pointsdataDataSet3.polarvalue);
          worldsideTableAdapter.Update(pointsdataDataSet6.worldside);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

       
    }
}
