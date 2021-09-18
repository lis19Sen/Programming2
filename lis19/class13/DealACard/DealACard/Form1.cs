using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealACard
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            deck = new Deck(random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = deck.GetACard();
            pictureBox1.Image = card.Image;
            textBox1.Text = card.ToString().ToLower();
        }
    }
}
