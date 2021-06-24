using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFraction;

namespace LaFraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction f1 = new Fraction(-6,-3);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(-128,64);
            //f1.Oppose();
            //f1.Inverse();
            
            f1=f3.Moins(f1);
           
            Console.WriteLine(f1.ToString());
            
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());


        }
    }
}
