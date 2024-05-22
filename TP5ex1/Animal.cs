using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex1
{
    internal class Animal
    {
        public Animal(string categorie)
        {
            Categorie = categorie;
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _categorie;

        public string Categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }

        private string _resultatCrier;

        public string ResultatCrier
        {
            get { return _resultatCrier; }
            set { _resultatCrier = value; }
        }

        private string _resultatManger;

        public string ResultatManger
        {
            get { return _resultatManger; }
            set { _resultatManger = value; }
        }
        public virtual void Mangere()
        {

        }

        public virtual void Criere()
        {

        }
    }
}
