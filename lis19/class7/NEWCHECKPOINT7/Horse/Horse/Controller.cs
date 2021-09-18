using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
    public class Controller
    {
        //Constant
        private const int ARRAYLENGTH = 4;
        private const int HORSESTARTLOCATION = 100;

        //Fields
        private Horse[] horses;
        //private int finishLine;
        private bool isOver;
        private Random random;
        private string winner;

     
        public Controller(Random random, PictureBox[] pictureBox)
        {
            horses = new Horse[ARRAYLENGTH];
            horses[0] = new Horse(random, pictureBox[0], "Daffy");
            horses[1] = new Horse(random, pictureBox[1], "Pepe");
            horses[2] = new Horse(random, pictureBox[2], "Taz");
            horses[3] = new Horse(random, pictureBox[3], "Wiley");
            this.random = random;
            //this.finishLine = finishiLine;
        }
        public void Restart()
        {
            for (int i = 0; i < horses.Length; i++)
            {
                horses[i].PictureBox.Left = HORSESTARTLOCATION;
            }
        }
        public void Race()
        {
            for (int i = 0; i < horses.Length; i++)
            {
                horses[i].Move();
            }
        }
        public void CheckWinner(int finishline)
        {
            IsOver = false;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].PictureBox.Right >= finishline)
                {
                    IsOver = true;
                    Winner = horses[i].HorseName;
                }
            }
        }
        //properties
        public bool IsOver { get => isOver; set => isOver = value; }
        public string Winner { get => winner; set => winner = value; }


    }
}
