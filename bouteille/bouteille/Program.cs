using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal contenace;
            decimal contenu;
            bool ouvert;
            decimal arajouter=10;
            Bouteille perrierBouteille;
            perrierBouteille = new Bouteille();
            perrierBouteille.Ouvrir();
            perrierBouteille.Remplir(arajouter);


        }
    }
}
