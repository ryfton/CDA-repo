///////////////////////////////////////////////////////////
//  Chrysalide.cs
//  Implementation of the Class Chrysalide
//  Generated by Enterprise Architect
//  Created on:      09-juin-2021 11:30:08
//  Original author: kassim
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeLepidoptere.LesStadeEvo;

using LeLepidoptere;
namespace LeLepidoptere.LesStadeEvo {
	public class Chrysalide : StadeDEvolution {

		public Chrysalide(){

		}

	
	

		public override void SeDeplacer(){
			Console.WriteLine("Je reste accrocher");
		}
		public override StadeDEvolution ProchaintStade() => new Papillon();

	}//end Chrysalide

}//end namespace Lepidoptere