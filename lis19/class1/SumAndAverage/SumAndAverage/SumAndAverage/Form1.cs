using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumAndAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int num3 = Convert.ToInt16(textBox3.Text);
            int num4 = Convert.ToInt16(textBox4.Text);
            int num5 = Convert.ToInt16(textBox5.Text);
            int sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;
            textBox6.Text = Convert.ToString(sum);
            //textBox7.Text = Convert.ToString(average);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int num3 = Convert.ToInt16(textBox3.Text);
            int num4 = Convert.ToInt16(textBox4.Text);
            int num5 = Convert.ToInt16(textBox5.Text);
            int sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;
            textBox7.Text = Convert.ToString(average);
        }
    }
}
