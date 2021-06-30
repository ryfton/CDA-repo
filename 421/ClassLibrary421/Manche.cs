using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary421
{
    public class Manche
    {
        private List<De> mes3Des;
        private const int NB_DE_LANCER_MAX = 3;
        private int nbDeLancerCourant;
        

        public Manche()
        {
            List<De> troisDe = new List<De>();
            De d1 = new De(1);
            De d2 = new De(2);
            De d3 = new De(3);
            troisDe.Add(d1);
            troisDe.Add(d2);
            troisDe.Add(d3);
            mes3Des = troisDe;
            nbDeLancerCourant = 3;


        }

        public void LancerLes3Des()
        {
            if (PeutLancer()==true)
            {
                for (int i = 0; i < mes3Des.Count; i++)
                {
                    mes3Des[i].SeJeter();
                }
                nbDeLancerCourant -= 1;

            }
           
            
        }

        public void Lancer(int _numeroDe1,int _numeroDe2 )
        {
            if (PeutLancer() == true)
            {
                for (int i = 0; i < mes3Des.Count; i++)
                {
                    if (mes3Des[i].NumeroDe==_numeroDe1)
                    {
                        mes3Des[i].SeJeter();
                    }
                    if (mes3Des[i].NumeroDe == _numeroDe2)
                    {
                        mes3Des[i].SeJeter();
                    }
                    
                }
                nbDeLancerCourant -= 1;

            }



           
        }
        public void Lancer(int _numeroDe)
        {
            if (PeutLancer() == true)
            {
                for (int i = 0; i < mes3Des.Count; i++)
                {
                    if (mes3Des[i].NumeroDe == _numeroDe)
                    {
                        mes3Des[i].SeJeter();
                    }
                    
                }
                nbDeLancerCourant -= 1;

            }
           
        }
        private bool PeutLancer()
        {
            bool ok = false;
            if (nbDeLancerCourant<=0)
            {
                ok = false;
            }
            else
            {
                ok = true;
            }
           
            return ok;
        }
        public bool MancheGagner()
        {
            bool ok = false;
            return ok;
        }
        public string  RenvoieRepresentationDes()
        {
            return "";
        }

        public override string ToString()
        {
            return "les dés son lancer vous avez "+mes3Des[0].Valeur+" "+mes3Des[1].Valeur +" " + mes3Des[2].Valeur ;
        }
        private void TrierLesDes(List<De> _mesDes)
        {
            _mesDes.Sort();

        }
        //public List<De> Commencer()
        //{
        //    List<De> troisDes = new List<De>();
        //    De d1 = new De(1);
        //    De d2 = new De(2);
        //    De d3 = new De(3);
        //    troisDes.Add(d1);
        //    troisDes.Add(d2);
        //    troisDes.Add(d3);
        //    return troisDes;



        //}
    }
}