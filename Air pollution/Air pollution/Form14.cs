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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointsdataDataSet.point' table. You can move, or remove it, as needed.
          
           // chart1.SeriesCollection.DataPoint.YValues

             
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }

      

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.SelectedItem = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "сульфаты (мг/л)")
            {
                Form15 f15 = new Form15();
                f15.Show();

                Close();
            }

            if (listBox1.SelectedItem == "фториды (мг/л)")
            {
                Form16 f16 = new Form16();
                f16.Show();

                Close();
            }

            if (listBox1.SelectedItem == "хлориды (мг/л)")
            {
                Form17 f17 = new Form17();
                f17.Show();

                Close();
            }

            if (listBox1.SelectedItem == "нитраты (мг/л)")
            {
                Form18 f18 = new Form18();
                f18.Show();

                Close();
            }

            if (listBox2.SelectedItem == "Расстояние до завода, км")
            {
                Form19 f19 = new Form19();
                f19.Show();

                Close();
            }

            if (listBox2.SelectedItem == "Вес снега, кг")
            {
                Form20 f20 = new Form20();
                f20.Show();

                Close();
            }

            if (listBox2.SelectedItem == "Вес осадка, г")
            {
                Form21 f21 = new Form21();
                f21.Show();

                Close();
            }

            if (listBox2.SelectedItem == "Удельное содержание осадка в снеге, мкг/кг")
            {
                Form22 f22 = new Form22();
                f22.Show();

                Close();
            }

            if (listBox2.SelectedItem == "Распределение осадка в снеге, г/м2")
            {
                Form23 f23 = new Form23();
                f23.Show();

                Close();
            }

            if (listBox3.SelectedItem == "Нафталин,Аценафтилен,Аценафтен")
            {
                Form25 f25 = new Form25();
                f25.Show();

                Close();
            }

            if (listBox3.SelectedItem == "Флуорен,Антрацен,Бенз(j)флуорантрен")
            {
                Form26 f26 = new Form26();
                f26.Show();

                Close();
            }

            if (listBox3.SelectedItem == "Бенз(a)пирен,Перилен,Бенз(ghi)перилен,Расстояние от завода")
            {
                Form27 f27 = new Form27();
                f27.Show();

                Close();

            }
            
            if (listBox4.SelectedItem == "Объем проб,∑канц_ПАУ,∑неканц_ПАУ")
            {
                Form28 f28 = new Form28();
                f28.Show();

                Close();

            }   
            
                 if (listBox4.SelectedItem == "∑ ПАУ,Фенантрен,Флуорантрен")
            {
                Form29 f29 = new Form29();
                f29.Show();

                Close();

            }
            
             if (listBox4.SelectedItem == "Пирен,Хризен,Бенз(k)флуорантрен")
            {
                Form30 f30 = new Form30();
                f30.Show();

                Close();

            }

            if (listBox4.SelectedItem == "Бенз(b)флуорантрен,Бенз(e)пирен,Бенз(а)антрацен")
            {
                Form32 f32 = new Form32();
                f32.Show();

                Close();

            }
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.Show();
            Close();
        }

        private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox3.SelectedItem = null;
        }

        private void listBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox4.SelectedItem = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            f31.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form34 f34 = new Form34();
            f34.Show();
            Close();
        }
    }
}
