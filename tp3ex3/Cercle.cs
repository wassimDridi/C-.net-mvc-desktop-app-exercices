using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex3
{
    internal class Cercle
    {
        private decimal rayon;

        public void setRayon (decimal rayon)
        {
            this.rayon = rayon;
        }
        public decimal getRayon()
        {
            return rayon;
        }

        public decimal CalculerPerimetre()
        {
            return 2 * (decimal)Math.PI * rayon;
        }
    }
}
