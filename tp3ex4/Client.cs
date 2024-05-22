using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3ex4
{
    internal class Client
    {
        //attribut
        private string _Nom;
        private int _Numero;
        private string _Prenom;
        // method 
        public void setnom(string nom)
        {  _Nom = nom; }
        public void setNumero(int n)
        { _Numero = n;}
        public void setPrenom(string p) {  _Prenom = p;}
        public string getnom() { return _Nom;}
        public int getNumero() { return _Numero; }
        public string getPrenom() {  return _Prenom;}


    }
}
