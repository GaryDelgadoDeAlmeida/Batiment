using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Batiment;

namespace TestUnitaireBatiment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAdressObjectBatimentWithoutParam()
        {
            Batiment b = new Batiment();
            Assert.AreEqual("????", b.getAdresse());
        }

        [TestMethod]
        public void TestSetAdresseBatimentObject()
        {
            Batiment b = new Batiment();
            b.setAdresse("189 Boulevard Géant-Vert");
            Assert.AreEqual("189 Boulevard Géant-Vert", b.getAdresse());
        }

        [TestMethod]
        public void TestGetAdressObjectBatimentWithParam()
        {
            Batiment b = new Batiment("207 Bouleavard Saint-Michel");
            Assert.AreEqual("207 Bouleavard Saint-Michel", b.getAdresse());
        }
    }
}
