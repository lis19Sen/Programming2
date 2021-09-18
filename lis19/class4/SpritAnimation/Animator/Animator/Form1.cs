/*
 * The Animator class it used to load and display images on after the other
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Animator
{
    public partial class Form1 : Form
    {
        // field, Contain s a decalaration of the animator object of type Animator
        private Animator animator;
        private Animator animator2;

        //consturctor, a reference to pictureBox1 that sits on the Form1 is
        //passed into the Animator class where the images are loaded
        public Form1()
        {
            InitializeComponent();
            animator = new Animator(pictureBox1);
            animator2 = new Animator(pictureBox2);
        }

        // enent, tells the animator object to call its loadImages() method
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.T0;
            animator.LoadImages();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animator2.LoadImages();
        }

       
    }
}
