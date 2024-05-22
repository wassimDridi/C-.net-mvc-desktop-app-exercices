using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex4
{
    internal class Employe : Personne
    {

        public Employe() : base()
        { }

        private int _nbJoursTravailles;
        private decimal _salaireJournalier;
        private decimal _salaire;

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



        public override String Afficher()
        {
            return base.Afficher() + "Nombre de jours travaillés: "+_nbJoursTravailles +"Salaire journalier:"+_salaireJournalier +" Salaire total: "+_salaire;
        }

        public virtual void CalculerSalaire()
        {
            _salaire = _nbJoursTravailles * _salaireJournalier;
        }
    }
}
