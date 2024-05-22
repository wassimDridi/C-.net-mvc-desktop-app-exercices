using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Stylos:Article
    {

        
        private String _referance;
        private String _couleur;
        public Stylos()
            : base("Stylos")
        {

        }

        public String Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }


        public String Referance
        {
            get { return _referance; }
            set { _referance = value; }
        }

        

        public override String afficherArticle()
        {
            return base.afficherArticle() + "; Referance: " + _referance +"; Couleur: " + _couleur;
        }

        
    }
}
