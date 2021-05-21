using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom

{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase,phraseReverse,finDePhrase;
            bool palindrom=false;
            
            Console.WriteLine("veuillez saisir une phrase terminer par un point:");
            phrase = Console.ReadLine().ToLower();
            
            // teste de phrase vide.
            finDePhrase=phrase.Substring(phrase.Length - 1);
            if (finDePhrase == "."&& phrase.Length<1)
            {
                Console.WriteLine("la phrase est vide");
            }else
            { phrase = phrase.Substring(0,phrase.Length-1);
                while (!palindrom)
                {

                    Console.WriteLine(phrase);

                }


            }


            Console.ReadLine();


        }
            


    }
}
