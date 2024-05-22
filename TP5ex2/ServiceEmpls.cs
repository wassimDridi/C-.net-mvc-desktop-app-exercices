using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex2
{
    internal class ServiceEmpls
    {
        private IHistorique _histodata;
        private IDbEmployes _employesdata;

        public ServiceEmpls(IHistorique histodata, IDbEmployes employesdata)
        {
            _histodata = histodata;
            _employesdata = employesdata;
        }

        public void CreerEmployes(Employe emp)
        {
            _employesdata.Ajouter(emp);

            Historique historique = new Historique
            {
                Date = DateTime.Now,
                Description = "L'employé" + emp.Prenom + " " + emp.Nom + "a été ajouté à la date d'aujourd'hui." ;
            };
            _histodata.AjouterHisto(historique);
        }

        public void SupprimerEmployes(Employe emp)
        {
           
        }
    }
}
