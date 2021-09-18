using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTimerComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            x++;
            textBox1.Text = x.ToString();

            pictureBox1.Top += 10;
            pictureBox1.Left += 5;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
