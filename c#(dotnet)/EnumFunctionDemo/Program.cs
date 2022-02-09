using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFunctionDemo
{
    public enum Days
    {

        Monday = 1, Tuesday, wednesday, thursday, friday
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.BackgroundColor = ConsoleColor.DarkBlue;
             Console.WriteLine("VITHYABARATHI");
             Console.ReadLine();*/
            /*Days d = Days.thursday;
            Console.WriteLine(d);
            Days f = Days.wednesday;
            Console.WriteLine((int)f);

            Console.ReadLine();*/
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i);
            
            foreach (string d in Enum.GetNames(typeof(Days)))
                Console.WriteLine(d);
            Console.ReadKey();


        }

    }
}
