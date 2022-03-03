using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isrpo1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            double r = Convert.ToDouble(textBox1.Text);
            double v = Convert.ToDouble(textBox2.Text);
            double vo = Convert.ToDouble(textBox3.Text);
            if (button2.Enabled == true)
            {
                double b = 666 + (13.7 * v) + (5 * r) + (6.8 * vo);
            }
            else if (button3.Enabled == true)
            {
                double b = 655 + (9.6 * v) + (1.8 * r) + (4.7 * vo);
            }
            textBox4.Text = b;
            Convert.To(textBox3.Text);
            string;
            */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
