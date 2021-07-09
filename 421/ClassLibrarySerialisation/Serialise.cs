using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary
using ClassLibraryjoeur;

namespace ClassLibrarySerialisation
{
     public static class Serialise
    {
        private static string filepath = "mesJoueurs.bin";
       
     
        public static  void Sauvegarder(ListedeJoueurs joueurs)
        {

            FileStream fs = File.Create(filepath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, joueurs);
            fs.Close();

        }

    }

}
