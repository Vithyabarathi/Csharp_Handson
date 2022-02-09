using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemoHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySum aobject = new ArraySum();
            Count cobject = new Count();
            UniqueElement uobject = new UniqueElement();
            MinimumMaximum minobject = new MinimumMaximum();
            int i;
            do
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1.Sum of Array elements");
                Console.WriteLine("2.To find the Duplicate of Array elements");
                Console.WriteLine("3.To find the Unique of Array elements");
                Console.WriteLine("4.To find MinMax of Array elements");
                Console.WriteLine("5.Exit");
                Console.Write("Enter Your Choice : ");
                i = Convert.ToInt32(Console.ReadLine());



                switch (i)
                {
                    case 1: aobject.SumArray(); ; break;
                    case 2: cobject.DuplicateCount(); ; break;
                    case 3: uobject.Unique(); break;
                    case 4: minobject.MinMax(); break;
                    case 5: Console.WriteLine("Exiting..."); break;
                }



            } while (i != 5);
         Console.ReadKey();
        }

    }
}

