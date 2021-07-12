using ClassLibraryjoeur;
using ClassLibrarySerialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeSerialisation
{
    [Serializable]
    class Serial
    {
        static void Main(string[] args)
        {
            int nbJoueur=0;
            Joueur[] lesDixPremier = new Joueur[10];
            Joueur j1, j2, j3, j4, j5, j6;
            ListedeJoueurs joueursTes = new ListedeJoueurs();
            joueursTes.AjouterJoueur(j1 = new Joueur(10, "Dell"));
            joueursTes.AjouterJoueur(j2 = new Joueur(150, "Dell"));
            joueursTes.AjouterJoueur(j3 = new Joueur(105, "asul"));
            joueursTes.AjouterJoueur(j4 = new Joueur(190, "Dafeli"));
            joueursTes.AjouterJoueur(j5 = new Joueur(210, "Dulop"));
            joueursTes.AjouterJoueur(j6 = new Joueur(160, "asul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(140, "aslul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(143, "ajsul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(140, "askul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(140, "a,sul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(1440, "asxgul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(149, "asvul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(150, "awsul"));
            joueursTes.AjouterJoueur(j6 = new Joueur(240, "asual"));
            int ct = 0;
            while (ct <= 9)
            {
                lesDixPremier[ct] = joueursTes[ct];
                ct++;
            }
            //for (int i = 0; i < joueursTes.Nbjoueur; i++)
            //{
            //    if ()
            //    {
            //        lesDixPremier[i] = joueursTes[i];

            //    }
                
            //}

            for (int i = 0; i < ct; i++)
            {
                Console.WriteLine("Joueur : "+ lesDixPremier[i].Nom+".  score : "+ lesDixPremier[i].Scores);
            }
            Serialise.Sauvegarder(joueursTes);
            ListedeJoueurs recuperationJoueur =Serialise.Ouvrire();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < ct; i++)
            {
                Console.WriteLine("Joueur : " + recuperationJoueur[i].Nom + ".  score : " + recuperationJoueur[i].Scores);
            }

            Console.ReadKey();
        }
    }
}
