using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Ex4
{
    internal class Chef : Employe
    {
        public Chef()
            : base() { }
        private string _service;

        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        public override String Afficher()
        {
            return base.Afficher() + " Service: " + _service;
        }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            Salaire += 150;
        }
    }
}
