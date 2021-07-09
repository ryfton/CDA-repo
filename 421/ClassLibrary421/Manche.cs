using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary421
{/// <summary>
/// La classe Manche permet d'initialiser une liste de dé ,elle crée trois instance de dé pour cela. elle manipule les instance de la classe dé.Elle est 
/// necessaires au fonctionement et regroupe une grande partie des  méthodes  de la classe partie. Elle est internal pour des raison de sécurité ,elle ne
/// peut etre visible du programme, seulement dans les classe du même assembly. 
/// </summary>
    internal class Manche
    {
        /// <summary>
        /// Liste de 3 instance de dé necessaire au déroulement du jeux.Permet de représenter les dé dans la partie.
        /// </summary>
        private List<De> mes3Des;
        /// <summary>
        /// Attributs de types int constant qui permmet de fixer le nombre de lancer d'une manche.
        /// </summary>
        private const int NB_DE_LANCER_MAX = 3;
        /// <summary>
        ///  Attributs de types int permetant de décompter le nombre de lancer restant.
        /// </summary>
        private int nbDeLancerRestant;
        /// <summary>
        /// accesseur permetant de lire la liste mes3Des.
        /// </summary>
        public List<De> Mes3Des { get => mes3Des; }
        /// <summary>
        /// Constructeur par defaut.initialuse une instance de manche.
        /// 
        /// </summary>
        
        public Manche()
        {
            List<De> troisDe = new List<De>();
            De d1 = new De();
            De d2 = new De();
            De d3 = new De();
            troisDe.Add(d1);
            troisDe.Add(d2);
            troisDe.Add(d3);
            mes3Des = troisDe;
            nbDeLancerRestant = 3;
            TrierLesDes(mes3Des);
            nbDeLancerRestant -= 1;

        }
        /// <summary>
        /// fonction permetant de lancer les 3 dés de la liste mes3Des, sous conditions que la fonction Peutlancer soit vrais.
        /// réduit de 1 le nbDeLancerRestant et utilise la fonction TrierLesDes pour les récuperer dans l'ordre décroissant.
        /// </summary>
        public void LancerLes3Des()
        {
            if (PeutLancer()==true)
            {
                for (int i = 0; i < mes3Des.Count; i++)
                {
                    mes3Des[i].SeJeter();
                }
                nbDeLancerRestant -= 1;
                TrierLesDes(mes3Des);
            }
           
            
        }

        public void Lancer(int  _unDe, int _AutreDe)
        { 
            if (PeutLancer() == true)
            {
                 mes3Des[_unDe - 1].SeJeter();
                 mes3Des[_AutreDe - 1].SeJeter();


                nbDeLancerRestant -= 1;
                TrierLesDes(mes3Des);
            }



           
        }
        public void Lancer(int _unDe)
        {
            if (PeutLancer() == true)
            {
                mes3Des[_unDe-1].SeJeter();
                nbDeLancerRestant -= 1;
                TrierLesDes(mes3Des);
            }
           
        }
        private bool PeutLancer()
        {
            bool ok = false;
            if (nbDeLancerRestant<=0 )
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
            if (  SuiteGagante()==true)
            {
                ok = true;
            }
            return ok;
        }
        public bool SuiteGagante()
        {
            bool ok = false;
            if (mes3Des[0].Valeur==4 && mes3Des[1].Valeur == 2&& mes3Des[2].Valeur == 1)
            {
                ok = true;

            }
            return ok;
        }
        public string  RenvoieRepresentationDes()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return "les dés son lancer vous avez :\n dé numero 1 ["+mes3Des[0].Valeur+ "]\n dé numero 2 [" + mes3Des[1].Valeur + "]\n dé numero 3 [" + mes3Des[2].Valeur+"]" ;
        }
        private void TrierLesDes(List<De> _mesDes)
        {
            _mesDes.Sort();
            _mesDes.Reverse();

        }
        public bool FinDeManche()
        {
            bool ok = false;
            if (PeutLancer() == false)
            {
                ok = true;
            }
            return ok;

            
        }
        

    }
}