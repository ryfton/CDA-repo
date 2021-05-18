using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diviseur
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int nombre;
            bool EstUn=true;
            int diviseur=2; 
     

            Console.WriteLine("Ce programme permet de déterminer tous les diviseur d'un entier autre que un et lui même: ");

            Console.WriteLine("veuillez saisir un entier:");
            nombre=int.Parse(Console.ReadLine());

            var divise = new List<int>();

            double reste;
            
            List<int> diviseurs = new List<int>();
            bool test = true;
            
            if (test == true)
            {
                Console.WriteLine("Il n'y a pas de diviseurs");
            }
            else
            {
                do
                {
                    reste = nombre % diviseur;
                    if (reste == 0)
                    {
                        diviseurs.Add(diviseur);


                    }
                    diviseur++;
                }
                while (diviseur < nombre);
            }
            Console.WriteLine(diviseurs);



            

        }
        

        
    }
}

