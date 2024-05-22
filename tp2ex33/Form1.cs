using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace tp2ex33
{
    public partial class Form1 : Form
    {
        private carre _carre;

        public Form1()
        {
            InitializeComponent();
            _carre = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string.IsNullOrWhiteSpace()
                //Convert.ToInt32()
                if (Largeur.Value == 0)
                {
                    throw new Exception("saisie  Largeur");
                }
                Point p = new Point(Convert.ToInt32(centreX.Value), Convert.ToInt32(CentreY.Value));
                _carre = new carre();
                int l = Convert.ToInt32(Largeur.Value);
                _carre.setLargeur(l);
                _carre.setCentre(p);
                Refresh();
                _carre.dessiner(this.CreateGraphics());
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
                if (_carre == null)
                {
                    throw new Exception("creer un career");
                }

                _carre.AvancerDroite((int)distance.Value);
                Refresh();
                _carre.dessiner(this.CreateGraphics());


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
                if (_carre == null)
                {
                    throw new Exception("creer un career");
                }

                _carre.AvancerEnBas((int)distance.Value);
                Refresh();
                _carre.dessiner(this.CreateGraphics());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  creer : " + ex.Message);
            }
        }
    }
}
