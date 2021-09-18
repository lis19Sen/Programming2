using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        //constant
        private const int SLOW = 2000;
        private const int MEDIUM = 1000;
        private const int FAST = 500;

        //field
        private Random random;
        private Graphics graphics;
        private Light light;
       // private 
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            graphics = CreateGraphics();
            light = new Light(graphics, Color.Black, new Point(250,250),500);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            light.Flash();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            light.Draw(Color.Black);
        }
    }
}
