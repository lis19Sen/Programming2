using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTweety
{
    public partial class Form1 : Form
    {
        private Random random;
        private Graphics graphics;
        private Board board;

        private int wins;
        private int losses;
        public Form1()
        {
            InitializeComponent();
            panel1.Width = 600;
            panel1.Height = 300;

            wins = 0;
            losses = 0;

            textBox1.Text = Convert.ToString(wins);
            textBox2.Text = Convert.ToString(losses);

            graphics = panel1.CreateGraphics();
            board = new Board(graphics);
        }

        private void SetUpNewGame()
        {
            panel1.Enabled = true;
            board.SetUpNewGame();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetUpNewGame();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            eType result = board.PlayThisSquare(e.Location);
              
        }
    }
}
