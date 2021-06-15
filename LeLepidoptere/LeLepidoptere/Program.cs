using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeLepidoptere.LesStadeEvo;
using LeLepidoptere;

namespace LeLepidoptere
{
    class Program
    {
        static void Main(string[] args)

           
        {
            Lepidoptere beatrice = new Lepidoptere("milou");
            beatrice.SeDeplacer();
            beatrice.SeTransformer(); 
            beatrice.SeDeplacer();
            beatrice.SeTransformer();
            beatrice.SeDeplacer();
            beatrice.SeTransformer();
            beatrice.SeDeplacer();
            beatrice.SeTransformer();

        }
    }
}
