using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
	class Program
	{
		static void Main(string[] args)
		{
			Hp hpobject = new Hp();
			hpobject.name = "Hp ZBook";
			hpobject.price = 60000;
			hpobject.ram  = "16GB";

			hpobject.Hpdisplay();

		}
	}
}
