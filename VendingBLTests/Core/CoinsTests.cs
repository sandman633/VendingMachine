using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingBL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBL.Core.Tests
{
    [TestClass()]
    public class CoinsTests
    {
        [TestMethod()]
        public void CoinsTest()
        {
            Coins coins = new Coins();
            Coin coin = coins.Find(5);
            coins.Add(5);
            Assert.AreEqual(11, coin.Count);
        }

    }
}