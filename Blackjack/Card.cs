using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public enum Suit
        {
            Spade, Club, Diamond, Heart
        }

        public enum Face
        {
            Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        }

        public int value;

        public Card() {  }

        public int GetValue()
        {
            return value;
        }
    }
}
