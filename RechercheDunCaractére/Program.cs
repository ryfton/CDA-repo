using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheDunCaractére
{
    class Program
    {
        static void Main(string[] args) 
        {
                                         
            Console.WriteLine("veulliez saisire une phrase et finir par un point.");
            string phrase = Console.ReadLine();

            string statueChaine=ChaineVide(phrase);
            Console.WriteLine(statueChaine);




            if (statueChaine!= "la phrase est vide.")
            {
                Console.WriteLine("veuillez saisire un caractére pour la recherche :");
                string c = Console.ReadLine();
                char caratére = char.Parse(c);
                int nombreDefois = RechercheCaractéreNombreOccurrence(caratére, phrase);
                
                 if (nombreDefois==0)
                 {
                    Console.WriteLine("la lettre n'est pas présente");
                 }
                 else
                {
                    Console.WriteLine($"la lettre est presente {nombreDefois} fois");
                }
            }



            Console.ReadKey();
        }
        public static int RechercheCaractéreNombreOccurrence(char _a, string _chaineCaractére)
        {
            
            int compteur=0;
            foreach (char c in _chaineCaractére)
            {
                if (c== _a)
                {
                    compteur++;
                }
               
            }
       
            return compteur;
        }
        public static string ChaineVide(string _chaineCaractére)
        {
            string statusChaine="";

            if (_chaineCaractére.Length <=1  ||_chaineCaractére.Length==0)
            
                statusChaine="la phrase est vide.";
            return statusChaine;

               
            

        }
        
            
            
        
    }
}
