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
    public partial class quince : Form
    {
        public quince()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out double x);
            double resultado = Math.Pow(x, 6) - Math.Pow(x, 7) + Math.Pow(x, 8);
            label4.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
