




using ClassLibraryechecs;
using JeuxEchecs;
namespace JeuxEchecs {
	public class Tour : Piece {
		
		public Tour(string _couleur ,string _nomPiece,StruCaseCharInt _saPosition)
			: base(_couleur, _nomPiece, _saPosition)
		{
			

			

		}

		public override bool EstSurEchiquier(Case _uneCase)
        {
            if (this.SaPosition==_uneCase.SaPosition)
            {

            }
			

			return false;
		}

		public override bool Manger(){

			return false;
		}

		public override bool PeutSeDeoplacer(){

			return false;
		}

		public override bool SeDeplacer(){

			return false;
		}

		public override bool SeFaireManger(){

			return false;
		}

	}//end Tour

}//end namespace JeuxEchecs