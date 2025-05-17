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
    public partial class cuatro : Form
    {
        public cuatro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double x);

            double resultado = Math.Pow(b, 3) + (a * x) + 1;
            label6.Text = $"{resultado}";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
