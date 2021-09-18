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
        private const int TIMESTOTHROW = 5;

        //fields.
        Coin coin;
        Random random;
        public Form1()
        {
            
            InitializeComponent();
            random = new Random();
            coin = new Coin(random); //to use the initial value defined in constructor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coin.HeadCount = 0;
            coin.TailCount = 0;
            listBox1.Items.Clear();
            
            for (int i = 0; i < TIMESTOTHROW; i++)
            {
                listBox1.Items.Add(coin.Throw());// to use method
                //MessageBox.Show(coin.Throw());
            }
            MessageBox.Show("Heads " + coin.HeadCount.ToString() + " times");//to use the value in properties
            MessageBox.Show("Tails " + coin.TailCount.ToString() + " times");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
