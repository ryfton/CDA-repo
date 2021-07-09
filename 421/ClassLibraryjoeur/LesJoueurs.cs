using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibraryjoeur
{
    [Serializable]
    public class ListedeJoueurs : List<Joueur>
    {

        private int nbjoueur;

        public int Nbjoueur { get => nbjoueur; set => nbjoueur = value; }

        public ListedeJoueurs()
        {


        }
        public bool EstDedans(Joueur _Joueur)
        {
            bool ok = false;

            
            foreach (var item in this)
            {
                if (item.Nom == _Joueur.Nom)
                {
                    ok = true;
                } 

            }
            //for (int i = 0; i < this.Count; i++)
            //{


            //    ok = this[i].Nom == _Joueur.Nom;

            //}
            return ok;

        }

        public void AjouterJoueur(Joueur _unjoueur/*string _nom,int _scores*/)
        {

            if (this.Count == 0)
            {
                this.Add(_unjoueur);
                nbjoueur++;
            }
            else
            {
                if (!this.EstDedans(_unjoueur))
                {
                    this.Add(_unjoueur);
                    nbjoueur++;
                }
                else
                {
                    for (int i = 0; i < this.Count; i++)
                    {
                        if (_unjoueur.Nom == this[i].Nom)
                        {
                            if (_unjoueur.Scores > this[i].Scores)
                            {
                                this[i] = _unjoueur;
                            }
                        }



                    }

                }


                this.Sort();
                this.Reverse();

                


                
            }

            
        }
    }

}
