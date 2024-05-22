using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3ex5
{
    public partial class Form1 : Form
    {
        private List<Forme> _list = new List<Forme>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (choix.SelectedItem == null)
                {
                    throw new Exception("Veuillez sélectionner une forme.");
                }

                if (v1.Value == 0)
                {
                    throw new Exception("Veuillez saisir une longueur.");
                }

                if (choix.SelectedItem.ToString() == "Rectangle" && v2.Value == 0)
                {
                    throw new Exception("Veuillez saisir une largeur pour le rectangle.");
                }

                string selectedChoice = choix.SelectedItem.ToString();

                if (selectedChoice == "Carre")
                {
                    decimal cote = v1.Value;
                    Carre carre = new Carre(cote);
                    _list.Add(carre);
                }
                else if (selectedChoice == "Rectangle")
                {
                    decimal L = v1.Value;
                    decimal W = v2.Value;
                    Rectangle rectangle = new Rectangle(L,W);
                    _list.Add(rectangle);
                }
                else if (selectedChoice == "Cercle")
                {
                    decimal rayon = v1.Value;
                    Cercle cercle = new Cercle(rayon);
                    _list.Add(cercle);
                }
                Affichage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }
        private void Affichage()
        {
            afficher.Items.Clear();

            foreach (Forme forme in _list)
            {
                afficher.Items.Add($"{forme.GetType()}, périmètre={forme.Perimetre()}");
            }
        }

        private void choix_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void choix_SelectedValueChanged(object sender, EventArgs e)
        {
            if (choix.SelectedItem.ToString() == "Cercle")
            {
                label1.Text = "Rayon";
                v2.Hide();
                label2.Hide();
            }
            else if (choix.SelectedItem.ToString() == "Carre")
            {
                v1.Show();
                label1.Text = "Largeur";
                v2.Hide();
                label2.Hide();
            }
            else if (choix.SelectedItem.ToString() == "Rectangle")
            {
                v1.Show();
                label1.Text = "Largeur";
                v2.Show();
                label2.Show();
                label2.Text = "Longeur";

            }
        }
    }
}
