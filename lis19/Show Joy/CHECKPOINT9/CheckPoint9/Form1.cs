using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPoint9
{
    public partial class Form1 : Form
    {
        //fields
        private controllor controllor;
        private Graphics graphics;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            random = new Random();
            controllor = new controllor(graphics, random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controllor.DrawAndMove();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
