///////////////////////////////////////////////////////////
//  Case.cs
//  Implementation of the Class Dame
//  Generated by Enterprise Architect
//  Created on:      12-juil.-2021 12:36:51
//  Original author: Stagiaire
///////////////////////////////////////////////////////////









using ClassLibraryechecs;
using System.Collections.Generic;

namespace JeuxEchecs {
	public class Case {

		private string saCouleur;
		private StruCaseCharInt SaPosition;

		public Case(StruCaseCharInt _caseCharInt, string _couleur)
		{
			saCouleur = _couleur;
			SaPosition = _caseCharInt;

		}

        

        public bool EstLibre(Piece _unepiece){
			bool ok = false;
            if (this.SaPosition==_unepiece.SaPosition)
            {
				ok = false;
            }
            else
            {
				ok = true;
            }

			return ok;
		}

		public bool EstPleine(){

			return false;
		}

	}//end Case

}//end namespace JeuxEchecs