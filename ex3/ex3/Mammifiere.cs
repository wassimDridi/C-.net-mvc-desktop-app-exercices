using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class Mammifere: Animal
    {
        protected int _MoisAccouchement;
        public int MoisAccouchement
        {
            get { return _MoisAccouchement; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Le mois doit etre supérieur ou égal à zéro. ");
                }
                _MoisAccouchement = value;
            }
        }

        public Mammifere(String type="Mammifere"): base(type){}
        


    }
}
