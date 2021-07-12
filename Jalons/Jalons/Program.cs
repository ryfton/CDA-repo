using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalons
{
    class Program
    {
        static void Main(string[] args)
        {   
            int temp;
            int compar=0;
            int nbSaisie=0;
            int saisie;
            

            while (nbSaisie<500 )
            {
                Console.WriteLine("veuilliez saisir un nombre");
                saisie = int.Parse(Console.ReadLine());
                if (compar>saisie)
                {
                    Console.WriteLine("veuillez saisir un nombre superieur à votre derniere saisie");
                }
                else
                {
                    nbSaisie += saisie;

                }
                

                
                temp = saisie;
                compar = temp;

                
            }
            Console.WriteLine(nbSaisie);
            Console.ReadKey();
            

        }
    }
}
