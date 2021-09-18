using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DealACard
{
    public class Card
    {
        //fields, also called private data members
        private int rank;
        private int suit;
        private PictureBox pictureBox;
        private Random random;
        private Image image;


        //constructor, has the same name with class,
        //used to asign initial values to field
        public Card(PictureBox pictureBox, Random random)
        {
            this.pictureBox = pictureBox;
            this.random = random;
            //ChooseACard();
            //WriteToLabel();
        }

        public void ChooseACard()
        {
            rank = random.Next(13);
            suit = random.Next(4);

            String suitString = "";
            switch (suit)
            {
                case 0:
                    suitString = "H";
                    break;
                case 1:
                    suitString = "S";
                    break;
                case 2:
                    suitString = "D";
                    break;
                case 3:
                    suitString = "C";
                    break;
            }

            image = (Bitmap)Properties.Resources.ResourceManager.GetObject(suitString + (rank + 1).ToString());

        }

        //methods, user declare
        public void LoadPictureBox()
        {
            pictureBox.Image = image;
        }

        //method, write to label
        public string WriteToLabel()
        {
            

            String suitString = "";
            switch (suit)
            {
                case 0:
                    suitString = "Hearts";
                    break;
                case 1:
                    suitString = "Spades";
                    break;
                case 2:
                    suitString = "Diamonds";
                    break;
                case 3:
                    suitString = "Clubs";
                    break;
            }


            String rankString = "";
            switch (rank)
            {
                case 0:
                    rankString = "Ace";
                        break;
                case 10:
                    rankString = "Jack";
                    break;
                case 11:
                    rankString = "Queen";
                    break;
                case 12:
                    rankString = "King";
                    break;
                default:
                    rankString = (rank + 1).ToString();
                    break;
            }

            return ( rankString + " of " + suitString);
        }

    }
}
