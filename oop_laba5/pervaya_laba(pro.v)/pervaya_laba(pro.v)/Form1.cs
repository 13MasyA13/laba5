using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pervaya_laba_pro.v_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            double a, x, bt;
            a = Convert.ToDouble(textBox2.Text);
            x = Convert.ToDouble(textBox3.Text);
            bt = Convert.ToDouble(textBox4.Text);
            double ch = Math.Exp(3 * x) * Math.Tan(x + bt) - Math.Log10(Math.Pow(x, 3) - a) +
                Math.Pow(a + Math.Pow(x, 3), 1 / 3);
            double zn = Math.Pow(x, 4) + Math.Sqrt(x + 1) - Math.Pow(Math.Sin(bt), 2) + 0.9 *
                Math.Pow(10, 4) + 0.9 * a * x;
            double y = ch / zn;
            listBox3.Text = Convert.ToString(y);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
