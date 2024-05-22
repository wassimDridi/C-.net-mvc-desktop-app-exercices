using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5ex2
{
    public partial class Form1 : Form
    {
        private ServiceEmpls _serviceempls;
        public Form1()
        {
            _serviceempls = new ServiceEmpls(dbhisto, dbemps);

            employe unemp = new employe
            {
                Cin = "123",
                Nom = "NomTest",
                Prenom = "PrenomTest"
            };

            _serviceempls.CreerEmployes(unemp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
