using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _99bottles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int nEnter = Convert.ToInt16(textBox1.Text);
            if ((nEnter > 0) && (nEnter < 100))
            {
                for (int i = 0; i < nEnter; i++)
                {
                    listBox1.Items.Add((99 - i) + "bottles of beer on the wall");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                
            }
            else
            {
                MessageBox.Show("Please choose a number between 0 and 99");
            }
        }
    }
}
