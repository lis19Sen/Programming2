

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteAnimation
{
    public class Animator
    {
        //fields, also called private data members
        private Image[] images = new Image[11];
        private PictureBox pictureBox;

        //constructor, has the same name name with class,
        //used to asign initial values to fields
        public Animator(PictureBox pictureBox)
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject("T" + i.ToString());
            }
            this.pictureBox = pictureBox; 
        }

        //method, personal declear
        public void loadImage()
        {
            for (int i = 0; i < images.Length; i++)
            {
                pictureBox.Image = images[i];
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
            
        }

    }
}
