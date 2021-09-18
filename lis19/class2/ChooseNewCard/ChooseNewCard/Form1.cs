using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseNewCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.D13;
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.D12;
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.D11;
            }
            if (radioButton4.Checked)
            {
                pictureBox2.Image = Properties.Resources.H1;
            }
            if (radioButton5.Checked)
            {
                pictureBox2.Image = Properties.Resources.H2;
            }
            if (radioButton6.Checked)
            {
                pictureBox2.Image = Properties.Resources.H3;
            }
        }
    }
}
