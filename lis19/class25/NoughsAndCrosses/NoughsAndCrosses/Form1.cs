using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughsAndCrosses
{
    public partial class Form1 : Form
    {
       
        private Graphics graphics;
        private Board board;

        private int wins;
        private int losses;
        //private Square square;
        public Form1()
        {
            InitializeComponent();
            panel1.Width = 330;
            panel1.Height = 330;

          

            graphics = panel1.CreateGraphics();
            board = new Board(graphics);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            board.SetUpNewGame();
        }

    
    }
}
