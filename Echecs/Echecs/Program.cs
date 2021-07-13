using JeuxEchecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryechecs;

namespace Echecs
{
    class Program
    {
        static void Main(string[] args)
        {
            StruCaseCharInt positionTourBlancheGauche = new StruCaseCharInt('a',1);
            Tour tourBlancheGauche = new Tour("blanche","Tour", positionTourBlancheGauche);
            StruCaseCharInt pca1 = new StruCaseCharInt('a', 1);
            Case a1 = new Case(pca1, "noir");

            
        }
    }
}
