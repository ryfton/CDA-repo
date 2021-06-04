using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBouteille
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal contenance=5;
            decimal contenu=0;
            bool ouvert=true;
            decimal arajouter=10;
            
            Bouteille perrierBouteille;
            perrierBouteille = new Bouteille(contenance,contenu,ouvert);
            perrierBouteille.Ouvrir();
            perrierBouteille.Remplir(arajouter);
            perrierBouteille.Vider(5);
            perrierBouteille.Remplir(80);
            Console.WriteLine( perrierBouteille.ToString());

            Console.ReadKey();
        }
    }
}
