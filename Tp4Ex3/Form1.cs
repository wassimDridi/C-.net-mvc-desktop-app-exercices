using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp4Ex3
{
    public partial class Form1 : Form
    {
        List<Animal> _animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            TypeAnimal.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelMammal panelChien  panelInsecte
            if (TypeAnimal.SelectedIndex == 0)
            {
                panelMammal.Visible = true;
                panelChien.Visible = false;
                panelInsecte.Visible = false;
                panelMammal.Location = new Point(GeneralPanel.Right, GeneralPanel.Top);
            }
            else if (TypeAnimal.SelectedIndex == 1)
            {
                panelMammal.Visible = true;
                panelChien.Visible = true;
                panelInsecte.Visible = false;
                panelChien.Location = new Point(panelMammal.Right, panelMammal.Top);
            }
            if (TypeAnimal.SelectedIndex == 2)
            {
                panelMammal.Visible = false;
                panelInsecte.Visible = true;
                panelChien.Visible = false;
                panelInsecte.Location = new Point(GeneralPanel.Right, GeneralPanel.Top);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;
                if (string.IsNullOrWhiteSpace(textNom.Text))
                {
                    throw new Exception("Nom invalide");
                }
                if (numericPrix.Value <= 0) { throw new Exception("Prix superieur à zéro"); }
                
                if (TypeAnimal.SelectedIndex == 0)
                {
                    if (numericNbMois.Value < 0)
                    {
                        throw new Exception("Le mois doit etre supérieur ou égal à zéro. ");
                    }
                    animal = new Mammal();
                    ((Mammal)animal).NomberMoisAccouchement = (int) numericNbMois.Value;
                }
                else if (TypeAnimal.SelectedIndex == 1)
                {
                    if (numericNbMois.Value < 0)
                    {
                        throw new Exception("Le mois doit etre supérieur ou égal à zéro. ");
                    }
                    if (string.IsNullOrWhiteSpace(textRace.Text))
                    {
                        throw new Exception("Race invalide");
                    }
                    Chien ch = new Chien();
                    ch.Race = textRace.Text;
                    ch.NomberMoisAccouchement = Convert.ToInt32( numericNbMois.Value);
                    animal = ch;
                }
                else if (TypeAnimal.SelectedIndex == 2)
                {
                    if (numericAiles.Value < 2) 
                    { throw new Exception("Le nombre d'ailes minimum est égal à 2");
                    };
                    Insecte insect = new Insecte() ;
                    
                    insect.NomberAile = (int)numericAiles.Value;
                    animal = insect;
                }
                animal.Nom = textNom.Text;
                animal.Prix = numericPrix.Value;
                _animals.Add(animal);
                affichage();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Animal a in _animals)
            {
                a.AppliquerRemise();
            }
            affichage();
        }
        private void affichage()
        {
            DataTable animauxdt = new DataTable();
            animauxdt.Columns.Add("Nom");
            animauxdt.Columns.Add("type");
            animauxdt.Columns.Add("Prix");
            foreach (Animal a in _animals)
            {
                DataRow dr = animauxdt.NewRow();
                dr["Nom"] = a.Nom;
                dr["type"] = a.TypeAnimal;
                dr["Prix"] = a.Prix;
                animauxdt.Rows.Add(dr);
            }
            dataGrid.DataSource = animauxdt;

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
