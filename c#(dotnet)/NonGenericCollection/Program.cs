using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonArrayList personObj = new PersonArrayList();
            PersonStackObject personStackObject = new PersonStackObject();
            PersonQueue personQueueObj = new PersonQueue();
           
            int i = 0;
            do {
                Console.WriteLine("---Select Collection To perform---");
                Console.WriteLine("1.ArrayList");
                Console.WriteLine("2.Stack");
                Console.WriteLine("3.Queue");
                Console.WriteLine("4.End");
                Console.Write("Enter Your Choice : ");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1: personObj.ArrayListFunction(); break;
                    case 2: personStackObject.StackFunction(); break;
                    case 3: personQueueObj.PersonQueueFunction(); break;
                    case 4: Console.WriteLine("Exiting..."); break;
                }


            } while (i != 4);

            Console.ReadKey();
        }
    }
}








