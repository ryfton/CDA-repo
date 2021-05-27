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
            bool motCorespond=false;
            List<char> affichage = new List<char>();
            
            // saisie joueur 1.
            Console.WriteLine("veuillez saisir un mot de 5 caractères minimum: ");
            mot = Console.ReadLine();
            motAffichage = mot;
            Console.Clear();

            // teste longeur mot.
            if (mot.Count()<5)
            {
                Console.WriteLine("Le mot ne contient pas assez de caractères ! ");

            }
            else
            {
                // affichage mot jouer1
                // v 1 "char[] motTrouver =mot.ToCharArray();"
                List<char> motJoueurDeux = new List<char>();
                List<char> motJoueurUn = mot.ToList();
                List<char> motJoueurUnCompare = mot.ToList();

                for (int i = 1; i < motJoueurUn.Count - 1; i++)
                {
                    motJoueurUn[i]= '_';
                }

                foreach (char citem in motJoueurUn)
                {
                  
                    Console.Write(citem);
                }
                Console.WriteLine();
                
                while (scoreJoueurDeux>0 && motCorespond==false)
                {
                    Console.WriteLine("Veuillez saisir une lettre pour trouver le mot :");
                    string c = Console.ReadLine();
                    char caratére = char.Parse(c);

                    

                    recherche = RechercheCaractére(caratére,mot);

                    if (recherche == caratére)
                    {
                      
                        motJoueurDeux.Add(recherche);


                         Afficher(recherche, motJoueurDeux,motJoueurUnCompare);// {probleme avec les lettres identique}

                        foreach (char item in motJoueurDeux)
                        {
                            //(item);// {si la lettre est présente afficher a la bonne place.}
                            Console.Write(item);

                        }
                        Console.WriteLine();
                        
                    }
                    else
                    {
                        scoreJoueurDeux --;
                    }


                    motCorespond = MotEgale( motJoueurDeux, motJoueurUnCompare);// **probleme sort dés la premiere lettre juste **
                 

                }

                bool areEqual = MotEgale(motJoueurDeux, motJoueurUnCompare);
                if (areEqual==true )
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
        public static bool MotEgale( List<char> _premier, List<char> _deuxieme)
        {
            bool motEgale=false;

                int i = 0;
            while(motEgale == false && i<_premier.Count)
{
                if (_premier[i] == _deuxieme[i] && _premier.Count == _deuxieme.Count)//**correction ajout a if(&& _premier.Count == _deuxieme.Coun) et inversion true false ca marche.
                {
                    motEgale = true;
                }
                else
                {
                    motEgale = false;
                }
                i++;
                
            }
            return motEgale;
        }
        public static List<char>Afficher(char _lettre, List<char> _deuxieme,List<char>_compar)
        {
            bool listDansLordre =false;
            int i = 0;
            while (listDansLordre==false && i < _compar.Count-1)
            {
                if (_compar[i]==_lettre)

                {
                    _deuxieme[i] = _compar[i];




                    if (_compar[i]==_compar.Count-1)
                    {
                        listDansLordre = true;
                    }
                        
                }
                else
                {
                    if (_compar[i] == _compar.Count-1)
                    {
                        listDansLordre = true;
                    }
                    else
                    {
                        //_deuxieme[i] = '_';
                        listDansLordre = false;
                    }
                   
                }
                i++;
            }

            return _deuxieme;
                
        }

    }
}
