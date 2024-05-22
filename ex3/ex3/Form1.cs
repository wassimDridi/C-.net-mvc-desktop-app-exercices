using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            TypeAnimal.SelectedIndex = 0;
        }
        
        
        

        private void TypeAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeAnimal.SelectedIndex == 0)
            {
                panelMammifere.Visible = true;
                panelChien.Visible = false;
                panelInsecte.Visible = false;
                panelMammifere.Location = new Point(GeneralPanel.Right, GeneralPanel.Top);
            }
            else if (TypeAnimal.SelectedIndex == 1)
            {   
                panelMammifere.Visible = true;
                panelChien.Visible = true;
                panelInsecte.Visible = false;
                panelChien.Location = new Point(panelMammifere.Right, panelMammifere.Top);
            }
            if (TypeAnimal.SelectedIndex == 2) {
                panelMammifere.Visible= false;
                panelInsecte.Visible = true;
                panelChien.Visible = false;
                panelInsecte.Location = new Point(GeneralPanel.Right, GeneralPanel.Top);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a=null;
                if (TypeAnimal.SelectedIndex == 0)
                {
                    Mammifere mf = new Mammifere();
                    mf.MoisAccouchement = (int)MoisDaccouchement.Value;
                    a=mf;
                }
                else if (TypeAnimal.SelectedIndex == 1)
                {
                    Chien ch = new Chien();
                    ch.Race = Race.Text;
                    ch.MoisAccouchement =(int) MoisDaccouchement.Value;
                    a= ch;  
                }
                else if(TypeAnimal.SelectedIndex == 2)
                {
                    Insecte In = new Insecte();
                    In.NombreAiles = NombreAailes.Value;
                    a= In;
                }
                a.Name = Nom.Text;
                a.Prix = prix.Value;
                animals.Add(a);
                affichage();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AppliqueRemise_Click(object sender, EventArgs e)
        {
            foreach (Animal a in animals)
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
            foreach(Animal a in animals) 
            {
                DataRow dr = animauxdt.NewRow();
                dr["Nom"] = a.Name;
                dr["type"] = a.Typeanimal;
                dr["Prix"] = a.Prix;
                animauxdt.Rows.Add(dr);
            }
            DataGrid.DataSource = animauxdt;
            
        }

        private void panelMammifere_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
