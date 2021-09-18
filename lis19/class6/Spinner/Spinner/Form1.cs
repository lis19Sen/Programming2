using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinner
{
    public partial class Form1 : Form
    {
        //constant
        private const int NUMBEROFSPINNERS = 3;
        private const int MONEYTOPLAY = 10;
        private const int WINMONEY = 50;
        //fields
        private Random random;
        //private List<Spinner> spiners;
        private Spinner[] spinner;
        
        private int mymoney;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            //spiners = new List<Spinner>();
            //cards.Add(new Card(pictureBox1, random));
            //spiners.Add(new Spinner(pictureBox1, random));
            spinner = new Spinner[NUMBEROFSPINNERS];
            spinner[0] = new Spinner(random, pictureBox1);
            spinner[1] = new Spinner(random, pictureBox2);
            spinner[2] = new Spinner(random, pictureBox3);

            mymoney = 100;
            textBoxmoney.Text = mymoney.ToString("C");

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (mymoney < MONEYTOPLAY)
            {
                MessageBox.Show("Sorry, you run out of money");
                Application.Exit();
            }
            else
            {
                mymoney = mymoney - MONEYTOPLAY;
                textBoxmoney.Text = mymoney.ToString("C");

                for (int i = 0; i < 3; i++)
                {
                    spinner[i].Spin();
                }

                if ((spinner[0].ImageNumber == spinner[1].ImageNumber) && (spinner[1].ImageNumber == spinner[2].ImageNumber))
                {
                    textBox1.Text = "Congratulations! You win!";
                    mymoney = mymoney + WINMONEY;
                    textBoxmoney.Text = mymoney.ToString("C");
                }
                else
                {
                    textBox1.Text = "You lose, keep going...";
                    // MessageBox.Show("You lose");
                }
            }
        }
    }
}
