using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLePoint
{

    public class Point
    {
        private float x;
        private float y;
        private string nom;

        public float X { get => x; }
        public float Y { get => y; }
        public string Nom { get => nom;}

        public Point()
        {
            x = 0;
            y = 0;
            nom = "A";
        }
        public Point(string _nom ,float _abscisse, float _ordonnee)
        {
            this.x = _abscisse;
            this.y = _ordonnee;
            this.nom = _nom;
        }

        public override string ToString()
        {
            return "La Positions du point " + nom + " est abscisse de : " + x + " est ordonnée de : " + y;
        }

        public void IndiqueSaPosition() 
        {
           Console.WriteLine(ToString());
        }
        
       

        public void Deplacer(float _abscisse, float _ordonnee)
        {
            this.x = _abscisse;
            this.y = _ordonnee;
        }

        public Point ConstruireSymetrieOrdonnee (  string _nom)
        {
            Point newPoint = new Point();
            newPoint.nom = _nom;
            newPoint.x = this.x;
            newPoint.y = -(this.y);



            return newPoint;
        }
        public Point ConstruireSymetrieAbscisse(string _nom)
        {
            Point newPoint = new Point();
            newPoint.nom = _nom;
            newPoint.x =- (this.x);
            newPoint.y = this.y;



            return newPoint;
        }
        public Point ConstruireSymetrieOrigine(string _nom)
        {
            Point newPoint = new Point();
            newPoint.nom = _nom;
            newPoint.x = -(this.x);
            newPoint.y = -(this.y);



            return newPoint;
        }
        public void PermuterSymetrieOrigine()
        {
            float temp = this.y;
            this.y = this.x;
            this.x = temp;

            //if (this.x > 0)/// hor sujet 
            //{
            //   x = -(x);

            //}
            //else
            //{
            //    x = +(x);
            //}
            //if (this.y > 0)
            //{
            //    y = -(y);

            //}
            //else
            //{
            //    y = +-(y);
            //}
           
            
            
        }








    }
}
