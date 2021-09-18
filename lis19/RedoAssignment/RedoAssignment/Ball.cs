/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create a ball, make the ball move
   Description:		    To define the attribute of ball, icluding creating ball, moveing the ball,
                        blocks disapear when the ball hit the blocks and the ball change Y direction.
   Known Bugs:		    The ball can run in paddle.
   Additional Features: When game over, the player has a new ball, the new ball has a random color
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoAssignment
{
    public class Ball
    {
        //constant, the size of the ball and the const to make the ball change direction
        private const int BALLSIZE = 20;
        private const int GOBACK = -1;

        //field, also called data members
        private Graphics graphics;
        private Point ballPosition;
        private Color color;
        private Brush bursh;
        private Point speed;
        private Size cilentSize;
        private bool checkGame;


        //constructor, assign initial values to the fields
        public Ball(Graphics graphics, Point ballPosition, Color color, Point speed, Size cs)
        {
            this.BallPosition = ballPosition;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(color);
            this.Speed = speed;
           
            cilentSize = cs;
        }

        //method, to draw the ball
        public void Draw()
        {
            graphics.FillEllipse(bursh, BallPosition.X, BallPosition.Y, BALLSIZE, BALLSIZE);
        }

        //method, to move the ball
        public void Move()
        {
            ballPosition.X += Speed.X;
            ballPosition.Y += Speed.Y;
        }

        //to define the range of the area that the ball can move inside and make the ball move inside the form
        public void BallBehavior()
        {
            if (BallPosition.X + BALLSIZE  >= cilentSize.Width || BallPosition.X <= 0)
            {
                speed.X *= GOBACK;
            }

            if ( BallPosition.Y <= 0 )
            {
                speed.Y *= GOBACK;
            }
            if ((BallPosition.Y + BALLSIZE + 20) >= cilentSize.Height)
            {
                CheckGame = true;
            }
        }

       //when the ball hit the blocks, the ball change Y direction, and the block disapear
        public void BlockBomb(List<Block> Blocks)
        {
            for (int i = 0; i < Blocks.Count; i++)
            {


                if ((BallPosition.Y <= (Blocks[i].Blockpoint.Y + 20)) && ((BallPosition.Y + BALLSIZE) >= Blocks[i].Blockpoint.Y))
                {
                    if ((BallPosition.X <= (Blocks[i].Blockpoint.X + 80)) && ((BallPosition.X + BALLSIZE) >= Blocks[i].Blockpoint.X))
                    {
                        speed.Y *= GOBACK;
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Speech_On);
                        soundPlayer.Play();
                        Blocks.RemoveAt(i);
                    }
                }
            }
        }

        //method, when the ball hit tha paddle, the ball change Y direction
        public void PaddleControlBall(Paddle paddle)
        {
            if ((BallPosition.Y <= paddle.Position.Y + 20) && (BallPosition.Y + BALLSIZE >= paddle.Position.Y))
            {
                if ((BallPosition.X <= paddle.Position.X + 80) && (BallPosition.X + BALLSIZE >= paddle.Position.X))
                {
                    speed.Y *= GOBACK;
                }
            }
        }
        //properties, to pass the value in different classed
        public bool CheckGame { get => checkGame; set => checkGame = value; }
        public Point BallPosition { get => ballPosition; set => ballPosition = value; }
        public Point Speed { get => speed; set => speed = value; }
    }
}
