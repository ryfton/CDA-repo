using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalonsB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] teste = new int[10];
            teste[0] = 1;
            teste[1] = 26;
            teste[2] = 2;
            teste[3] = 25;
            teste[4] = 2;
            teste[5] = 1;
            teste[6] = 21;
            teste[7] = 2;
            teste[8] = 26;
            teste[9] = 8;
            int[] nbcasse = NombreCaseSuivante(teste);
            for (int i = 0; i < nbcasse.Length; i++)
            {
                Console.WriteLine(nbcasse[i]);
            }
            Console.ReadKey();
        }
        static public int[] NombreCaseSuivante(int[] _nombre)
        {
            
            int[] elementSuivants = new int[_nombre.Length];
            //for (int i = 0; i < _nombre.Length; i++)
            //{
            //    int nombreDeCase = 0;

            //    foreach (var item in _nombre)
            //    {
                    
            //        if (_nombre[i].CompareTo(item) < 0 )
            //        {
            //            nombreDeCase++;
            //            elementSuivants[i] = nombreDeCase;
            //        }
                 
            //    }
                
                
            //}
            for (int i = 0; i < _nombre.Length; i++)
            {
                int nombreDeCase = 0;
                for (int j = _nombre[i]; j < _nombre.Length-1; j++)
                {
                    if (_nombre[i].CompareTo(_nombre[j]) < 0)
                    {
                        nombreDeCase++;
                        elementSuivants[i] = nombreDeCase;
                    }

                }

            }
            return elementSuivants;
        }
        
    }
}
