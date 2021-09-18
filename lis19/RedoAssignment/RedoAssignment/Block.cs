/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a number of blocks
   Description:		    At the beginning of the game, it should draw a number of blocks from the 
                        defined the height,because i need to give the positin to put score textbox.
   Known Bugs:		    the blocks can interaction
   Additional Features: Random color of blocks, random rows, columns
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoAssignment
{
    public class Block
    {
        //constant, define the width and hieight of blocks
        private const int BLOCK_WIDTH = 80;
        private const int BLOCK_HIGHT = 20;
        //field
        private Graphics graphics;
        private Point blockpoint;
        private Color color;
        private Brush bursh;
        private Rectangle rectangle;

        //constructer
        public Block(Graphics graphics, Point blockpoint, Color color)
        {

            this.Blockpoint = blockpoint;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(Color.Pink);
            this.rectangle = new Rectangle(blockpoint.X, blockpoint.Y, BLOCK_WIDTH, BLOCK_HIGHT);
        }

        //method, to draw blocks
        public void Draw()
        {
            graphics.FillRectangle(bursh, this.rectangle);
        }

        //property, to pass value in different classes
        public Point Blockpoint { get => blockpoint; set => blockpoint = value; }


    }
}
