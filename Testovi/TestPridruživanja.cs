using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestPridruživanja : ConsoleTest
    {
        [TestMethod]
        public void Pridruživanje_PridruživanjeStrukturaRadiDubokuKopiju()
        {
            Pridruživanje.PridruživanjeStruktura(1, 5);
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
        }

        [TestMethod]
        public void Pridruživanje_PridruživanjeKlasaRadiPlitkuKopiju()
        {
            Pridruživanje.PridruživanjeKlasa(1, 5);
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
        }
    }
}
