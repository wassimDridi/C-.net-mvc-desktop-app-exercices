using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5ex2;

namespace bdfront
{
    internal class dbhistorique : IHistorique
    {
        private string filePath = "fichemps.txt";

        public void AjouterHisto(Historique h)
        {
            
            using (StreamWriter swr = new StreamWriter(filePath, true))
            {
                swr.WriteLine($"Date={h.Date};Description={h.Description}");
            }
        }
    }
}
