using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conways
{
    public partial class Form1 : Form
    {
        private const int FORMHEIGHT = 600;
        private const int FORMWIDTH = 700; 
        
        private Random random;
        private Grid grid;
        private World world;

        //nGeneration is used to count the timertick and output to the label on the form
        private int generation = 0;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            grid = new Grid();
            world = new World(random, grid);
            
            // set the Properties of the form
            Top = 0;
            Left = 0;
            Height = FORMHEIGHT;
            Width = FORMWIDTH;

            // add the grid object to the list of controls on the form
            Controls.Add(grid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // tell the world to update
            world.UpdateWorld();
            // draw the world
            world.Draw();

            // increment the generation count
            generation++;
            // write generation count to the label

            label1.Text = Convert.ToString(generation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear the world
            world.Clear();
            // fill the world
            world.Fill();
            // draw the world
            world.Draw();
            // set the generation count to 0
            generation = 0;
            // write generation count to the label
            label1.Text = Convert.ToString(generation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear the world
            world.Clear();
            // draw the world
            world.Draw();
            // set the generation count to 0
            generation = 0;
            // write generation count to the label
            label1.Text = Convert.ToString(generation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // enable the timer
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // disable the timer
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // tell the world to update
            world.UpdateWorld();
            // draw the world
            world.Draw();
            // increment the generation count
            generation++;
            // write generation count to the label
            label1.Text = Convert.ToString(generation);

        }
    }
}
