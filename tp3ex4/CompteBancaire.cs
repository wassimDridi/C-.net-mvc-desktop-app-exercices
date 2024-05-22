using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tp3ex4
{
    internal class CompteBancaire
    {
        private string _devise;
        private Client _titulaire;
        private decimal _Solde;

        public CompteBancaire(Client titulaire)
        {
            _titulaire = titulaire;
            _devise = "DT";
            _Solde = 0;
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
        public void Debiter(decimal montant)
        {
            if (montant > _Solde)
            {
                throw new Exception("votre solde ");
            }
            _Solde -= montant;
        }
        public string Describe()
        {
            return "La titulaire " + _titulaire.getnom() + " " + _titulaire.getPrenom() + " numéro " + _titulaire.getNumero() + " possède " + _Solde + " " + _devise;

        }

    }
}
