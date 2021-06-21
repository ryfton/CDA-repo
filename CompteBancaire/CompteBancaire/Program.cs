using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire c = new CompteBancaire(0001, "franck", 1500, -1000);
            CompteBancaire c2 = new CompteBancaire(0002, "Collet", 25000, -500);
            c.Transferer(10000, c2);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c2.ToString());
            if (c.SuperieurAutreCompte(c2))
            {
                Console.WriteLine("superieur");
            }
            else
            {
                Console.WriteLine("inférieure");
            }

        }
    }
}
