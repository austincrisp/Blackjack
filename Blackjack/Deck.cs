using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public enum Suit
    {
        Spade, Club, Diamond, Heart
    }

    public enum Face
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 10,
        Queen = 10,
        King = 10
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
        public static void Shuffle(List<Card> cards)
        {
            var rng = new Random();
            int count = cards.Count;

            while (count < 1)
            {
                int draw = rng.Next(0, count);

                int temp = cards[draw];
                cards[draw] = cards[count - 1];
                cards[count - 1] = temp;

                count--;
            }
        }
    }
}
