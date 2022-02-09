using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMockTest
{
    class StringArray
    {

        public void ArrayFunction()
        {
            Console.Write("Enter how many elements to store in array:");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] nameArray = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter the element " + (i + 1) + ":");
                nameArray[i] = Console.ReadLine();

            }
            var stringJoin = string.Join("~", nameArray);
            Console.WriteLine("Joining of array: " + stringJoin);
            Console.WriteLine("  ");
            Console.WriteLine("----Spliting the array based on Index-----");
            Console.WriteLine("  ");
            Console.Write("Enter the size to split : ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nameArray.Length; i++)
            {
                if (i == size)
                {
                    Console.WriteLine(nameArray[i]);
                }
            }

            Console.WriteLine("  ");
            Console.WriteLine(" ---Reversing the array Elements---  ");
            Console.WriteLine("  ");
            Array.Reverse(nameArray);
            foreach (var item in nameArray)
            {
                Console.Write(item + " ");
                
            }
        }

        public void PadLeft(string name, int n, char a)
        {
            Console.WriteLine("  ");
            Console.WriteLine(" --Padding ToLeft---  ");
            Console.WriteLine("  ");
            Console.WriteLine(name.PadLeft(n, a));
        }



    }
}
















