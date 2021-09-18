using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsAndTails
{
    public partial class Form1 : Form
    {
        //constant
        private const int TIMETHROW = 5;

        //fields, also called private data members
        Coin coin;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            coin = new Coin(random);//initial value
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < TIMETHROW; i++)
            {
                listBox1.Items.Add(coin.Throw());
            }
            MessageBox.Show(coin.HeadCount.ToString());
            MessageBox.Show(coin.TailCount.ToString());
        }
    }
}
