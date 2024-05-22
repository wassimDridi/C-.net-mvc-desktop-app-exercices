using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2ex33
{
    internal class rectangle
    {
        private Point _centre;
        private int _largeur, _longueur;

        //constructeur
        public rectangle() { }

        public int getLargeur() { return _largeur; }
        public int getLongueur() { return _longueur; }
        public Point getCentre() { return _centre; }

        public void setLargeur(int largeur) { _largeur = largeur; }
        public void setLongueur(int longueur) { _longueur = longueur; }
        public void setCentre(Point Centre) { _centre = Centre; }

        public void dessiner(Graphics gr)
        {
            gr.DrawRectangle(Pens.Blue, new Rectangle(_centre, new Size(_largeur, _longueur)));
        }
        public void AvancerDroite(int distance)
        {
            _centre.X += distance;
        }
        public void AvancerEnBas(int distance)
        {
            _centre.Y += distance;
        }
    }
}
