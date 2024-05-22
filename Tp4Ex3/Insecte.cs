using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex3
{
    internal class Insecte : Animal
    {
		private int _nomberAile;
		public Insecte(): base("Insecte"){}

		public int NomberAile
        {
			get { return _nomberAile; }
			set { _nomberAile = value; }
		}
        public override void AppliquerRemise()
        {
            Prix = Prix * 0.8m;
        }

    }
}
