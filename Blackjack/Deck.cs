using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        private static void CreateDeck(List<Card> cardList)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card());
                }
            }
        }

        public static List<Card> DealXCards(int count)
        {
            var cardList = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                CreateDeck(cardList);
            }

            return cardList;
        }
    }
}
