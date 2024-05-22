using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex3
{
    internal class Chien : Mammal
    {
		private String _race;
		public Chien() : base("Chien") { }
        public String Race
		{
			get { return _race; }
			set { _race = value; }
		}
        public override void AppliquerRemise()
        {
            Prix = Prix * 0.85m;
        }

    }
}
