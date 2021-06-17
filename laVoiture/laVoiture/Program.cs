using ClassLibraryPourLaVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture cars = new Voiture();
            cars.Demarrer();
            cars.Avancer();
            cars.Arreter();
            cars.Avancer();
            cars.Arreter();
            cars.Eteindre();

        }
    }
}
