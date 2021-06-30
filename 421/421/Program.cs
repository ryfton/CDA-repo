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

            De d1 = new De(1);
            De d2 = new De(2);
            Console.WriteLine(d1.ToString());
            d1.SeJeter();
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());

            if (d2.CompareTo(d1) <0)
            {
                Console.WriteLine("plus petit");
            }
            else if(d2.CompareTo(d1) == 0)
            {
                Console.WriteLine("son identique");
            }
            else
            {
                Console.WriteLine("plus grand");
            }
            Manche m = new Manche();
            m.LancerLes3Des();
            Console.WriteLine( m.ToString());


        }
    }
}
