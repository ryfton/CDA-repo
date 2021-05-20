using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDunTableau
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> nombre = new List<int>();
            Console.WriteLine("Ce programme permet de trier les éléments d'un tableau :");

            Console.WriteLine("Veuillez saisir un nombre :");
            


            for ( int i=0 ; i < nombre.Count; i++)
            {
                
                nombre[i] = Convert.ToInt16(Console.ReadLine());
            }

            TriBule(nombre);



            for ( int i = 0; i < nombre.Count; i++)
            {
                Console.Write(nombre[i] + "- \t");
            }
            //Console.WriteLine();

            //Console.WriteLine("tapez une touche pour quitter");
            Console.ReadKey();








        }
        public static void TriBule(List<int> _t)
        {
            bool flag = true;
            int c = 0;
            do
            {
                flag = true;
                for (int i = 0; i < (_t.Count - 1); i++)

                    if (_t[i] > _t[i + 1])
                    {
                        c = _t[i];
                        _t[i] = _t[i + 1];
                        _t[i + 1] = c;
                        flag = false;
                    }
            } while (!flag);

        }
    }
}
