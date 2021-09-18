
/* Program name: 	    Caculater
   Project file name:   Caculater
   Author:		        Sen Li
   Date:	            31/07/2018
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		        To create an caculator which has addition, substraction, 
   multiplication, division, mod methods
   Description:		    NONE
   Known Bugs:		    NONE
   Additional Features: NONE
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

namespace Caculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //addition
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int sum = num1 + num2;
            textBox3.Text = Convert.ToString(sum);
        }

        //subtraction
        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int num3 = num1 - num2;
            textBox3.Text = Convert.ToString(num3);
        }

        //multiplication
        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int num3 = num1 * num2;
            textBox3.Text = Convert.ToString(num3);
        }

        //division
        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("num2 can not be 0");
            }
            else
            {
                double num3 = (double)num1 / num2;
                textBox3.Text = Convert.ToString(Math.Round(num3, 2));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //DIV method
        private void button7_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            if (num2 == 0)
            {
                textBox3.Text = "num2 can not be 0";
            }
            else
            {
                int num3 = num1 / num2;
                textBox3.Text = Convert.ToString(num3);
            }
        }
        //MOD method
        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            

            if (num2 == 0)
            {
                MessageBox.Show("num2 can not be 0");
            }
            else
            {
                int num3 = num1 % num2;
                textBox3.Text = Convert.ToString(num3);
            }
          
        }
    }
}
