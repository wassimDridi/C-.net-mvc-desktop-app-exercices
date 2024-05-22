using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2ex33
{
    internal class carre
    {
        private Point _centre;
        private int _largeur;
        public carre() { }
        //get
        public int getLargeur() { return _largeur; }
        public Point getCentre() { return _centre; }
        //set
        public void setLargeur(int largeur) { _largeur = largeur; }
        public void setCentre(Point Centre) { _centre = Centre; }
        //methode dessiner
        public void dessiner(Graphics gr)
        {
            gr.DrawRectangle(Pens.Blue, new Rectangle(_centre, new Size(_largeur, _largeur)));
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
