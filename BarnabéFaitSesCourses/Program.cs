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
            int nombreDeMagasin=1;
            
            
            Console.WriteLine("veuillez saisir le solde du portfeuille de barnabé");
            solde = int.Parse(Console.ReadLine());

            nvSolde = DépenseDuSolde(solde);
            while (nvSolde> 2) 
            {
                 nvSolde= DépenseDuSolde(nvSolde);
                

                nombreDeMagasin++;
                if (nvSolde < 2)
                {
                    nvSolde = 0;
                    nombreDeMagasin++;

                }


                Console.WriteLine("En sortant du magasin n°:"+nombreDeMagasin+" il reste " + nvSolde+ " euros à Barnabé");
            }
        

            Console.WriteLine("Barnabé n'a plus assez pour pour continuer ces course, il lui reste " + nvSolde+" et il a pus faire "+nombreDeMagasin+" magasin");

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
