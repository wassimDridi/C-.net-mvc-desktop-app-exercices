using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp4Ex4
{
    public partial class Form1 : Form
    {
        List<Personne> _personnes = new List<Personne>();
        public Form1()
        {
            InitializeComponent();
            typePerssone.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // panelEmploye panelChef panelDirecteur
            if (typePerssone.SelectedIndex == 0)
            {
                panelEmploye.Visible = true;
                panelChef.Visible = false;
                panelDirecteur.Visible = false;
            }
            else if (typePerssone.SelectedIndex == 1)
            {
                panelEmploye.Visible = true;
                panelChef.Visible = true;
                panelDirecteur.Visible = false;
            }
            if (typePerssone.SelectedIndex == 2)
            {
                panelEmploye.Visible = true;
                panelChef.Visible = true;
                panelDirecteur.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personne p = null;
                if (string.IsNullOrWhiteSpace(textN.Text))
                {
                    throw new Exception("Nom invalide");
                }
                if (string.IsNullOrWhiteSpace(textP.Text))
                {
                    throw new Exception("Prenom invalide");
                }
                if (typePerssone.SelectedIndex == 0)
                {
                    if (nbJour.Value < 0)
                    {
                        throw new Exception("Le nbJour doit etre supérieur ou égal à zéro. ");
                    }
                    if (SalaireJ.Value < 0)
                    {
                        throw new Exception("Le SalaireJ doit etre supérieur ou égal à zéro. ");
                    }

                    Employe emp = new Employe();
                    emp.NbJoursTravailles = Convert.ToInt32(nbJour.Value);
                    emp.SalaireJournalier = Convert.ToInt32(SalaireJ.Value);
                    p = emp;
                }
                if (typePerssone.SelectedIndex == 1)
                {
                    if (string.IsNullOrWhiteSpace(textService.Text))
                    {
                        throw new Exception("service invalide");
                    }
                    Chef c = new Chef();
                    c.Service = textService.Text;
                    p = c;
                }
                if (typePerssone.SelectedIndex == 2)
                {
                    if (Primee.Value < 0)
                    {
                        throw new Exception("Le Primee doit etre supérieur ou égal à zéro. ");
                    }
                    if (string.IsNullOrWhiteSpace(socit.Text))
                    {
                        throw new Exception("Societe invalide");
                    }


                    Directeur d = new Directeur();
                    d.PrimeSpeciale = Convert.ToInt32(Primee.Value);
                    d.Societe = socit.Text;
                    p = d;
                }
                p.Nom = textN.Text;
                p.Prenom = textP.Text;
                
                DateTime datena = dateNais.Value;
                p.DateNaissance = datena;

                _personnes.Add(p);
                Affichage();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Employe personne in _personnes)
            {
                personne.CalculerSalaire();
            }
            Affichage();
        }
        private void Affichage()
        {
            try
            {
                listBox1.Items.Clear();

                foreach (Employe personne in _personnes)
                {
                    listBox1.Items.Add(personne.Afficher());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
