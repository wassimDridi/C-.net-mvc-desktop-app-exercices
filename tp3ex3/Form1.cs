using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3ex3
{
    public partial class Form1 : Form
    {
        private Cercle cercle;


        public Form1()
        {
            InitializeComponent();
            cercle = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal rayon = num1.Value;
            cercle = new Cercle();
            cercle.setRayon(rayon);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (cercle == null)
                {
                    throw new Exception("Le cercle n'a pas encore été créé. Veuillez d'abord créer le cercle.");
                }
                decimal rayon = num1.Value;
                cercle.setRayon(rayon);
                num2.Value = cercle.CalculerPerimetre();
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (cercle != null)
            {
                Graphics g = e.Graphics;
                decimal rayon = cercle.getRayon();
                int centerX = pictureBox1.Width / 2;
                int centerY = pictureBox1.Height / 2;
                int circleDiameter = (int)(2 * rayon);
                int x = centerX - (circleDiameter / 2);
                int y = centerY - (circleDiameter / 2);
                g.DrawEllipse(Pens.Black, x, y, circleDiameter, circleDiameter);
            }
        }
    }
}
