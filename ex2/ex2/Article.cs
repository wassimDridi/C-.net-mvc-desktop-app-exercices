using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Article
    {
        private String _code;
        private String _designation;
        private String _famille;
        private decimal _prixU;
        private decimal _TVA;
        protected Article(String famille)
        {
            this._famille = famille;
        }

        public decimal Tva
        {
            get { return _TVA; }
            set { _TVA = value; }
        }


        public decimal Prixu
        {
            get { return _prixU; }
            set { _prixU = value; }
        }


        public String Famille
        {
            get { return _famille; }
            set { _famille = value; }
        }


        public String Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public virtual String afficherArticle()
        {
            return _famille + "; Code: " + _code + "; Designation: " + _designation +
                "; Prix: " + _prixU + "; TVA: " + _TVA;
        }

    }
}