using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMockTest
{
    class Program
    {
        static void Main(string[] args)
        {

            StringArray stringObj = new StringArray();
            stringObj.ArrayFunction();
            stringObj.PadLeft("OneTwoThree", 15, '~');

            


            Console.ReadLine();
        }
    }
}
