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
    public partial class catorce : Form
    {
        public catorce()
        {
            InitializeComponent();
        }

        private void catorce_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double x);

            double resultado = (a * x) + (b * Math.Pow(x, 2)) - (a * b * x);
            label4.Text= resultado.ToString();
        }

    }
}
