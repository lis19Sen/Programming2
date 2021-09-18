/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a form for player
   Description:		    Game Form
   Known Bugs:		    No
   Additional Features: More attractive
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoAssignment
{
    public partial class Form1 : Form
    {
        //fields,
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Graphics graphics;
        private Controller controller;

        //constructer
        public Form1()
        {
            InitializeComponent();
            //off-screen image,stored in memory(buffer)
            bufferImage = new Bitmap(Width, Height);
            //drawing surface that sits on the bufferImage
            bufferGraphics = Graphics.FromImage(bufferImage);            
            graphics = CreateGraphics();
            controller = new Controller(bufferGraphics, new Size(ClientSize.Width, ClientSize.Height));
        }

       

     

        //use time1_Tick envet to drive all the methods
        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            controller.DrawBlocks();
            controller.Run();
            controller.DrawPaddle();
            graphics.DrawImage(bufferImage, 0, 0);
            if (controller.TestGame == true) //check the the game statues when the ball hit the bottom of form
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over!!!");
                controller.TestGame = false;
            }
            if (controller.BlockDestroyed == true)//check the game status when the blocks are disspeared
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over!!!");
            }
        }

        //to use Mouse_Move enent to drive paddle
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            controller.MovePaddle(e.Location.X);
        }

        //pause the game by press down button
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = false;
        }

        //to start the game when change to the game form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
