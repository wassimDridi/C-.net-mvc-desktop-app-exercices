using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Chien : Mammifere
    {
        public string _Race;
        public string Race
        {
            get { return _Race; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { 
                    throw new Exception("Race invalide"); 
                }
                _Race = value;
            }
        }
        public Chien()
            : base("Chien"){}

        //---------------------remise----------------
        public override void AppliquerRemise()
        {
            Prix = Prix * 0.85m;
        }
    }
}
