using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            int scoreJoueurDeux = 6;
            string mot;
            char recherche;
            string motAffichage;
            
            
            Console.WriteLine("veuillez saisir un mot de 5 caractères minimum: ");
            mot = Console.ReadLine();
            motAffichage = mot;
            
            if (mot.Count()<5)
            {
                Console.WriteLine("Le mot ne contient pas assez de caractères ! ");

            }
            else
            {
                //char[] motTrouver =mot.ToCharArray();
                char[] motJoueurDeux = new char[4];
                char[] motJoueurUn = mot.ToCharArray();
                while (scoreJoueurDeux>0 && motJoueurDeux!=motJoueurUn)
                {
                    Console.WriteLine("Veuillez saisir une lettre pour trouver le mot :");
                    string c = Console.ReadLine();
                    char caratére = char.Parse(c);

                     motJoueurDeux[caratére]

                    recherche = RechercheCaractére(caratére,mot);
                    if (recherche==caratére)
                    {
                        Console.WriteLine(recherche);
                    }
                    else
                    {
                        scoreJoueurDeux --;
                    }




                }
                if (motJoueurDeux==motJoueurUn)
                {
                    Console.WriteLine("Bravo vous avez trouver le mot "+mot);
                }
                else
                {
                    Console.WriteLine("Désoler vous n'avez pas trouver le mot "+mot); 
                }

             
            }
            

          
            Console.ReadKey();

       

        }
        public static char RechercheCaractére(char _a, string _chaineCaractére)
        {
            bool charOk=false;
            char vide = '_';
            foreach (char c in _chaineCaractére)
            {
                if (c == _a)
                {
                    charOk = true;
                }

            }
            if (charOk==true)
            {
                return _a;
            }
            else
            {
                return vide;
            }
            
        }
    }
}
