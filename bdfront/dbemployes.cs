using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdfront
{
    internal class dbemployes : IDbEmployes 
    {
        public void Ajouter(Employe emp)
        {
            using (StreamWriter swr = new StreamWriter(filePath, true))
            {
                swr.WriteLine($"Code={emp.Cin};Nom={emp.Nom};Prenom={emp.Prenom}");
            }
        }
        public void Supprimer(Employe emp)
        {

        }
    }
}
