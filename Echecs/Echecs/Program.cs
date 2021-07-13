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

            //Début initialisation
            StruCaseCharInt pca1 = new StruCaseCharInt('a', 1);
            Case a1 = new Case(pca1, "noire");
            StruCaseCharInt pcb1 = new StruCaseCharInt('b', 1);
            Case b1 = new Case(pcb1, "blanche");
            StruCaseCharInt pcc1 = new StruCaseCharInt('c', 1);
            Case c1 = new Case(pcc1, "noire");
            StruCaseCharInt pcd1 = new StruCaseCharInt('d', 1);
            Case d1 = new Case(pcd1, "blanche");


        }
    }
}
