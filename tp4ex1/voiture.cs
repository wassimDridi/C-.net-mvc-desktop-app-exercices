using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4ex1
{
    internal class voiture
    {
		private string _matrivule;

		public string Matricule
		{
			get { return _matrivule; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("error matricule est vide");
				}
				_matrivule = value;
			}
		}
		private int _position;

		public int Position
		{
			get { return _position; }
			
		}
		public voiture(int position)
		{
			_position = position;
		}
        public void avancer()
		{
			_position += 10;
		}
        public void reculer()
        {
            _position -= 10;
        }
    }
}
