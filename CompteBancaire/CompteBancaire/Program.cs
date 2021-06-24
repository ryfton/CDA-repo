using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCompte;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c = new Compte(0001, "franck", 1500, -1000);
            Compte c2 = new Compte(0002, "Collet", 25000, -500);
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

            Banque az = new Banque("credit Mutuel","Mulhouse");
            az.AjouteCompte(c2);
            az.AjouteCompte(c);

            Console.WriteLine(az.ToString());
        }
    }
}
