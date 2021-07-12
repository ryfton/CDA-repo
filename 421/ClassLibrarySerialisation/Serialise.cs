using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibraryjoeur;

namespace ClassLibrarySerialisation
{
     public static class Serialise
    {
        // enregistrer en dur !!! attention au repertoir choisie se diriger plutot vers un dossier apps data.
        private static string filepath = "mesJoueurs.bin";
       
     
        public static  void Sauvegarder(ListedeJoueurs joueurs)
        {

            FileStream fs = File.Create(filepath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, joueurs);
            fs.Close();

        }
        public static ListedeJoueurs Ouvrire()
        {
            //Instanciation d'une nouvelle liste de joueur.
            ListedeJoueurs joueurs = new ListedeJoueurs();

            //teste  si le fichier existe 
            if (File.Exists(filepath))
            {
                //Déclaration d'une variable FileStream
                FileStream fs = null;

                // bloc TryCatch pour gérer les erreurs a l'ouverture .
                try
                {
                    //Ouverture du fichier
                    fs = File.OpenRead(filepath);
                    // déserialiser un fichier
                    BinaryFormatter bf = new BinaryFormatter();
                    // récupère  objet
                    joueurs = (ListedeJoueurs)bf.Deserialize(fs);
                }
                catch (Exception e)
                {
                    //Affichage d'un message en cas d'erreur
                    throw e;
                }
                finally
                {
                    // erreur ou non ferme le fichier
                    //s'il a été ouvert
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

            // retour  liste
            return joueurs;
        }



    }

}
