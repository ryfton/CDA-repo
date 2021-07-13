using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenduV
{
    class Program
    {
        static void Main(string[] args)
        {
            string ca;
            bool motTrouver = false;
            string motJUn = "";
            List<char> motJeux = new List<char>();
            List<char> motFlag = new List<char>();
            bool longueurMot = false;
            int scoreJoueurDeux = 5;

            while (longueurMot == false)
            {

                Console.WriteLine("veuillez saisir un mot");
                motJUn =  Console.ReadLine();
                motJUn = motJUn.ToUpper();

                motFlag = motJUn.ToList();
                motJeux = motJUn.ToList();
                if (motJeux.Count > 5)
                {
                    longueurMot = true;
                }
            }
            Console.Clear();

            for (int i = 0; i < motJeux.Count; i++)
            {
                if (i == 0 || i == motJeux.Count - 1)
                {

                    Console.Write(motJeux[i]);

                }
                else
                {
                    Console.Write('_');
                    motJeux[i] = '_';

                }

            }



            Console.WriteLine();
            Console.WriteLine("************************************");

            int compteur=0;
            while (motTrouver == false)
            {

                Console.WriteLine("");
                Console.WriteLine("Veuillez saisir une lettre");
                ca=Console.ReadLine().ToUpper();
                char c = char.Parse(ca);
                bool lettreTrouver = false;


                for (int i = 0; i < motFlag.Count; i++)                  
                {

                    if (c == motFlag[i] && motJeux[i]!=c)//&&  i != 0 || i != motFlag.Count - 1) new pointer sur index de mot jdeux
                    {
                       
                        motJeux[i] = motFlag[i];

                        compteur++;
                        lettreTrouver = true;
                    }





                    //else if (i != 0 || i != motFlag.Count - 1 )  
                    //    {
                    //         Console.Write('_');
                   
                    Console.Write (motJeux[i]);

                }
                Console.WriteLine();
                Console.Write("la lettre " + c);

                if (lettreTrouver == false)// a modifier ci le mot comporete plus de 4 fois la meme lettre
                {
                    Console.WriteLine(" n'est pas une lettre cacher dans le mot nombre, il vous reste "+ scoreJoueurDeux+" coups");
                    scoreJoueurDeux --;
                }
                else
                {

                    Console.WriteLine(" est dans le mot.");
                }

              
                

                if (compteur==motFlag.Count()-2||scoreJoueurDeux < 0)  //motJeux == motFlag &&
                {
                    
                    
                    motTrouver = true;
                }

            }
            Console.WriteLine();
            if (scoreJoueurDeux <= 0)
            {
                Console.WriteLine("Vous avez perdu vous avez utilisé vos six coups!!!");

            }
            else
            {
                Console.WriteLine("Bravo enfin!!!!!!");

            }
            
            Console.ReadKey();

        }

    }
}
