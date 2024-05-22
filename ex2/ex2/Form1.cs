using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        List<Article> ListArticle = new List<Article>();
        public Form1()
        {
            InitializeComponent();
            typeArticle.SelectedIndex = 0;
        }
       

        private void typeArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeArticle.SelectedIndex == 0) 
            {
                panelArticle.Visible = true;
                panelOrinateur.Visible = true;
                panelStylos.Visible = false;
            
            }
            if (typeArticle.SelectedIndex == 1) 
            {
                panelArticle.Visible = true;
                panelOrinateur.Visible = false;
                panelStylos.Visible = true ;
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Article r ;
                if (Code.Text == "" || designation.Text == ""|| PU.Value <= 0||TVA.Value<=0) 
                {
                    throw new Exception("Erruer"); 
                }
                if (typeArticle.Text == "Ordinateur")
                {
                    if(frequence.Value < 0||ram.Value<=0||marque.Text=="") 
                    {
                        throw new Exception("Erreur");
                    }
                    r = new Ordinateur();
                    
                    

                    ((Ordinateur)r).Frequance =(int)frequence.Value;
                    ((Ordinateur)r).Ram =(int)ram.Value;
                    ((Ordinateur)r).Marque =marque.Text;


                }
                else if (typeArticle.Text == "Stylos")
                {
                    if (couleur.Text=="" || referance.Text == "")
                    {
                        throw new Exception("Erreur");
                    }
                    r = new Stylos();
                    
                    ((Stylos)r).Couleur =couleur.Text;
                    ((Stylos)r).Referance = referance.Text;
                }
                r.Code = Code.Text;
                r.Designation = designation.Text;
                r.Tva = TVA.Value;
                r.Prixu = PU.Value;

                ListArticle.Add(r);
                afficher();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void afficher()
        {
            list.Items.Clear();
            for (int i=0 ; i <ListArticle.Count ;i++)
            {
                list.Items.Add(ListArticle[i].afficherArticle());
            }

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
