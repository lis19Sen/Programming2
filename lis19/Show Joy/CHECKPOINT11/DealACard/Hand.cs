using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealACard
{
    public class Hand
    {
        //const
        private const int AHANDCARDS = 5;

        //fields
        private Deck deck;
        private List<Card> handCards;

        public Hand(Deck deck)
        {
            this.deck = deck;
            HandCards = new List<Card>();
        }

       

        public void DealAHand()
        {
            HandCards.Clear();
            for (int i = 0; i < 5; i++)
            {
                HandCards.Add(deck.GetACard());

            }
        }

        public List<Card> HandCards { get => handCards; set => handCards = value; }
    }
}
