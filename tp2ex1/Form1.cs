using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2ex1
{
    public partial class Form1 : Form
    {
        private voiture v;
        public Form1()
        {
            InitializeComponent();
            v = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace ( m.Text))
                {
                    throw new Exception("saisir un matricule pour creer un voiture");
                }
                v = new voiture();
                v.setMatricule(m.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("error  : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (v == null)
                {
                    throw new Exception(" creer un voiture");
                }
                v.avancer();
                p.Value = v.getPosition();

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
                if (v == null)
                {
                    throw new Exception(" creer un voiture");
                }
                v.reculer();
                p.Value = v.getPosition();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error  : " + ex.Message);
            }
        }
    }
}
