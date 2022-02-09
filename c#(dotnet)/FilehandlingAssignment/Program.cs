using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilehandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkFile networkobj = new NetworkFile();
            networkobj.NetworkFileHandling();
            Console.ReadKey();



        }
    }
}
