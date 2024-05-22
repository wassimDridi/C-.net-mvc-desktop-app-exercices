using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    class Insecte : Animal
    {
        public decimal _nombreAiles;
        public decimal NombreAiles
        {
            get { return _nombreAiles; }
            set 
            { 
                if(value < 2) { throw new Exception("Le nombre d'ailes minimum est égal à 2"); };
                _nombreAiles = value; 
            }
        }
        public Insecte()
            : base("Insecte"){}

        //---------------------remise----------------
        public override void AppliquerRemise()
        {
            Prix = Prix * 0.8m;
        }

    }
}
