using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
   public class Horse
    {
        //constant
        private const int SPEED = 10;
        //fields
        private Random random;
        private PictureBox pictureBox;
        private string horseName;
        private int speed;

        //consturctor
        public Horse(Random random, PictureBox pictureBox, string horseName)
        {
            this.random = random;
            this.PictureBox = pictureBox;
            this.HorseName = horseName;
            speed = SPEED;
        }

       

        public void Move()
        {
            PictureBox.Left += random.Next(speed);

        }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public string HorseName { get => horseName; set => horseName = value; }
    }
}
