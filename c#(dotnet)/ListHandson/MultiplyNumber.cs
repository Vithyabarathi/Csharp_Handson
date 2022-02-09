using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class MultiplyNumber
    {
        public void MultiplicationNumber()
        {
           /* Console.Write("Enter the Integer Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result;
            if (number > 0)
            {
                number = number + 2;
                result = number * 5;
                Console.WriteLine("The result is" + result);
            }*/
            List<int> numbers = new List<int>();
            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Element = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the Array element" + (i + 1) + " : ");
                Element[i] =(Console.ReadLine());
                numbers.Add(Element[i] + 2);
                
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item * 5);
            }

        }
    }
}







