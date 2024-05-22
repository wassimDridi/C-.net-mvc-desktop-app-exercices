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
    public partial class Form3 : Form
    {
        private cercle _cercle;

        public Form3()
        {
            InitializeComponent();
            _cercle = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rayon.Value == 0)
                {
                    throw new Exception("saisie  rayon");
                }
                Point p = new Point(Convert.ToInt32(centreX.Value), Convert.ToInt32(CentreY.Value));
                _cercle = new cercle();
                _cercle.setRayon(Convert.ToInt32(rayon.Value));
                _cercle.setCentre(p);
                Refresh();
                _cercle.dessiner(this.CreateGraphics());
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
                if (_cercle == null)
                {
                    throw new Exception("creer un cercle");
                }

                _cercle.AvancerDroite((int)distance.Value);
                Refresh();
                _cercle.dessiner(this.CreateGraphics());


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
                if (_cercle == null)
                {
                    throw new Exception("creer un career");
                }

                _cercle.AvancerEnBas((int)distance.Value);
                Refresh();
                _cercle.dessiner(this.CreateGraphics());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  creer : " + ex.Message);
            }
        }
    }
}
