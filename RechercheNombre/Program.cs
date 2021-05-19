using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheNombre
{
    class Program
    {
        static void Main(string[] args)
        {   // Déclaration variable.

            bool finDeSaisi = false;
            int nombre;
            string validation = "";
            int nombrARechercher;

            // Affichage utilisateur.

            Console.WriteLine("Ce programme permet de trier des nombre et de rechercher l'indice d'un nombre donné.");

            // déclaration liste.
            List<int> listNombre = new List<int>();

            // saisie de l'utilisateur, et affectation des valeur dans la liste 
            do
            {
                //Saisie d'un nombre
                Console.WriteLine("veuillez saisir un nombre: ");
                nombre = int.Parse(Console.ReadLine());

                listNombre.Add(nombre);





                //Demande si il veut continuer de saisir
                Console.WriteLine("Avez vous fini votre saisi?(o/n):");
                validation = Console.ReadLine();
                validation = validation.ToUpper();

                if (validation == "O")
                {
                    finDeSaisi = true;
                }
                else
                {
                    finDeSaisi = false;
                }


            } while (finDeSaisi != true);

            // trie de la liste à l'aide de la méthode Tribule. 

            TriBule(listNombre);


            // Affichage liste trier
            Console.WriteLine("Liste de nombre");

            foreach (int item in listNombre)
            {
                Console.WriteLine(item);
            }


            // saisie du nombre à rechercher par l'utilisateur.
            Console.WriteLine("quelle nombre voulez vous rechercher");
            nombrARechercher = int.Parse(Console.ReadLine());


            // recherche et affichage du nombre à l'aide des méthodes RechercheNombreDonné et ValeurIndiceNombre. 
           // RechercheNombreDonné(nombrARechercher, listNombre);
            int indice =ValeurIndiceNombre(nombrARechercher, listNombre);
            Console.WriteLine("l'indice de "+nombrARechercher+ "  dans le tableau est: " + indice);

            Console.ReadKey();



        }
        /// <summary>
        ///  Méthode permettant de doner l'indice d'un nombre dans une liste
        /// </summary>
        /// <param name="_nombreDonné"></param>
        /// <param name="_listeNombre"></param>
        public static int ValeurIndiceNombre(int _nombreDonné, List<int> _listeNombre)
        {
            int flag = 0;
            int index = 0;
            bool trouver=true;
            

            
            while (trouver==true && index< _listeNombre.Count)
            {
                if (_listeNombre[flag] == _nombreDonné)
                {
                       
                        trouver = false;


                }
                else
                {
                    flag++;
                    index++;
                }

            }
            
            return index;
           // foreach (int item in _listeNombre)
            //{




            //    if (item != _nombreDonné)
            //    {
            //        ondex++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("l'indice du nombre dans le tableau est: " + ondex);
            //    }

            //}


        }
        /// <summary>
        ///   Méthode permettant de trouver un nombre dans une liste
        /// </summary>
        /// <param name="_nombreDonné"></param>
        /// <param name="_listeNombre"></param>
        public static void RechercheNombreDonné(int _nombreDonné, List<int> _listeNombre)
        {
            foreach (int item in _listeNombre)
            {

                if (item == _nombreDonné)
                {
                    Console.WriteLine(item);
                }



            }



        }
        /// <summary>
        ///   Méthode permettant de trier une liste
        /// </summary>
        /// <param name="_t"></param>
        public static void TriBule(List<int> _t)
        {
            bool flag = true;
            int c = 0;
            do
            {
                flag = true;
                for (int i = 0; i < (_t.Count - 1); i++)

                    if (_t[i] > _t[i + 1])
                    {
                        c = _t[i];
                        _t[i] = _t[i + 1];
                        _t[i + 1] = c;
                        flag = false;
                    }
            } while (!flag);
        }
    }
}
