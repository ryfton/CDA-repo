///////////////////////////////////////////////////////////
//  Roi.cs
//  Implementation of the Class Roi
//  Generated by Enterprise Architect
//  Created on:      12-juil.-2021 12:36:52
//  Original author: Stagiaire
///////////////////////////////////////////////////////////




using JeuxEchecs;
namespace JeuxEchecs {
	public class Roi : Piece {

		public Roi(){

		}

		~Roi(){

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

	}//end Roi

}//end namespace JeuxEchecs