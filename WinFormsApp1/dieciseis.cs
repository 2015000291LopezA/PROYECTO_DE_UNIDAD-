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
    public partial class dieciseis : Form
    {
        public dieciseis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox1.Text, out double b);
            double.TryParse(textBox1.Text, out double x);

            double resultado = (a * Math.Pow(b, 3)) + (x * Math.Pow(b, 4));
            label6.Text = resultado.ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
