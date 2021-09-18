using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DealACard
{
    //Deck class to store the images
    public class Deck
    {
        private const int RANKS = 13;
        private const int SUITS = 4;
        private const int CARDS = 52;
        //fields, also called private data field
        private List<Card> cards;
        private Random random;

        public Deck(Random random)
        {
            cards = new List<Card>();
            for (int i = 0; i < RANKS; i++)
            {
                for (int j = 0; j < SUITS; j++)
                {
                    cards.Add(new Card((eRank)i, (eSuite)j));
                }
            }
            this.random = random;
        }
        public Card GetACard()
        {
            int cardNumber = random.Next(CARDS);
            return cards[cardNumber];
        }
    }
}
