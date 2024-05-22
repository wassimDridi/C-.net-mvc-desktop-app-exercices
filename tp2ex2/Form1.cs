using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2ex2
{
    public partial class Form1 : Form
    {
        private Voiture _voiture;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(m.Text) || string.IsNullOrWhiteSpace(a.Text) || string.IsNullOrWhiteSpace(p.Text))
                {
                    throw new Exception("saisir un matricule ou prix ou annee de model  pour creer un voiture");
                }
                

                _voiture = new Voiture();
                _voiture.setMatricule(m.Text);
                _voiture.setAnneModel(a.Text);
                _voiture.setPrix(p.Value);
                _voiture.demarrer();
                m.Text = "";
                a.Text = "";
                p.Value = 0;

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
                if (_voiture == null )
                {
                    throw new Exception(" creer un voiture");
                }
                _voiture.avancer();
                yi.Value = _voiture.GetPosition().Y;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error  : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_voiture == null)
                {
                    throw new Exception(" creer un voiture");
                }
                _voiture.reculer();
                yi.Value = _voiture.GetPosition().Y;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error  : " + ex.Message);
            }
        }
    }
}
