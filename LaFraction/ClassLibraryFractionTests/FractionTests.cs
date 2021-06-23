using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void EgalATest()
        {
            Fraction f = new Fraction(11, 7);
            Fraction f1 = new Fraction(22, 14);
            
            Assert.IsTrue(f.EgalA(f1));
        }
        [TestMethod()]
        public void SuperieurA()
        {
            Fraction f = new Fraction(11,7);
            Fraction f1 = new Fraction(5,4);

            Assert.IsTrue(f.SuperieurA(f1));
        }
    }
}