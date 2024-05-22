using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex2
{
    internal interface IDbEmployes
    {
        void Ajouter(Employe emp);
        void Supprimer(Employe emp);
    }
}
