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
        //private Card card;
        //private Card card1;
        //private Card card2;
        //private Card card3;
        //private Card card4;
        private Random random;
        private List<Card> cards;
        private List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            //card = new Card(pictureBox1, random);
            //card1 = new Card(pictureBox3, random);
            //card2 = new Card(pictureBox4, random);
            //card3 = new Card(pictureBox5, random);
            //card4 = new Card(pictureBox6, random);
            cards = new List<Card>();
            cards.Add(new Card(pictureBox1, random));
            cards.Add(new Card(pictureBox3, random));
            cards.Add(new Card(pictureBox4, random));
            cards.Add(new Card(pictureBox5, random));
            cards.Add(new Card(pictureBox6, random));

            labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Card card in cards)
            {
                card.ChooseACard();
                card.LoadPictureBox();

            }
          
           
           // card.ChooseACard();
           // card.LoadPictureBox();
           //// card.WriteToLabel();
           // label1.Text = card.WriteToLabel();

           // card1.ChooseACard();
           // card1.LoadPictureBox();
           // // card.WriteToLabel();
           // label2.Text = card.WriteToLabel();

           // card2.ChooseACard();
           // card2.LoadPictureBox();
           // // card.WriteToLabel();
           // label3.Text = card.WriteToLabel();

           // card3.ChooseACard();
           // card3.LoadPictureBox();
           // // card.WriteToLabel();
           // label4.Text = card.WriteToLabel();

           // card4.ChooseACard();
           // card4.LoadPictureBox();
           // // card.WriteToLabel();
           // label5.Text = card.WriteToLabel();
        }
    }
}
