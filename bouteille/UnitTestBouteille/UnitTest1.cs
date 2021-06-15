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
            
            Bouteille maBouteille = new Bouteille(0,0,false);
            Assert.IsTrue(maBouteille.Ouvrir());
            
        }
        [TestMethod]
        public void Test_Bouteille_MethodFermer_RetourneTrue()
        {
            
            Bouteille maBouteille = new Bouteille(0, 0, true);
            Assert.IsTrue(maBouteille.Fermer());
            Assert.AreEqual(true, maBouteille.Ouvrir());

            //Assert.ThrowsException<Exception>(() => maBouteille.Fermer());
        }
        [TestMethod]
        // Les Teste pour la methodes Remplir 
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
        [TestMethod]
        public void Test_Bouteille_MethodRemplir_BouteilleFermer_RetourneFalse()
        {
            
            Bouteille maBouteille = new Bouteille(4, 80,false);

            Assert.IsFalse(maBouteille.Remplir(20));
        }
        // Les Teste pour la methodes Vider 
        [TestMethod]
        public void Test_Bouteille_MethodVider_LaBonneQuantiter_RetourneTrue()
        {
            decimal _contenuEnPourcentage = 80;
            Bouteille maBouteille = new Bouteille(4, _contenuEnPourcentage, true);
            decimal _aOterEnPourcentage = 20;
            
            
             Assert.IsTrue(maBouteille.Vider(_aOterEnPourcentage));// la meme chose  }
             Assert.AreEqual(true, maBouteille.Vider(_aOterEnPourcentage));// la meme chose}


        }
        [TestMethod]
        public void Test_Bouteille_MethodVider_Fermer_Retournefalse()
        {
            
            Bouteille maBouteille = new Bouteille(4, 80, false);
            


            Assert.IsFalse(maBouteille.Vider(20));// la meme chose  }
            Assert.AreEqual(false, maBouteille.Vider(20));// la meme chose}


        }
        [TestMethod]
        public void Test_Bouteille_MethodViderTout_RetourneTrue()
        {
            
            Bouteille maBouteille = new Bouteille(4, 80, true);
            Assert.AreEqual(true, maBouteille.ViderTout());//ou
           // Assert.IsTrue(maBouteille.ViderTout());

        }
        [TestMethod]
        public void Test_Bouteille_MethodViderTout_BouteilleFermer_RetourneFalse()
        {
            
            Bouteille maBouteille = new Bouteille(4, 80, false);
            
            Assert.IsFalse(maBouteille.ViderTout());

        }


    }
   
}
