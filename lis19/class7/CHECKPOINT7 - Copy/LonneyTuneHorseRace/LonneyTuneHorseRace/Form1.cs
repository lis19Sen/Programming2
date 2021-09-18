using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LonneyTuneHorseRace
{
    public partial class Form1 : Form
    {
        //constant
        private const int NUMBEROFHORSE = 4;
        //field
        //private Horse horse1;
        //private Horse horse2;
        //private Horse horse3;
        //private Horse horse4;
        private Horse[] horses;
        private Random random;


        public Form1()
        {
            InitializeComponent();
            random = new Random();
            horses = new Horse[NUMBEROFHORSE];
            //horse1 = new Horse(random, pictureBox1,"daffy");
            //horse2 = new Horse(random, pictureBox2, pictureBox2.Name);
            //horse3 = new Horse(random, pictureBox3, pictureBox3.Name);
            //horse4 = new Horse(random, pictureBox4, pictureBox4.Name);
            horses[0] = new Horse(random, pictureBox1, "daffy");
            horses[1] = new Horse(random, pictureBox2, "pepe");
            horses[2] = new Horse(random, pictureBox3, "taz");
            horses[3] = new Horse(random, pictureBox4, "willy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < horses.Length; i++)
            {
                horses[i].PictureBox.Left = 100;
            }
            timer1.Enabled = true;
          
        }

        //check winner
        //public string CheckWinner()
        //{
           
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            //horse1.run();
            //horse2.run();
            //horse3.run();
            //horse4.run();
            //if (horse1.PictureBox.Left > panel1.Left)
            //{
            //    timer1.Enabled = false;
            //    MessageBox.Show(panel1.Left.ToString());

            //}
            for (int i = 0; i < horses.Length; i++)
            {
                
                horses[i].run();
                if (horses[i].PictureBox.Right > panel1.Left)
                {
                    timer1.Enabled = false;
                    MessageBox.Show(horses[i].HorseName + " win");
                    break;
                }
                
                
            }
           

        }
    }
}
