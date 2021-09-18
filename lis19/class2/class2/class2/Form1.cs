using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
       

    

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            textBox1.AppendText("This is new text.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("This is line number" + (listBox1.Items.Count + 1));
        }

       
    }
}
