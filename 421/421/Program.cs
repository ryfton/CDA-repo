using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary421;
using ClassLibraryjoeur;
using ClassLibrarySerialisation;

namespace _421
{
     class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Joueur j1;
            ListedeJoueurs joueurs = new ListedeJoueurs();
            int nbManche;
            bool relancerManche = false;
            bool passerManche = false;
            bool passerPartie = false;
            
            

            Console.WriteLine("veuillez saisir votre nom :");
            joueurs.AjouterJoueur( j1 = new Joueur(score, Console.ReadLine()));

            Console.WriteLine("veuillez saisir le nombre de manche que vous voulez jouer:");
            nbManche = int.Parse(Console.ReadLine());
            MaPartie firstGame = new MaPartie(nbManche);

            while (firstGame.NbMancheAjouer > 0 && passerPartie == false)
            {
                Console.WriteLine("Voulez vous lancer les dés O/N ?");
                string reponse = (Console.ReadLine());
                reponse = reponse.ToUpper();
                if (reponse == "O")
                {
                    Console.Clear();
                    firstGame.Commencer();
                    Console.WriteLine("Début de la manche il vous reste " + firstGame.NbMancheAjouer + " manche a jouer.\n");
                    Console.WriteLine("Le score est de : " + (score = firstGame.AfficherScore()) + "\n");
                    relancerManche = false;
                    Console.WriteLine(firstGame.ToString());

                    while (relancerManche == false && firstGame.NbMancheAjouer >= 0 && firstGame.MancheTerminer() == false)
                    {
                        Console.WriteLine("Voulez vous relancer  O/N ? ");
                        string boucleRelance = (Console.ReadLine());
                        boucleRelance = boucleRelance.ToUpper();
                        if (boucleRelance == "O")
                        {
                            Console.WriteLine("Quelle dé voulez vous relancer à saisir sous la forme numéraire :");
                            string deARelancer = Console.ReadLine();                         
                            ChoixDuDe(deARelancer, firstGame);
                        }
                        else
                        {
                            passerManche = true;
                        }
                        Console.WriteLine(firstGame.ToString());
                        if (firstGame.MancheTerminer() == true || passerManche == true)
                        {
                            relancerManche = true;
                            Console.WriteLine("Manche terminer");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Si vous ne voulez pas lancer les dés la partie est terminer!!");
                    passerPartie = true;
                }
            }

            if (firstGame.EstGagne() == true)
            {
                Console.WriteLine("Bravo vous avez gagner!!! Votre score est de : "+j1.Scores);
            }
            else if (passerPartie == true)
            {
                Console.WriteLine("Dommage vous avez quittez la partie !!! Votre score est de : " + j1.Scores);
            }
            else
            {
                Console.WriteLine("Dommage vous avez perdu !!! Votre score est de : " + j1.Scores);
            }

           
            Console.ReadKey();
        }

        public static void ChoixDuDe(string _choixDeDes, MaPartie _game)
        {
            int dé1, dé2, dé3;
            string[] choix = _choixDeDes.Split('/', ' ', ',', ';', ':');
            if (choix.Length == 3)
            {
                _game.LancerLes3Des();
            }
            if (choix.Length == 2)
            {
                int.TryParse(choix[0], out dé1);
                int.TryParse(choix[1], out dé2);
                _game.Lancer(dé1, dé2);
            }
            if (choix.Length == 1)
            {
                int.TryParse(choix[0], out dé3);
                _game.Lancer(dé3);
            }

        }
    }

}
