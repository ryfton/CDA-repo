using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnabéFaitSesCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            double solde;
            double nvSolde=0;
            int nombreDeMagasin=0;
            int nombreMag;

            Console.WriteLine("veuillez saisir le solde du portfeuille de barnabé");
            solde = int.Parse(Console.ReadLine());

            nvSolde = DépenseDuSolde(solde);
            while (nvSolde> 2) 
            {
                 nvSolde= DépenseDuSolde(nvSolde);

                nombreDeMagasin++;

            Console.WriteLine("il reste " + nvSolde+ " à Barnabé");
            }
            if (nvSolde>0)
            {
                nvSolde = 0;
            }


            Console.WriteLine("Barnabé n'a plus assez pour pour continuer ces course, il lui reste " + nvSolde+" et il a pus faire "+nombreDeMagasin);

            Console.ReadKey();

        }
        static double DépenseDuSolde(double _solde)
        {
            int diviseur = 2;
            int plus = 1;
            
            double nouveauSolde;


            nouveauSolde = (_solde / diviseur )- plus;
            return nouveauSolde;
            
            

        }
    }
}
