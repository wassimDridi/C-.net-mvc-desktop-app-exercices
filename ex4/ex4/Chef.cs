using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class Chef : Employe
    {
        // attributs
        private string _service;

        // getters setters
        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        // Constructeur 
        public Chef()
            : base(){}

        //  Afficher
        public override String Afficher()
        {
            return base.Afficher()+" Service: "+_service;
        }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            Salaire += 150;
        }
    }
}
