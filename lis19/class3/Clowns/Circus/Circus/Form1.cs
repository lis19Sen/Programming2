/* Program name: 	    ClownProject
   Project file name:   Clown
   Author:		        Sen Li
   Date:	            14/08/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To creat a Clown project to let the clown talk about itself.
   Description:		    <<A detailed description of what the program does>>
   Known Bugs:		    <<Must be commented out, your program MUST compile>>
   Additional Features:
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Circus
{
    public partial class Form1 : Form
    {
        //to creat clown array
        private Clown[] clown = new Clown[4];
           
        //private Clown clown1;
        //private Clown clown2;
        //private Clown clown3;
        public Form1()
        {
            InitializeComponent();
            
            clown[0] = new Clown("Crusty", 165, 31, 1);
            clown[1] = new Clown("Charlie", 175, 55, 2);
            clown[2] = new Clown("Clary", 200, 12, 3);
            clown[3] = new Clown("Sam", 1000, 32, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(clown1.TalkAboutYourself());
            //MessageBox.Show(clown2.TalkAboutYourself());
            //MessageBox.Show(clown3.TalkAboutYourself());
            Random rand = new Random();
            int ClownReady = rand.Next(clown.Length);
            //ramdomly show picture by clicking button, learned from 
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/71610c1f-f362-4418-a8ba-24961316cacf/change-a-picturebox-to-a-random-picture-everytime-you-press-a-button?forum=csharpgeneral
            string[] paths = Directory.GetFiles(@"H:\programming 2\lis19\class3\Clowns\Circus\Circus\Resources", "*.jpg");
            List<string> images = paths.ToList();
            pictureBox1.ImageLocation = paths[ClownReady];
            MessageBox.Show(clown[ClownReady].TalkAboutYourself());

        }
    }
}
