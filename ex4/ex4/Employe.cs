using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class Employe : Personne
    {
        //attributs
        private int _nbJoursTravailles;
        private decimal _salaireJournalier;
        private decimal _salaire;

        //getters et setters
        public int NbJoursTravailles
        {
            get { return _nbJoursTravailles; }
            set { _nbJoursTravailles = value; }
        }

        public decimal SalaireJournalier
        {
            get { return _salaireJournalier; }
            set { _salaireJournalier = value; }
        }

        public decimal Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        // Constructeur
        public Employe() : base()
        {}

        
        public override String Afficher()
        {
           return (base.Afficher()+($"Nombre de jours travaillés: {_nbJoursTravailles}Salaire journalier: {_salaireJournalier} Salaire total: {_salaire}"));
        }

        // Calculer Salaire
        public virtual void CalculerSalaire()
        {
            _salaire = _nbJoursTravailles * _salaireJournalier;
        }
    }
}
