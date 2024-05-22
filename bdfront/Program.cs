using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdfront
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dbemployes dbemps = new dbemployes();
            dbhistorique dbhisto = new dbhistorique();

            Form1 f1 = new Form1(dbemps, dbhisto);
            Application.Run(f1);
        }
    }
}
