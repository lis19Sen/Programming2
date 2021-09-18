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
        //constant
        private const int NCARDS = 5;

        //fields
        private Hand hand;
        private Deck deck;
        private Random random;
        private List<PictureBox> pictureBoxes;
        private List<TextBox> textBoxes;
        public Form1()
        {
            InitializeComponent();

            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);

            textBoxes = new List<TextBox>();
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);

            random = new Random();
            deck = new Deck(random);
            hand = new Hand(deck);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hand.DealAHand();
            for (int i = 0; i < NCARDS; i++)
            {
                pictureBoxes[i].Image = hand.HandCards[i].Image;
                textBoxes[i].Text = hand.HandCards[i].ToString();

            }
            //pictureBox1.Image = card.Image;
            //textBox1.Text = card.ToString().ToLower();
        }
    }
}
