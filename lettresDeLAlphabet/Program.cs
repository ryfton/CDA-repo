using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettresDeLAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreDeFois=0;
            bool chaineComplete = false;
            char lettre ;
            string lettres = ("abdcefghijklmnopqrstuvwxyz");

            Console.WriteLine("Veuillez saisir un texte avec au moins 120 caractéres.");
            string texte = Console.ReadLine();
            chaineComplete = ControlNombreCaractére(texte);
            //lettre = Alphabet(lettres);

            if (chaineComplete)
            {
                foreach (char item in lettres)
                {
                    lettre=item;         
                    
                    nombreDeFois = RechercheCaractéreNombreOccurrence(lettre, texte);
                    if (nombreDeFois>0)
                    {
                        Console.WriteLine("la lettre " + lettre + " est présente " + nombreDeFois + " fois dans le texte.");



                    }
                    else
                    {
                        Console.WriteLine("la lettre " + lettre + " n'est pas présente dans le texte.");
                    }
                    Console.WriteLine("");


                }
                
            }
            Console.ReadKey();
        }
        public static bool ControlNombreCaractére(string _texte)
        {
            bool chaineComplete=false;
             
            List<string> flag = new List<string>(119);

            if (_texte.Length > flag.Count)
            {
                chaineComplete = true;
            }
            return chaineComplete;

        }
        public static int RechercheCaractéreNombreOccurrence(char _a, string _chaineCaractére)
        {

            int compteur = 0;
            foreach (char c in _chaineCaractére)
            {
                if (c == _a)
                {
                    compteur++;
                }

            }

            return compteur;

        }
        //public static char  Alphabet(string _a)
        //{    char lettre='.';
        //    string lettres = ("abdcefghijklmnopqrstuvwxyz");
        //    foreach (char item in lettres)
        //    {
        //        lettre = item;

        //    }
        //    return lettre;
        //}
    }
}
  