using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Batiment;

namespace TestUnitaireBatiment
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Test la propriété getAdresse qui par défault
        /// n'est pas déclarer dans les paramètres de 
        /// créarion de l'objet Maison
        /// </summary>
        [TestMethod]
        public void TestGetAdresseMaisonObjectWithoutParam()
        {
            Maison m = new Maison();
            Assert.AreEqual("????", m.getAdresse());
        }

        /// <summary>
        /// Test la propriété getNbPieces qui par défault
        /// n'est pas déclarer dans les paramètres de 
        /// créarion de l'objet Maison
        /// </summary>
        [TestMethod]
        public void TestGetNbPiecesMaisonObjectWithoutParam()
        {
            Maison m = new Maison();
            Assert.AreEqual(0, m.getNbPieces());
        }

        /// <summary>
        /// Test la propriété getAdresse qui par défault
        /// est déclarer dans les paramètres de créarion
        /// de l'objet Maison
        /// </summary>
        [TestMethod]
        public void TestGetAdresseMaisonObjectWithParam()
        {
            Maison m = new Maison("150 rue Vincent Rouvier", 4);
            Assert.AreEqual("150 rue Vincent Rouvier", m.getAdresse());
        }

        /// <summary>
        /// Test la propriété getNbPieces qui par défault
        /// est déclarer dans les paramètres de créarion
        /// de l'objet Maison
        /// </summary>
        [TestMethod]
        public void TestGetNbPiecesMaisonObjectWithParam()
        {
            Maison m = new Maison("150 rue Vincent Rouvier", 4);
            Assert.AreEqual(4, m.getNbPieces());
        }

        /// <summary>
        /// Test la propriété setAdresse indépendemment
        /// de la façon dont l'objet Maison a été déclarer
        /// </summary>
        [TestMethod]
        public void TestSetAdresseMaisonObject()
        {
            Maison m = new Maison();
            m.setAdresse("150 rue Vincent Rouvier");
            Assert.AreEqual("150 rue Vincent Rouvier", m.getAdresse());
        }

        /// <summary>
        /// Test la propriété setNbPieces
        /// </summary>
        [TestMethod]
        public void TestSetNbPiecesMaisonObject()
        {
            Maison m = new Maison();
            m.setNbPieces(5);
            Assert.AreEqual(5, m.getNbPieces());
        }
    }
}
