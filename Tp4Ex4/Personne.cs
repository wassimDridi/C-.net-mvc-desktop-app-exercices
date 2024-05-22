using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex4
{
    internal class Personne
    {
        public Personne() { }

        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }
        
        
        public virtual String Afficher()
        {
            return "nom " + _nom + "prenom" + _prenom + "date naissance " + _dateNaissance;
        }
    }
}
