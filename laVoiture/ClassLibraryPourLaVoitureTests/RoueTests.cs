using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPourLaVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPourLaVoiture.Tests
{
    [TestClass()]
    public class RoueTests
    {
        [TestMethod()]
        public void ConstructeurParDefaut_Voiture_NbCV()
        {
            Voiture cars = new Voiture();
            Assert.AreEqual(cars.SonMoteur.NbCV,4);


        }
        [TestMethod()]
        public void ConstructeurParDefaut_Voiture_Kilometrage()
        {
            Voiture cars = new Voiture();
            Assert.AreEqual(cars.CompteurEnKM,0);


        }
        [TestMethod()]
        public void ConstructeurParDefaut_Voiture_NbRoue()
        {
            Voiture cars = new Voiture();
            Assert.AreEqual(cars.MesRoues.Count, 4);


        }
        [TestMethod()]
        public void TesteMoteur_VoitureDemarer()
        {
            Voiture cars = new Voiture();
            if (cars.Demarrer())
            {
                Assert.AreEqual(cars.SonMoteur.EstDemarre, true);
            }
            
            

        }
    }
}