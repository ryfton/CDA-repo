using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreDeJeunes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[0];
            bool ok = false;
            int nombrPersone = 0;
            do
            {    
                Console.WriteLine("veuillez saisir votre age: ");
                int[] age = new int[] { int.Parse(Console.ReadLine()) };
                nombrPersone++;
               

            } while (nombrPersone != 20 && nombrPersone < 20);



            Console.WriteLine(age[2]);
            Console.WriteLine(age[3]);
            Console.WriteLine(age[5]);
            Console.WriteLine(age[6]);
            Console.WriteLine(age[1]);
        }
    }
}
