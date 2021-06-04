using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeBouteille;

namespace UnitTestBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Bouteille_Method_Ouvrir_RetourneTrue()
        {
            // variable.
            Bouteille maBouteille = new Bouteille(0,0,false);
            Assert.IsTrue(maBouteille.Ouvrir());
            
        }
        [TestMethod]
        public void Test_Bouteille_MethodFermer_RetourneTrue()
        {
            // vatiable.
            Bouteille maBouteille = new Bouteille(0, 0, true);
            Assert.IsTrue(maBouteille.Fermer());

            //Assert.ThrowsException<Exception>(() => maBouteille.Fermer());
        }
        [TestMethod]
        public void Test_Bouteille_MethodRemplir_RetourneTrue()
        {
            decimal _aRajouterEnPourcentage=25;
            Bouteille maBouteille = new Bouteille(4, 50, true);

            Assert.IsTrue(maBouteille.Remplir(_aRajouterEnPourcentage));
        }
        [TestMethod]
        public void Test_Bouteille_MethodRemplir_SiBouteillePleine_RetourneFalse()
        {
            decimal _aRajouterEnPourcentage = 25;
            Bouteille maBouteille = new Bouteille(4, 100, true);

            Assert.IsFalse(maBouteille.Remplir(_aRajouterEnPourcentage));
        }
        [TestMethod]
        public void Test_Bouteille_MethodRemplir_SiAjoutDepasseContenace_RetourneFalse()
        {
            decimal _aRajouterEnPourcentage = 25;
            Bouteille maBouteille = new Bouteille(4, 80, true);

            Assert.IsFalse(maBouteille.Remplir(_aRajouterEnPourcentage));
        }


    }
   
}
