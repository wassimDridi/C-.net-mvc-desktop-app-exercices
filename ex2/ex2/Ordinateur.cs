using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Ordinateur : Article
    {
        private String _marque;
        private int _ram;
        private int _frequance;
        public Ordinateur()
            : base("Orinateur")
        {
            
        }

        public int Frequance
        {
            get { return _frequance; }
            set { _frequance = value; }
        }


        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }


        public String Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }

        

        public override String afficherArticle()
        {
            return base.afficherArticle() + "; Fréquence: " + _frequance + "; RAM: " + _ram + "; Marque: " + _marque;
        }

      
    }
}
