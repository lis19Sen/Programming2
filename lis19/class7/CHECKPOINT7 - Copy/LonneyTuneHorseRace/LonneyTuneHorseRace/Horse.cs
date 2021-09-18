using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LonneyTuneHorseRace
{
    public class Horse
    {
        //fields
        //private Image image;
        private Random random;
        private PictureBox pictureBox;
        private string horseName;


        //constructor
        public Horse(Random random, PictureBox pictureBox, string horseName)
        {
            this.random = random;
            this.PictureBox = pictureBox;
            this.HorseName = horseName;
        }

       

        //method
        public void run()
        {
            int x = random.Next(20,30);
            PictureBox.Left += x;
        }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public string HorseName { get => horseName; set => horseName = value; }
    }
}
