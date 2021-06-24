using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction
{
    public class Fraction
    {
        private decimal numerateur;
        private decimal denominateur;

        public decimal Numerateur { get => numerateur; }
        public decimal Denominateur { get => denominateur; }

        public override string ToString()
        {
            decimal modulo = this.numerateur % this.denominateur;

            if (modulo == 0)
            {
                return "<< " + numerateur / denominateur + " >> pour la fraction " + numerateur + "/" + denominateur;
            }
            else
            {
                return "<< " + numerateur + "/" + denominateur + " >> pour la fraction " + numerateur + "/" + denominateur;
            }

        }

        public Fraction(decimal _numerateur, decimal _denominateur)
        {
            numerateur = _numerateur;
            denominateur = _denominateur;
        }
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }
        public Fraction(decimal _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;

        }
        public Fraction(Fraction _copieFraction)
        {
            this.numerateur = _copieFraction.numerateur;
            this.denominateur = _copieFraction.denominateur;

        }

        public void Oppose() // rvenir dessu
        {
            if (this.numerateur > 0)
            {
                this.numerateur = -(this.numerateur);
            }
            else
            {
                this.numerateur = +-(this.numerateur);
            }

        }
        public void Inverse()
        {
            decimal temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }
        public bool SuperieurA(Fraction _autreFraction)
        {
            bool superieur = false;                       // On peut faire une méthode pour calculer la fraction et la réutiliser dans les autre méethode (opti)
            decimal res1;
            decimal res2;

            res1 = this.numerateur / this.denominateur;
            res2 = _autreFraction.numerateur / _autreFraction.denominateur;
            if (res1 > res2)
            {
                superieur = true;
            }
            else
            {
                superieur = false;
            }


            return superieur;
        }
        public bool EgalA(Fraction _autreFraction)
        {
            bool egal = false;
            decimal res1;
            decimal res2;

            res1 = this.numerateur / this.denominateur;
            res2 = _autreFraction.numerateur / _autreFraction.denominateur;
            if (res1 == res2)
            {
                egal = true;
            }
            else
            {
                egal = false;
            }


            return egal;
        }
        private decimal GetPgcd()
        {
            decimal a = this.numerateur;
            decimal b = this.denominateur;
            decimal pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }

                }
                pgcd = a;

            }
            return pgcd;


        }
        private void Reduire()
        {

            if (this.numerateur < 0 && this.denominateur < 0)
            {
                this.numerateur = +-(this.numerateur);
                this.denominateur = +-(this.denominateur);
            }
            if (this.numerateur > 0 && this.denominateur < 0)
            {
                this.numerateur = -(this.numerateur);
                this.denominateur = +-(this.denominateur);
            }

            decimal pgcd = GetPgcd();
            this.numerateur /= pgcd;
            this.denominateur /= pgcd;

        }
        public Fraction Plus(Fraction _autreFraction)
        {

            Fraction f = new Fraction((this.numerateur * _autreFraction.denominateur) + (this.denominateur * _autreFraction.numerateur), this.denominateur * _autreFraction.denominateur);
            f.Reduire();
            return f;

        }
        public Fraction Moins(Fraction _autreFraction)
        {
            Fraction f = new Fraction((this.numerateur * _autreFraction.denominateur) - (this.denominateur * _autreFraction.numerateur), this.denominateur * _autreFraction.denominateur);
            f.Reduire();
            return f;

        }
        public Fraction Multiplie(Fraction _autreFraction)
        {
            Fraction f = new Fraction((this.numerateur * _autreFraction.numerateur), (this.denominateur * _autreFraction.denominateur));
            f.Reduire();
            return f;
        }
        public Fraction Divise(Fraction _autreFraction)
        {
            Fraction f;
            Fraction temp = new Fraction(_autreFraction);
   
            temp.Inverse();
            f = this.Multiplie(temp);
            

            f.Reduire();
            return f;
        }
        public Fraction FPlus(Fraction _uneFraction, Fraction _uneAutreFraction)
        {
           Fraction f = _uneFraction.Plus(_uneAutreFraction);
            f.Reduire();
            return f;

        }


    }


}
