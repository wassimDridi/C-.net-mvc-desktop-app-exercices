using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5ex1
{
    public partial class Form1 : Form
    {
        private List<Animal> animaux = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            typeAnimal.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a = null;
                if (string.IsNullOrWhiteSpace(name.Text))
                {
                    throw new Exception("Nom invalide");
                }
                
                if (typeAnimal.SelectedIndex == 0)
                {


                    Chien ch = new Chien();
                    
                    a = ch;
                }
                if (typeAnimal.SelectedIndex == 1)
                {

                    Chat c = new Chat();
                    
                    a = c;
                }
                if (typeAnimal.SelectedIndex == 2)
                {



                    Cheval c = new Cheval();
                    a = c;
                }

                a.Nom = name.Text;
                animaux.Add(a);
                AfficherAnimaux();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var animal in animaux)
            {
                animal.Criere();
            }
            AfficherAnimaux();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var animal in animaux)
            {
                animal.Mangere();
            }
            AfficherAnimaux();
        }
        private void AfficherAnimaux()
        {
            DataTable animauxdt = new DataTable();
            animauxdt.Columns.Add("Nom");
            animauxdt.Columns.Add("Categorie");
            animauxdt.Columns.Add("ResultatCrier");
            animauxdt.Columns.Add("ResultatManger");

            foreach (Animal a in animaux)
            {
                DataRow dr = animauxdt.NewRow();
                dr["Nom"] = a.Nom;
                dr["Categorie"] = a.Categorie;
                dr["ResultatCrier"] = a.ResultatCrier;
                dr["ResultatManger"] = a.ResultatManger;
                animauxdt.Rows.Add(dr);
            }

            dataGridView1.DataSource = animauxdt;

        }
    }
}
