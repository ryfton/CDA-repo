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
            Point c = new Point();
            c.IndiqueSaPosition();
            c.Deplacer(10, 15);
            Point b =c.ConstruireSymetrieOrdonnee("B");
            b.IndiqueSaPosition();
            b.PermuterSymetrieOrigine();
            b.IndiqueSaPosition();

        }
    }
}
