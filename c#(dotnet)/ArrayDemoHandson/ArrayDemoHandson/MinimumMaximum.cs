using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemoHandson
{
    class MinimumMaximum
    {
        public void MinMax()
        {
            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Element = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the Array element" + (i + 1) + " : ");
                Element[i] = Convert.ToInt32(Console.ReadLine());

            }
            int minimum, maximum;
            minimum = Element[0];
            maximum = Element[0];
            for (int i = 1; i < Element.Length; i++)
            {
                if (maximum < Element[i])
                    maximum = Element[i];
                if (minimum > Element[i])
                    minimum = Element[i];
            }
            
            Console.WriteLine(" Maximum Number " + maximum);
            Console.WriteLine("Minimum Number:" + minimum);
            Console.ReadKey();
        }

    }
}
