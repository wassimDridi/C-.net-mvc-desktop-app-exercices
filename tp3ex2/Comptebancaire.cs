using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class comptebancaire
    {
        private string _Name;
        private decimal _Solde;
        public comptebancaire()
        {
            _Name = "unknown";
            _Solde = 0;
        }
        public comptebancaire(string name)
        {
            _Name = name;
        }
        public void setName(string name)
        {
            _Name = name;
        }
        public string getName()
        {
            return _Name;
        }
        public void crediter(decimal montant)
        {
            if (montant > 0)
            {
                _Solde += montant;
            }
        }
        public decimal getSolde()
        {
            return _Solde;
        }
        public override string ToString()
        {
            return _Name;
        }
        public void Debiter(decimal montant)
        {
            if (montant > _Solde)
            {
                throw new Exception("erreur");
            }
            _Solde -= montant;
        }
        public string Describe()
        {
            return "La titulaire " + _Name + " possède " + _Solde + " en DT";
        }

    }
}