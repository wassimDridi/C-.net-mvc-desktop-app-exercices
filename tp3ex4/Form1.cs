using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3ex4
{
    public partial class Form1 : Form
    {
        private Client client;
        private CompteBancaire compte;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = (int)num.Value;
                string nom = n.Text;
                string prenom = p.Text;
                if(numero == 0 || nom == "" || prenom == "")
                {
                    throw new Exception("Erreur lors de la création du client : ");
                }
                client = new Client();
                client.setnom(nom);
                client.setPrenom(prenom);
                client.setNumero(numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    
                    throw new Exception("Créez d'abord un client.");
                }
                compte = new CompteBancaire(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montant = m.Value;

                if (compte == null)
                {
                    throw new Exception("Créez d'abord un compte bancaire.");
                }
                if (cc.Checked)
                {
                    compte.crediter(montant);
                }
                else if (dd.Checked)
                {
                    compte.Debiter(montant);
                }
                res.Text = compte.Describe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
