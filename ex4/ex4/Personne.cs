using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class Personne 
    {
        // attributs
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;

        //  getters & setters
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
        // Constructeur
        public Personne(){}
        //-----------------
        public virtual String Afficher()
        {
            return($"Nom: {Nom}Prénom: {Prenom} Date de naissance: {DateNaissance}");
        }
    }
}
