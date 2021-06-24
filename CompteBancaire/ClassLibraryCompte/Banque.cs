using CompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryCompte
{
    public class Banque
    {
       private Compte[] mesComptes;
       private int nbComptes;
       private string nom;
       private string ville;

        public Banque(string _nom)
        {
            mesComptes = new Compte[10];
            
            this.nom = _nom;
            this.nbComptes = 0;



        }


        public void AjouteCompte(Compte _unCompte)
        {
            this.mesComptes[nbComptes]= _unCompte;
            this.nbComptes++;

        }
        public void AjouteCompte(uint _num, string _nom, int _solde, int _decouvertAurise)
        {
            this.mesComptes[0]=(new Compte(_num, _nom, _solde, _decouvertAurise));
            this.nbComptes++;
        }
        public Banque(string _nom,string _ville)
        {
            mesComptes = new Compte[10];
            this.nom =_nom ;
            this.ville =_ville ;

            this.nbComptes = 0;


        }
        public override string ToString()
        {
            string collectionCompte= "";
            for (int i = 0; i <this.nbComptes; i++)
            {
                collectionCompte +=this.mesComptes[i].ToString() + "\n";

                

                

            }

            return "Banque : " + this.nom + " de la ville de : " + this.ville + "\n" + "Compte : " + "\n"  + collectionCompte;


        }




    }

    
}
