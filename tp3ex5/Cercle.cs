using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex5
{
    public class Cercle : Forme
    {
        private decimal _rayon;

        public Cercle(decimal rayon)
            : base("Cercle")
        {
            _rayon = rayon;
        }

        public override decimal Perimetre()
        {
            return (decimal)(2 * Math.PI * (double)_rayon);
        }
    }
}
