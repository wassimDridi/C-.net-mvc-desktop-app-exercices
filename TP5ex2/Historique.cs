using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5ex2
{
    internal class Historique
    {
		private DateTime _date;

		public DateTime  Date
		{
			get { return _date; }
			set { _date = value; }
		}
		

		private string _description;

        public string Description
        {
			get { return _description; }
			set { _description = value; }
		}


	}
}
