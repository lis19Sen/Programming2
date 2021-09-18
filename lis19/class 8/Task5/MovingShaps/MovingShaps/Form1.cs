using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingShaps
{
    
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 50; x < 500; x += 40)
            {
                
                graphics.FillEllipse(Brushes.Blue, new Rectangle(x, 50, 60, 60));
                graphics.FillEllipse(Brushes.Black, new Rectangle(x, 200, 60, 60));
                graphics.FillEllipse(Brushes.Purple, new Rectangle(x, 300, 60, 60));
                graphics.DrawEllipse(Pens.Red, new Rectangle(x, 50, 60, 60));
                Thread.Sleep(100);
            }
            if (checkBox1.Checked == true)
            {
                Refresh();
            }


             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            graphics.FillEllipse(Brushes.Blue, new Rectangle(150, 150, 60, 60));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
