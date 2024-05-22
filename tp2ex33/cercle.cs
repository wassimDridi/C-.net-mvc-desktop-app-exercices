using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2ex33
{
    internal class cercle
    {
        private Point _centre;
        private int _rayon;
        //constructeur
        public cercle() { }
        //get
        public int getRayon() { return _rayon; }
        public Point getCentre() { return _centre; }
        //set
        public void setRayon(int rayon) { _rayon = rayon; }
        public void setCentre(Point Centre) { _centre = Centre; }
        //methode dessiner
        public void dessiner(Graphics gr)
        {
            gr.DrawEllipse(Pens.Blue, new Rectangle(_centre, new Size(_rayon * 2, _rayon * 2)));
        }

        //methode Avancer Droite
        public void AvancerDroite(int distance)
        {
            _centre.X += distance;
        }
        //methode Avancer En Bas
        public void AvancerEnBas(int distance)
        {
            _centre.Y += distance;
        }
    }
}
