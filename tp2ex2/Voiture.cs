using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2ex2
{
    internal class Voiture
    {
        private string _mat;
        private Position _position ;
        private string _annModel;
        private decimal _prix;
        
        public void setMatricule(string maticule)
        {
            _mat = maticule;
        }
        public void setAnneModel(string a)
        {
            _annModel = a;
        }
        public void setPrix(decimal a)
        {
            _prix = a;
        }
        public void demarrer()
        {
            try
            {
                _position = new Position()
                {
                    X = 0,
                    Y = 0
                };
                if (_position == null)
                {
                    throw new Exception(" voiture n'est pas demarree");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  : " + ex.Message);
            }


        }
        public Position GetPosition()
        {
            return _position;
        }


        public void avancer()
        {
            
            _position.Y += 10;
        }
        public void reculer()
        {
            _position.Y -= 10;
        }

    }
}
