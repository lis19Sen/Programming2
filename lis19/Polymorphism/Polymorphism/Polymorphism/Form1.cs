using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        private Random random;
        private Graphics graphics;
        private int count;
        private Manager manager;
       
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            graphics = CreateGraphics();
            count = 0;
            manager = new Manager(random, graphics);
            timer1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //label1.Text = "area = " + caculatedArea + "square units";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Refresh();
            count++;
            if (count > 200)
            {
                count = 0;
                Refresh();
            }
            manager.CreatePolygon();
            manager.DrawPolygon();
            string caculatedArea = manager.CalculatePolygonArea();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
