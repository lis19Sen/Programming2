using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Responding_to_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "My text has changed";
            int nClicks = Convert.ToInt16(textBox1.Text);
            nClicks = nClicks + 1;
            textBox1.Text = Convert.ToString(nClicks);
            label1.Text = textBox1.Text;

        }
    }
}
