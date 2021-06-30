using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarPc;

namespace Pc
{
    class Program
    {
        static void Main(string[] args)
        {

            PcTravail pcJean = new PcTravail("intel",56565);

            Console.WriteLine(pcJean.ToString());



        }
    }
}
