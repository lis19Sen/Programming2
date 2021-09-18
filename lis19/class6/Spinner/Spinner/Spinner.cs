using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Spinner
{
    public class Spinner
    {
        //constant number of images
        private const int NUMBEROFIMAGES = 3;
        private const int TIMESTOSPIN = 20;
        private const int SLEEP = 20;

        //fields, used for private data members
        private Image[] image;
        private Random random;
        private PictureBox pictureBox;
        private int imageNumber;
       

        //constructor
        public Spinner( Random random, PictureBox pictureBox)//order of agument
        {
            this.pictureBox = pictureBox;
            this.random = random;
            image = new Image[NUMBEROFIMAGES];
            image[0] = (Bitmap)Properties.Resources.coyote;
            image[1] = (Bitmap)Properties.Resources.sheep;
            image[2] = (Bitmap)Properties.Resources.tree;
        }

      

        //methods
        public void Spin()
        {
            for (int i = 0; i < TIMESTOSPIN; i++)
            {
                imageNumber = random.Next(NUMBEROFIMAGES);
                pictureBox.Image = image[imageNumber];
                Application.DoEvents();
                Thread.Sleep(SLEEP);
            }
        }
        public int ImageNumber { get => imageNumber; set => imageNumber = value; }
    }
}
