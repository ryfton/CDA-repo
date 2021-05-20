using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuFourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration variables et random
            Random aleatoire = new Random();
            int nombreMachine, nombreUtilisateur;
            nombreMachine = aleatoire.Next(0, 101);
            int min = 0;
            int max = 100;
            int resultat;

            do
            {

            
            Console.WriteLine("Veuillez entrer un nombre entre " + min + " et " + max);
            nombreUtilisateur = int.Parse(Console.ReadLine());
            resultat = ComparaisonMachineUtilisateur(nombreMachine, nombreUtilisateur);

            if (resultat==1)
            {
                Console.WriteLine("le nombre est  trop grand!");
                    max = nombreUtilisateur;
            }
            if(resultat==0)
            {
                Console.WriteLine("le nombre est trop petit!");
                    min = nombreUtilisateur;
            }
            } while (nombreMachine!=nombreUtilisateur);
            Console.WriteLine(" Bravo vous avez trouvez le  nombre  : " + nombreUtilisateur);


            Console.ReadKey();

        }
        //méthode permetant de comparer nombre pc et nombre utilisareur retourne 1 pour trop grand et 0 pour trop petit.
        public static int ComparaisonMachineUtilisateur (int _nombrePc,int _nombrePersone)
        {
            int resultat=3;
            
            
           
            
            
                if (_nombrePersone>_nombrePc)
                {
                    resultat = 1;
                }
                if (_nombrePersone < _nombrePc)
                {
                    resultat = 0;
                }
                
                        
                

           
            return resultat;
        }
            


    }
}
