using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryjoeur
{
    [Serializable]
    public class Joueur: IComparable<Joueur>, IComparable
    {
        private int scores;
        private string nom;

        
        
        public int Scores { get => scores;  }
        public string Nom { get => nom; set => nom = value; }

        public Joueur(int _scores, string _nom)
        {
            this.scores = _scores;
            this.nom = _nom;
        }
        public Joueur()
        {
            scores = 0;
            nom = "Joueur 1";
        }
        public int CompareTo(Joueur other)
        {
            //if (this.scores < other.scores)
            //{
            //    return -1;
            //}
            //else if (this.scores == other.scores)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
            return this.scores.CompareTo(other.scores);

        }
        public int CompareTo(object obj)
        {
            Joueur kl = obj as Joueur;
            
            // if (this== obj)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
            return this.scores.CompareTo(kl.scores);
        }


    }
    
}
