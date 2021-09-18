/*
 * The Animator class it used to load and display images on after the other
 * */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Animator
{
    public class Animator
    {
        //constants, to set the size of the array and the length of dalay
        private const int NIMAGES = 11;
        private const int SLEEPINTERVAL = 100;

        //
        private Image[] images;
        private PictureBox pictureBox;

        // constructor
        public Animator(PictureBox pictureBox)
        {
            //images = new Image[11]; has the same meaning with down sentence
            images = new Image[NIMAGES];
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject("T" + i.ToString());
               
            }
            this.pictureBox = pictureBox;
        }

        //mtheod ,to load the pictures
        public void LoadImages()
        {
            for (int i = 0; i < images.Length; i++)
            {
                pictureBox.Image = images[i];
                Application.DoEvents();
                Thread.Sleep(SLEEPINTERVAL);
            }
           
            
        }

    }
}
