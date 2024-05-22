using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex5
{
    public class Carre : Forme
    {
        private decimal _cote;

        public Carre(decimal cote)
            : base("Carré")
        {
            _cote = cote;
        }

        public override decimal Perimetre()
        {
            return 4 * _cote;
        }
    }
}
