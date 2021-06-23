using ClassLibraryLePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a= new Point();
            Console.WriteLine(a.IndiqueSaPosition());
            a.Deplacer(10, 15);
            Point b = a.ConstruireSymetrieOrdonnee("B");
            Console.WriteLine(b.IndiqueSaPosition());
            b.PermuterParametreOrigine();
            Point c = b.ConstruireSymetrieOrigine("C");
            Console.WriteLine(c.IndiqueSaPosition());

        }
    }
}
