using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mybutton1.Width = 400;
            //label1.Visible = false;
            //textBox1.Text = "Go Otago";
            mybutton1.Text = label1.Text;
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Here is my new text";

        }
    }
}
