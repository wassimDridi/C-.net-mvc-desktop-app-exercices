using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2ex1
{
    public class voiture
    {
        private string _mat;
        private int _position ;
        public voiture()
        {
            _position = 0;
        }
        public void setMatricule(string maticule)
        {
            _mat = maticule;
        }
        public int getPosition()
        {
            return _position;
        }
        


        public void avancer()
        {
            _position += 10;
        }
        public void reculer()
        {
            _position -= 10;
        }

        
    }
    
}
