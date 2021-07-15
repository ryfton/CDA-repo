




using ClassLibraryechecs;
using JeuxEchecs;
namespace JeuxEchecs
{
    public class Pion : Piece
    {
        public Pion(string _couleur, string _nomPieces, StruCaseCharInt _saPosition) 
            : base(_couleur, _nomPieces, _saPosition)
        {
        }

        public override bool EstSurEchiquier(Case _uneCase)
        {
            return false;
        }


        public override bool Manger()
        {

            return false;
        }

        public override bool PeutSeDeoplacer()
        {

            return false;
        }

        public override bool SeDeplacer()
        {

            return false;
        }

        public override bool SeFaireManger()
        {

            return false;
        }




    }//end Pion

}//end namespace JeuxEchecs
