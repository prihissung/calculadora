using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma,  num1, num2;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            soma = num1 + num2;

            label4.Text = label4.Text + "Soma = " + soma;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int subtracao, num1, num2;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            subtracao = num1 - num2;

            label4.Text = label4.Text + "subtração = " + subtracao;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int multi, num1, num2;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            multi = num1 * num2;

            label4.Text = label4.Text + "Multiplicação = " + multi;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int div, num1, num2;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            div = num1 / num2;

            label4.Text = label4.Text + "Divisão = " + div;

        }
    }
}
