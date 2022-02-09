using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
	class Laptop
	{
		public string name;
		public int price;
		public string processor;
		public string ram;
		public string harddrive;
	}
	class Hp : Laptop
	{
	public void Hpdisplay()
		{
			Console.WriteLine(name);
			Console.WriteLine(price);
			Console.WriteLine(processor);
			Console.WriteLine(name);
		}
	}

}
