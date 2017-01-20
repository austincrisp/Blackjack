using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardValuesAreInitializedCorrectly()
        {
            var sut = new Card();
            Assert.AreEqual(0, sut.GetValue());
        }
    }
}
