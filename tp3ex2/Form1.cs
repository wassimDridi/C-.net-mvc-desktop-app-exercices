using ex2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label hh
        }
        private comptebancaire compte;
        private void button1_Click(object sender, EventArgs e)
        {
            string n;
            n = nom.Text;
            compte = new comptebancaire(n);
            r.Text = "compte creer avec succes ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(mont.Text);
            r.Text = "";
            if (cc.Checked)
            {
                compte.crediter(montant);
            }
            else if (dd.Checked)
            {
                compte.Debiter(montant);
            }
            r.Text = compte.Describe();
        }
    }
}
