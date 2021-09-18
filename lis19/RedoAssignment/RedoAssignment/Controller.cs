/* Program name: 	    <<Breakout>>
   Project file name:   Assignment
   Author:		        Sen Li
   Date:	            19/09/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        to call the method form object class, control the behaviour of the object
   Description:		    To define the attribute of ball, icluding creating ball, moveing the ball,
                        blocks disapear when the ball hit the blocks and the ball change Y direction.
   Known Bugs:		    The ball can run in paddle.
   Additional Features: When game over, the player has a new ball, the new ball has a random color
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoAssignment
{
    public class Controller
    {
        //constant
        private const int BEGINNINGBALLX = 300;
        private const int BEGINNINGBALLY = 400;
        private const int NEWBALLWIDTH = 300;
        private const int NEWBALLHEIGHT = 150;
        private const int BALLSPEEDX = 15;
        private const int BALLSPEEDY = -15;
        private const int BLOCKBEGINX = 87;
        private const int BLOCKBEGINY = 30;
        private const int PADDLEX = 500;
        private const int PADDLEY = 500;
        private const int ROWOFBLOCKS = 4;
        private const int COLUMNOFBLOCKS = 9;

        //fields, to store private data members
        private List<Block> blocks;
        private Graphics graphics;
        private Ball ball;
        private Size cilentSize;
        private Paddle paddle;
        private bool testGame;
        private bool blockDestroyed;

        //constructer, to assign initial value to field
        public Controller(Graphics graphics, Size cilentSize)
        {
            this.graphics = graphics;
            this.cilentSize = cilentSize;
            ball = new Ball(graphics, new Point(BEGINNINGBALLX, BEGINNINGBALLY), Color.White, new Point(BALLSPEEDX, BALLSPEEDY), cilentSize);
            paddle = new Paddle(graphics, new Point(PADDLEX, PADDLEY), Color.White);
            //create blocks
            Blocks = new List<Block>();
            for (int i = 0; i < COLUMNOFBLOCKS; i++)
            {
                for (int j = 1; j < ROWOFBLOCKS; j++)
                {
                    Blocks.Add(new Block(graphics, new Point(i * BLOCKBEGINX, j * BLOCKBEGINY), Color.Pink));
                }

            }
        }

        //draw blocks
        public void DrawBlocks()
        {
            foreach (Block block in Blocks)
            {
                block.Draw();
            }
        }

        //to run the ball,including run the ball, the ball hit the form, the block disapear when the ball hit the block
        public void Run()
        {
            ball.Draw();                      //draw the ball
            ball.BallBehavior();              //to make the ball move in the form
            ball.Move();                      //call move method, to make the ball move
            ball.BlockBomb(Blocks);           //call BlockBomb method, the block will disapear when the ball hit the blocks
            ball.PaddleControlBall(paddle);   //control the ball
            //create a bool value when the game is over, and restart the game
            if (ball.CheckGame == true)
            {
                testGame = true;
                ball.BallPosition = new Point(NEWBALLWIDTH, NEWBALLHEIGHT);
                ball.Speed = new Point(BALLSPEEDX, BALLSPEEDY);
                ball.CheckGame = false;
            }
            //create a value when the blocks are all gone
            if (blocks.Count == 0)
            {
                blockDestroyed = true;
            }
           
        }

        //to draw paddle X value to paddle
        public void DrawPaddle()
        {
            paddle.Draw();
        }

        //to move the paddle by passing the 
        public void MovePaddle(int mouseX)
        {
            paddle.Move(mouseX);
        }

        //properties, to pass value in different classes
        public List<Block> Blocks { get => blocks; set => blocks = value; }
        public bool TestGame { get => testGame; set => testGame = value; }
        public bool BlockDestroyed { get => blockDestroyed; set => blockDestroyed = value; }
    }
}
