using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    
    public class Directeur : Chef
    {
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

        public Directeur()
            : base(){}

        public override String Afficher()
        {
            return Afficher()+($" Société: {_societe}");
        }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            Salaire += _PrimeSpeciale;
        }
    }

    
}
