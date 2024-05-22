using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex1
{
    internal class Cheval : Animal, ICrier, IManger
    {
        public Cheval() : base("Cheval") { }
        public string Crier()
        {
            ResultatCrier = "J'ébroue";
            return ResultatCrier;
        }
        public string Manger()
        {
            ResultatManger = "Je mange comme un cheval";
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
