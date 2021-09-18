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
        private Card card;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            card = new Card(pictureBox1, random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card.ChooseACard();
            card.LoadPictureBox();
           // card.WriteToLabel();
            label1.Text = card.WriteToLabel();
        }
    }
}
