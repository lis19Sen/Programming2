using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace RoboTracker
{
    public class Robot
    {
        //constant
        private const int SLEEP_TIME = 50;
        //fields
        private PictureBox pictureBox;

        //consturctor
        public Robot(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        //method
        public void MoveRobot(Path path)
        {
            foreach (Point point in path.Points)
            {
                pictureBox.Left = point.X - pictureBox.Width/2;
                pictureBox.Top = point.Y - pictureBox.Height/2;
                Thread.Sleep(SLEEP_TIME);
            }

        }
    }
}
