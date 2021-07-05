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
        private int scoreInitial;
        private int nbMancheAjouer;
        private int scorRestant;

        public int NbMancheAjouer { get => nbMancheAjouer; }

        public MaPartie(int _nbMancheAjouer)
        {
            nbMancheAjouer = _nbMancheAjouer;
            scoreInitial = _nbMancheAjouer * 10;
            scorRestant = _nbMancheAjouer * 10;
            

        }

        public void Commencer()
        {
            Manche firstManche = new Manche();
            maMancheCourante = firstManche;
            nbMancheAjouer -= 1;

        }
        public bool MancheTerminer()
        {
            bool ok = false;
            if (maMancheCourante.FinDeManche()==true)
            {
                if (maMancheCourante.MancheGagner() == true)
                {
                    scorRestant += 30;
                }
                else
                {
                    scorRestant -= 10;

                }
                ok = true;
                
                
                
            }
            return ok;
        }
        public bool EstGagne()
        {
            bool ok=false;

            if (nbMancheAjouer <= 0 && scorRestant > 0 && maMancheCourante.FinDeManche()==true)
            {
                ok = true;

            }
            return ok;
        }

        public void LancerLes3Des()
        {
            if (EstGagne()==false && PeutJouer()==true)
            {
                maMancheCourante.LancerLes3Des();
            }
            
        }
        public void Lancer(int _unDe, int _AutreDe)
        {
            if (EstGagne() == false && PeutJouer() == true)
            {
                maMancheCourante.Lancer(_unDe, _AutreDe);
            }
           
        }
        public void Lancer(int _unDe)
        {
            if (EstGagne() == false && PeutJouer() == true)
            {
                maMancheCourante.Lancer(_unDe);
            }
            
        }
        public bool PeutJouer()
        {
            bool ok = false;
            if (nbMancheAjouer<=0 && scorRestant<=0)
            {
                ok = false;
            }
            else
            {
                ok = true;
            }
            return ok;

        }
        public override string ToString()
        {
            
            return maMancheCourante.ToString();
        }
        public int AfficherScore()
        {
            int score= scorRestant;
            return score;
        }
    }
}
