using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary421
{
    public class De: IComparable<De>,IComparable
    {
        
        private int valeur;
        private const int NB_FACE = 6;
        private int numeroDe;

        public int Valeur { get => valeur;}
        public int NumeroDe { get => numeroDe;}

        public De(int _numero)
        {
             numeroDe = _numero;
             valeur=Alea.Instance().Nouveau(1,NB_FACE);
        }

        public void SeJeter()
        {
            this.valeur= Alea.Instance().Nouveau(1, NB_FACE );
        }
        public override string ToString()
        {
            return "Le De numero "+numeroDe+ " affiche : " + valeur;
        }

        public int CompareTo(De other)
        {
           if(this.valeur < other.valeur)
            {
                return -1;
            }
            else if (this.valeur ==other.valeur)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public int CompareTo(object obj)
        {
            return 1;
            
        }
    }
}
