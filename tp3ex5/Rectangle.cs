using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex5
{
    public class Rectangle : Forme
    {
        private decimal _Longueur, _largeur;

        public Rectangle(decimal Longueur, decimal largeur)
            : base("Rectangle")
        {
            _Longueur = Longueur;
            _largeur = largeur;
        }

        public override decimal Perimetre()
        {
            return 2 * (_Longueur + _largeur);
        }
    }
}
