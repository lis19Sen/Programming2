/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a paddle, make the paddle move
   Description:		    To define the attribute of paddle, icluding creating paddle, moveing the paddle,
                        the paddle will move horizentally and hit the ball.
   Known Bugs:		    The ball can run in paddle, the paddle can go out of right side form.
   Additional Features: will try by setting the value of mouseX less than 800.
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoAssignment
{
    public class Paddle
    {
        //constant
        private const int PADDLE_WIDTH = 80;
        private const int PADDLE_HIGHT = 20;

        //field
        private Graphics graphics;
        private Point position;
        private Color color;
        private Brush bursh;
        //private Rectangle rectangle;


        public Paddle(Graphics graphics, Point paddleposition, Color color)
        {

            this.Position = paddleposition;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(Color.Pink);
           
        }

        //method, to draw paddle
        public void Draw()
        {
            graphics.FillRectangle(bursh, new Rectangle(Position.X, Position.Y, PADDLE_WIDTH, PADDLE_HIGHT));
        }

        //method, to move the paddle by only passing in X value of mouse, which means the paddle only move horizentally
        public void Move(int mouseX)
        {
         position.X = mouseX;
        }

        //property, to pass value in different classes
        public Point Position { get => position; set => position = value; }
    }
}
