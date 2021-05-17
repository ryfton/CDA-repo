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


            uint[] age = new uint[20];
            uint nombreJeune=0;
           

            for (int nombrPersone = 0; nombrPersone < 20; nombrPersone++ )
            {
                bool ageValide = false;
                bool ageVingt = false;
                uint agePropose;

                do
                {
                    
                    Console.WriteLine("veuillez saisir l' age de la personne numero "+( nombrPersone+1)+": ");
                   
                    ageValide = uint.TryParse(Console.ReadLine(),out agePropose);

                    if (ageValide==true)
                    {
                        ageValide = agePropose > 0;
                    }
                                      
                   
                } while (!ageValide);
                age[nombrPersone] = agePropose;
                ageVingt = agePropose < 20;



                if (ageVingt == true)
                {

                    nombreJeune++;
                }
                
            }
            if (nombreJeune ==0)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
            }
            if (nombreJeune == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
            }
            else
            {
                Console.WriteLine("Parmi les personnes " + nombreJeune + " ont moins de vingt ans  ");
            }            

            Console.ReadKey();      
          
        }
        
    }
}
