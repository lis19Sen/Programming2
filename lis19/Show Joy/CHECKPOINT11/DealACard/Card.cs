using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealACard
{
   public class Card
    {
        private eRank rank;
        private eSuite suite;
        private Image image;

        public Card(eRank rank, eSuite suit)
        {
            this.rank = rank;
            this.suite = suit;
            Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(rank.ToString() + suit.ToString());
        }


        public override string ToString()
        {
            return(rank.ToString() + " of " + suite.ToString());
        }
        public Image Image { get => image; set => image = value; }

    }
}
