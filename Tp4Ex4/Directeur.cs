using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex4
{
    internal class Directeur : Chef
    {
        public Directeur()
            : base() { }
        private string _societe;
        private decimal _PrimeSpeciale;

        public decimal PrimeSpeciale
        {
            get { return _PrimeSpeciale; }
            set { _PrimeSpeciale = value; }
        }


        public string Societe
        {
            get { return _societe; }
            set { _societe = value; }
        }

        

        public override String Afficher()
        {
            return Afficher() + " Société:" + _societe + " Prime Speciale " + _PrimeSpeciale;
        }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            Salaire += _PrimeSpeciale;
        }
    }
}
