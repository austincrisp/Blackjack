using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckIsFull()
        {
            var listofCards = Deck.DealXCards(1);
            Assert.AreEqual(52, listofCards.Count);
        }
    }
}
