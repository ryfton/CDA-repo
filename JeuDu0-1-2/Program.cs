using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int scorePC=0;
            int scoreJoueur=0;
            int nombreJoueur=0;
            var difference=0;
            int nombreMachine;
            //int[] nombreMachine=new int[3] { 0, 1,2 };
            Random aleatoire = new Random();



            while (scoreJoueur != 10 && scorePC != 10) 
            {
                nombreMachine=aleatoire.Next(0, 2);
                Console.WriteLine("Veuillez choisir un chiffre entre 0 et 2 compris");
                nombreJoueur = int.Parse(Console.ReadLine());
                
                if (nombreJoueur<nombreMachine)
                {
                    difference=nombreMachine - nombreJoueur;
                    if (difference==1)
                    {
                        scoreJoueur++;
                    }
                    else
                    {
                        scorePC++;
                    }
                }
                else if (nombreJoueur > nombreMachine)
                {
                    difference = nombreJoueur- nombreMachine;
                    if (difference == 1)
                    {
                        scorePC++;
                    }
                    else
                    {
                        scoreJoueur++;
                    }
                }

                Console.WriteLine("le score est de [" + scoreJoueur + "] pour le joueur et de [" + scorePC+ "] pour l' IA.");
                Console.WriteLine();


            } 

            if (scoreJoueur<scorePC)
            {
                Console.WriteLine("Le grand gagant est l'IA ");
            }
            else
            {
                Console.WriteLine("Le grand gagant est le joueur ");
            }


            Console.ReadKey();
        }
    }
}
