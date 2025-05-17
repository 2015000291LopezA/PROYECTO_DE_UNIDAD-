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
    public partial class once : Form
    {
        public once()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double x);

            double resultado = x + (Math.Pow(x, 2) / x);
            label4.Text = resultado.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        { textBox1.Clear(); }
            
           
    }
}
