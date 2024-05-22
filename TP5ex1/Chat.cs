using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex1
{
    internal class Chat : Animal, ICrier, IManger
    {
        public Chat() : base("Chat") { }
        public string Crier()
        {
            ResultatCrier = "Je miaule";
            return ResultatCrier;
        }

        public string Manger()
        {
            ResultatManger = "Je mange trop vite";
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
