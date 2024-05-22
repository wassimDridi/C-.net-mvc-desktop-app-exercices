using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex1
{
    internal class Chien: Animal, ICrier, IManger
    {
        public Chien() : base("Chien"){}
        public string Crier()
        {
            ResultatCrier = "J'aboie";
            return ResultatCrier;
        }
        public string Manger()
        {
            ResultatManger = "Je mange très vite";
            return ResultatManger;
        }
        public override void Mangere()
        {
            Manger();
        }
        public override void Criere()
        {
            Crier();
        }
    }
}
