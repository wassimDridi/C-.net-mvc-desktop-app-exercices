using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex3
{
    internal class Mammal : Animal
    {
		private int _nomberMoisAccouchement;
		public Mammal(String TypeAnimal= "Mammal") : base(TypeAnimal) { }

        public int NomberMoisAccouchement
		{
			get { return _nomberMoisAccouchement; }
			set { _nomberMoisAccouchement = value; }
		}

	}
}
