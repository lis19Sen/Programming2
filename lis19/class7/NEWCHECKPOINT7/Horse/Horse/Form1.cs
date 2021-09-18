using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
    public partial class Form1 : Form
    {
        //constant
        private const int PICTUREBOXNUMBER = 4;
        //field
        private Random random;
        private Controller controller;
        private PictureBox[] pictureBoxes;

        //constructore
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            random = new Random();
            pictureBoxes = new PictureBox[PICTUREBOXNUMBER];
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            controller = new Controller(random, pictureBoxes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //controller.Restart();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.Race();
            controller.CheckWinner(panel1.Left);
            if (controller.IsOver == true)
            {
                timer1.Enabled = false;
                MessageBox.Show(controller.Winner + "has won!");
            }
        }
    }
}
