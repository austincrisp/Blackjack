using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public int value;
        public Suit suit;
        public Face face;

        public Card() { }

        public Card(Suit _suit, Face _face)
        {
            suit = _suit;
            face = _face;
        }

        public int GetValue()
        {
            return (int)face;
        }
    }
}