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

namespace tp4ex1
{
    public partial class Form1 : Form
    {
        private List<voiture> _list = new List<voiture>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                
                 voiture _voiture = new voiture(Convert.ToInt32(vposition.Value));
                _voiture.Matricule = vmatricule.Text;
                
                _list.Add(_voiture);
                afficher();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void bavancer_Click(object sender, EventArgs e)
        {
            try
            {
                
                foreach (voiture Voiture in _list)
                {
                    Voiture.avancer();
                }
                afficher();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void afficher()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
