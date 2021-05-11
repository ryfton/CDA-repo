using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NombrePremier;

namespace UnitTestEstPremier
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            uint nombreTest=0;

            bool resultat = true;

            resultat = Program.EstNombrePremier(nombreTest);
            Assert.IsFalse(resultat);

        }
        [TestMethod]
        public void TestMethod2()
        {
            uint nombreTest = 5;

            bool resultat = true;

            resultat = Program.EstNombrePremier(nombreTest);
            Assert.IsTrue(resultat);

        }
        [TestMethod]
        public void TestMethod3()
        {
            uint nombreTest = 1;

            bool resultat = true;

            resultat = Program.EstNombrePremier(nombreTest);
            Assert.IsFalse(resultat);

        }

    }
}
