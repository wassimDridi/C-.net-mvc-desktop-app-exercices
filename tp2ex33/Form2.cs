using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2ex33
{
    public partial class Form2 : Form
    {
        private rectangle _rectangle;

        public Form2()
        {
            InitializeComponent();
            _rectangle = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string.IsNullOrWhiteSpace()
                //Convert.ToInt32()
                if (Largeur.Value == 0 && longueur.Value == 0)
                {
                    throw new Exception("saisie  Largeur et longueur");
                }
                Point p = new Point(Convert.ToInt32(centreX.Value), Convert.ToInt32(CentreY.Value));
                _rectangle = new rectangle();
                _rectangle.setLargeur(Convert.ToInt32(Largeur.Value));
                _rectangle.setLongueur(Convert.ToInt32(longueur.Value));
                _rectangle.setCentre(p);
                Refresh();
                _rectangle.dessiner(this.CreateGraphics());
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  creer : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rectangle == null)
                {
                    throw new Exception("creer un Rectangle");
                }

                _rectangle.AvancerDroite((int)distance.Value);
                Refresh();
                _rectangle.dessiner(this.CreateGraphics());


            }
            catch (Exception ex)
            {
                MessageBox.Show("error  creer : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rectangle == null)
                {
                    throw new Exception("creer un Rectangle");
                }

                _rectangle.AvancerEnBas((int)distance.Value);
                Refresh();
                _rectangle.dessiner(this.CreateGraphics());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  creer : " + ex.Message);
            }
        }
    }
}
