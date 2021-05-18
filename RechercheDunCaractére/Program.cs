using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheDunCaractére
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("veulliez saisire une phrase et finir par un point.");
            string phrase = Console.ReadLine();
            ChaineVide(phrase);

            Console.ReadKey();
        }
        public static void RechercheCaractére(char _a, string _chaineCaractére)
        {

        }
        public static void ChaineVide(string _chaineCaractére)
        {


            if (_chaineCaractére.Length == 0)
            {
                Console.WriteLine("la phrase est vide.");

                // Console.WriteLine("la phrase est vide."​);
            }

        }
    }
}
