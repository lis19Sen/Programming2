using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Graphics graphics;
        private BlockController blockController;
        private BallController ballController;
        private PaddleControllor paddleControllor;



        public Form1()
        {
            InitializeComponent();
            
            
            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            graphics = CreateGraphics();
            blockController = new BlockController(bufferGraphics);
            ballController = new BallController(bufferGraphics,new Size(ClientSize.Width, ClientSize.Height));
            paddleControllor = new PaddleControllor(bufferGraphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            blockController.DrawBlocks();
            ballController.Run();
            paddleControllor.DrawPaddle();
           
            graphics.DrawImage(bufferImage, 0, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            paddleControllor.MovePaddle(e.Location.X);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
