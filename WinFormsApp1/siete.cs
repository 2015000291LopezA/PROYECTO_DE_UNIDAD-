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
    public partial class siete : Form
    {
        public siete()
        {
            InitializeComponent();
        }

        private void siete_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double d);
            double.TryParse(textBox2.Text, out double a);
            double.TryParse(textBox3.Text, out double b);
            double.TryParse(textBox4.Text, out double x);

            double resultado = Math.Pow(d, 3) + (a * Math.Pow(x, 2)) + (b * x) + 1;
            label7.Text = $" {resultado}";


        }
    }
}
