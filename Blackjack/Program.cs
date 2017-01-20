using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Program
    {
        /*
        public static bool Round()
        {

        }
        */

        static void Main()
        {
            List<Card> listOfCards = Deck.CreateDeck();
            Deck.Shuffle(listOfCards);

            foreach (var card in listOfCards)
            {
                Console.WriteLine(card.value);
            }
        }
    }
}
