using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex5
{
    public class Forme
    {
        protected string _typef;
        protected decimal _perimetre;

        public Forme(string typef)
        {
            _typef = typef;
        }

        public virtual decimal Perimetre()
        {
            return 0;
        }

        public string GetType()
        {
            return _typef;
        }
    }
}
