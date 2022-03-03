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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "admin") && (textBox2.Text == "1234"))
            {

                Form5 f5 = new Form5();
                f5.Show();

            }
            else
            {
                if ((textBox1.Text == "user") && (textBox2.Text == "123"))
                {
                    Form5 f5 = new Form5();
                    f5.Show();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль");
            } 
        }
    }
}
