using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex3
{
    internal class Animal
    {
		private String _nom;
		private String _typeAnimal;
		private decimal _prix;
		public Animal(String typeAnimal)
		{
            _typeAnimal = typeAnimal;

        }

        public decimal Prix
		{
			get { return _prix; }
			set { _prix = value; }
		}


		public String TypeAnimal
		{
			get { return _typeAnimal; }
		}


		public String Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
        public virtual void AppliquerRemise()
        {
            _prix *= 0.9m;
        }

    }
}