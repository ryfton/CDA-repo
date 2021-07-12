




using JeuxEchecs;
namespace JeuxEchecs {
	public class Tour : Piece {

		public Tour(){

		}

		~Tour(){

		}

		public override void Dispose(){

		}

		public override bool EstSurEchiquier(){

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