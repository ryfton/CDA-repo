using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarPc
{
    public class PcTravail
    {
        private string nomModel;
        private int numeroSerie;

        public PcTravail()
        {
            this.nomModel = "Asus";
            this.numeroSerie = 123;

        }
        public PcTravail(string _model,int _numeroSerie)
        {
            this.nomModel = _model;
            this.numeroSerie = _numeroSerie;

        }

        public string NomModel { get => nomModel;}
        public int NumeroSerie { get => numeroSerie; }

        public void Allumer()
        {
             
        }

        public override string ToString()
        {
            return "ce pc est un "+this.nomModel+" numero de serie"+this.numeroSerie;
        }


    }

    
   
        
}
