using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary421;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbManche;
            bool relancerManche = false;
            bool passerManche = false;
            bool passerPartie = false;




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
                    relancerManche = false;
                    Console.WriteLine(firstGame.ToString());




                    while (relancerManche == false && firstGame.NbMancheAjouer >= 0&& firstGame.MancheTerminer()==false)
                    {
                        int deRelancer;
                        int dé1, dé2;

                        Console.WriteLine("Voulez vous relancer  O/N ? ");
                        string boucleRelance = (Console.ReadLine());
                        boucleRelance = boucleRelance.ToUpper();
                        if (boucleRelance == "O")
                        {

                            

                            Console.WriteLine("Voulez vous relancer les trois dés O/N ? ");
                            string reponse2 = (Console.ReadLine());
                            reponse2 = reponse2.ToUpper();

                            if (reponse2 == "O")
                            {
                                firstGame.LancerLes3Des();

                            }
                            else
                            {
                                
                                Console.WriteLine("Ou voulez vous relancer deux dés  O/N ? ");
                                string reponse3 = (Console.ReadLine());
                                reponse3 = reponse3.ToUpper();
                                if (reponse3 == "O")
                                {
                                   
                                    Console.WriteLine("Quelle dé voulez vous relancer à saisir sous la forme: 1/2");
                                    string[] deuxDeRelancer = Console.ReadLine().Split('/');
                                    int.TryParse(deuxDeRelancer[0], out dé1);
                                    int.TryParse(deuxDeRelancer[1], out dé2);
                                    firstGame.Lancer(dé1, dé2);
                                }
                                else
                                {
                                   
                                    Console.WriteLine("Si non quelle dé voulez vous relancer  :1/2/3");
                                    deRelancer = int.Parse(Console.ReadLine());
                                    if (deRelancer == 1)
                                    {
                                        firstGame.Lancer(1);
                                    }
                                    if (deRelancer == 2)
                                    {
                                        firstGame.Lancer(2);
                                    }
                                    if (deRelancer == 3)
                                    {
                                        firstGame.Lancer(3);
                                    }

                                }




                            }
                           
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
                Console.WriteLine("Bravo vous avez gagner!!!");
            }
            else if (passerPartie == true)
            {
                Console.WriteLine("Dommage vous avez quittez la partie !!!");
            }
            else
            {
                Console.WriteLine("Dommage vous avez perdu !!!");
            }


            Console.ReadKey();









        }
    }
}
