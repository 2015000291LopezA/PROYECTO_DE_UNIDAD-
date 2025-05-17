using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class tres : Form
    {
        public tres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double c);
            double.TryParse(textBox4.Text, out double x);
     
                double resultado = (a * Math.Pow(x, 2)) + (b * x) + c;
            label6.Text = resultado.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tres_Load(object sender, EventArgs e)
        {

        }
    }
}
