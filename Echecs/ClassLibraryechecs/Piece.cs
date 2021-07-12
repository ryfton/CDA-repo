///////////////////////////////////////////////////////////
//  Piece.cs
//  Implementation of the Class Piece
//  Generated by Enterprise Architect
//  Created on:      12-juil.-2021 12:36:48
//  Original author: Stagiaire
///////////////////////////////////////////////////////////




namespace JeuxEchecs {
	public abstract class Piece {

		private bool couleur;
		private string nomPieces;

		public Piece(){

		}

		~Piece(){

		}

		public virtual void Dispose(){

		}

		public bool EstSurEchiquier(){

			return false;
		}

		public bool Manger(){

			return false;
		}

		public bool PeutSeDeoplacer(){

			return false;
		}

		public abstract bool SeDeplacer();

		public bool SeFaireManger(){

			return false;
		}

	}//end Piece

}//end namespace JeuxEchecs