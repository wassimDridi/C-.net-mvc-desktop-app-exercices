using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex6
{
    internal class employe
    {
		public employe(decimal vsalaire)
		{
			salaire = vsalaire;
		}
        private int _code;

		public int Code
		{
			get { return _code; }
			set { _code = value; }
		}
		private decimal salaire;

		public decimal Salaire
		{
			get { return salaire; }
		}


		private string nom;

		public string Nom
		{
			get { return nom; }
			set { nom = value; }
		}
		private string prebom;

		public string Prenom
		{
			get { return prebom; }
			set { prebom = value; }
		}
		public decimal calculerSalaire()
		{
			return salaire;
		}


	}
}
