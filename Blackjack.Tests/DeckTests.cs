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
            var sut = Deck.CreateDeck();
            Assert.AreEqual(52, sut.Count);
        }

        [TestMethod]
        public void DeckValuesAreSet()
        {
            var sut = Deck.CreateDeck();
            Assert.AreEqual(2, sut[2].GetValue());
        }

        [TestMethod]
        public void CardCanBeCreatedWithArgs()
        {
            var sut = new Card(Suit.Spades, Face.Eight);
            Assert.AreEqual(8, sut.GetValue());
        }
    }
}
