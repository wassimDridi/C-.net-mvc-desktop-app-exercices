using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class Animal
    {
        protected String _name, _typeanimal;
        protected decimal _prix;
        protected Animal(String typeanimal) {
            _typeanimal = typeanimal; 
        }
        public String Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentNullException("Nom invalide"); 
                }
                _name = value;
            }
        }

        public String Typeanimal { get { return _typeanimal; } }
        public decimal Prix
        {
            get { return _prix; }
            set
            {
                if (value <= 0) { throw new Exception("Prix superieur à zéro"); }
                _prix = value;
            }
        }

        public virtual void AppliquerRemise()
        {
            _prix *= 0.9m;
        }
    }
        
}
