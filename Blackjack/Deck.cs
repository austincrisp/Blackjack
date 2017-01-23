using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public enum Suit
    {
        Spades, Clubs, Diamonds, Hearts
    }

    public enum Face
    {
        Ace   = 1,
        Two   = 2,
        Three = 3,
        Four  = 4,
        Five  = 5,
        Six   = 6,
        Seven = 7,
        Eight = 8,
        Nine  = 9,
        Ten   = 10,
        Jack  = 10,
        Queen = 10,
        King  = 10
    }

    public class Deck
    {
        public static List<Card> CreateDeck()
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card((Suit)i,(Face)j));
                    
                    if (j <= 8)
                    {
                        cards[cards.Count - 1].value = j + 1;
                    }
                    else
                    {
                        cards[cards.Count - 1].value = 10;
                    }
                }
            }

            return cards;
        }

        
        // Using Fisher-Yates method for shuffling (not mine)
        public static void Shuffle(List<Card> cards, Random random)
        {
            for (var i = 0; i < cards.Count; i++)
            {
                var temp = cards[i];
                var index = random.Next(0, cards.Count);
                cards[i] = cards[index];
                cards[index] = temp;
            }
        }

        public static Card DrawACard(List<Card> cards)
        {
            Card draw = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return draw;
        }
        
    }
}
