///////////////////////////////////////////////////////////
//  Piece.cs
//  Implementation of the Class Piece
//  Generated by Enterprise Architect
//  Created on:      12-juil.-2021 12:36:48
//  Original author: Stagiaire
///////////////////////////////////////////////////////////




using ClassLibraryechecs;

namespace JeuxEchecs {
	public abstract class Piece {

		private string couleur;

		private string nomPieces;
		private StruCaseCharInt saPosition;

		public Piece(string _couleur,string _nomPieces, StruCaseCharInt _saPosition)
			
		{
		

			couleur = _couleur;
			nomPieces = _nomPieces;
			saPosition = _saPosition;
			

			
		}

        public StruCaseCharInt SaPosition { get => saPosition;  }

        public abstract bool EstSurEchiquier();

		public abstract bool Manger();

		public abstract bool PeutSeDeoplacer();

		public abstract bool SeDeplacer();

		public abstract bool SeFaireManger();

	}//end Piece

}//end namespace JeuxEchecs