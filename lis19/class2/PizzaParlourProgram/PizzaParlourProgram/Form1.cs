using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlourProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //let button click to do something
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double TotalCost = 0;

            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Small Pizza with:");
                TotalCost = TotalCost + 5.00;
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("Large Pizza with:");
                TotalCost = TotalCost + 10.00;
            }
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Anchovies");
                TotalCost = TotalCost + 0.50;
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Extra cheese");
                TotalCost = TotalCost + 1.00;
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add("Olives");
                TotalCost = TotalCost + 0.75;
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add("Mashroom");
                TotalCost = TotalCost + 0.50;
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add("Pepperoni");
                TotalCost = TotalCost + 1.50;
            }
            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add("Egg");
                TotalCost = TotalCost + 1.50;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please select Small or Large pizza");
            }
            textBox1.Text = "$" + Convert.ToString(TotalCost);
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    listBox1.Items.Remove("Anchovies");
        //}
    }
}
