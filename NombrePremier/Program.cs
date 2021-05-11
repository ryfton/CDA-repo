using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombrePremier
{
   public class Program
    {
        static void Main(string[] args)
        {
            uint nombreDébut;
            bool vérification;


            Console.WriteLine("Veuillez saisir un nombre entier !");
            nombreDébut = uint.Parse(Console.ReadLine());
            vérification =EstNombrePremier(nombreDébut);

            if (vérification == true)
            {
                Console.WriteLine( +nombreDébut+" est un nombre entier!");
            }
            else
            {
                Console.WriteLine(+nombreDébut + " n'est pas un nombre entier!");

               
            }
            List<int> resultat = RechercheLesDiviseursDUnNombre(nombreDébut);
            Console.Write("Les diviseurs sont : ");
            for (int i = 0; i < resultat.Count; i++)
            {
                Console.Write(" /" + resultat[i] );
            }



            Console.ReadKey();

        }
     
        /// <summary>
        /// Méthode pour determiner les nombre premier. retourne un bool et prend un double en parametre
        /// </summary>
        /// <param name="_nombreATester"></param>
        /// <returns> un bool permier </returns>
        public static bool EstNombrePremier(uint _nombreATester)

        {
            double reste;
            int diviseur = 2;
            bool estPremier = true;

            // _nombreATester == 0, car il est divisible par tous les nombres
            //_nombreATester == 1, car il est divisible que par lui meme
            if (_nombreATester == 0 || _nombreATester == 1)
            {
                estPremier = false;
            }
            else
            {
                //traitement si _nombreATester>=2
                while ((diviseur < _nombreATester) && estPremier)
                {
                    reste = _nombreATester % diviseur;
                    if (reste == 0)
                    {
                        estPremier = false;
                    }
                    diviseur++;
                }
            }

            return estPremier;

        }
        /// <summary>
        /// Métodes pour trouver les diviseur d'un nombre.
        /// avec liste de int et un double en parametre.
        /// </summary>
        /// <param name="_nombre"></param>
        /// <returns> int </returns>
        public static List<int> RechercheLesDiviseursDUnNombre(uint _nombre)
        {
            double reste;
            int Diviseur = 2;
            List<int> diviseurs = new List<int>();
            bool test=true;
            //????? test = EstNombrePremier(_nombre);
            if (test == true)
            {
                Console.WriteLine("Il n'y a pas de diviseurs");
            }
            else
            {
                do
                {
                    reste = _nombre % Diviseur;
                    if (reste == 0)
                    {
                        diviseurs.Add(Diviseur);


                    }
                    Diviseur++;
                }
                while (Diviseur < _nombre);
            }
            return diviseurs;



        }
    }
  

}
