using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Program
    {
        static void Main()
        {
            List<Card> listOfCards = Deck.CreateDeck();

            Random rng = new Random();
            Deck.Shuffle(listOfCards, rng);

            foreach (var card in listOfCards)
            {
                Console.WriteLine(card.value);
            }
            //Console.Clear();

            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();
            bool noWinner = true;
            int playerTotal = 0;
            int dealerTotal = 0;
            int round = 1;

            Console.WriteLine("Welcome to Blackjack! \n");
            Console.WriteLine("The rules are simple: try to get as close to 21 as possible without going over. ");
            Console.WriteLine("Each card represents its face value with the exception of jack, queen, and king which are all 10. \n");

            while (noWinner)
            {
                if (round == 1)
                {
                    Console.WriteLine("First round is being dealt...");
                    Thread.Sleep(2500);

                    playerHand.Add(Deck.DrawACard(listOfCards));
                    dealerHand.Add(Deck.DrawACard(listOfCards));
                    playerHand.Add(Deck.DrawACard(listOfCards));
                    dealerHand.Add(Deck.DrawACard(listOfCards));

                    playerTotal = playerHand[0].value + playerHand[1].value;
                    Console.WriteLine("Player Current Total: {0} ", playerTotal);

                    dealerTotal = dealerHand[0].value + dealerHand[1].value;
                    Console.WriteLine("Dealer Current Total: {0} ", dealerTotal);

                    if (playerTotal == 21)
                    {
                        Console.WriteLine("Sorry, you busted!");
                        noWinner = false;
                    }
                    else if (dealerTotal == 21)
                    {
                        Console.WriteLine("Dealer busted! You Win!");
                        noWinner = false;
                    }
                    else
                    {
                        round++;
                    }
                }
                else
                {
                    Console.WriteLine("Would you like to Hit or Stand?");
                    var input = Console.ReadLine();

                    if (input == "Hit")
                    {
                        playerHand.Add(Deck.DrawACard(listOfCards));
                        playerTotal += playerHand.Sum(x => x.value); 
                        Console.WriteLine("Player Current Total: {0} ", playerTotal);
                    }
                    else
                    {
                        Console.WriteLine("Player Current Total: {0} ", playerTotal);
                    }
                }
            }
        }
    }
}
