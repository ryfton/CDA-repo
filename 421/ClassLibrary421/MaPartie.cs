using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary421
{
    public class MaPartie
    {
        private Manche maMancheCourante;
        private int ScoreInitial;
        private int nbMancheAjouer;
        private int scorCourant;

        
        public MaPartie(int _nbMancheAjouer)
        {
            nbMancheAjouer = _nbMancheAjouer;
            ScoreInitial = _nbMancheAjouer * 10;

        }

        public void Commencer()
        {
            //maMancheCourante.Commencer();
        }

        public void EstGagne()
        {
            throw new System.NotImplementedException();
        }

        public void LancerLes3Des()
        {
            throw new System.NotImplementedException();
        }
    }
}
