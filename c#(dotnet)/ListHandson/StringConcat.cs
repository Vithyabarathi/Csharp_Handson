using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class StringConcat
    {
       public void StringConcatination()
        {
            List<int> numbers = new List<int>();
            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Element = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the Array element" + (i + 1) + " : ");
                Element[i] = Convert.ToInt32(Console.ReadLine());
                numbers.Add(Element[i]);

            }
            foreach (var item in numbers)
            {
                var display = Convert.ToString(item);
                Console.WriteLine(display + display + display + display);

            }
        }
    }
}
