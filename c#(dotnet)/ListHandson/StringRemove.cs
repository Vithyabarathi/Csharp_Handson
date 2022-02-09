using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class StringRemove
    {
        public void StringRemoveOfA()
        {
            List<string> numbers = new List<string>();
            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] Element = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("enter the Array element" + (i + 1) + " : ");
                Element[i] = Console.ReadLine();
                numbers.Add(Element[i]);

            }
            
               
                
           
            foreach (var item in numbers)
            {
                if (item.Contains("a"))
                {
                    string remove = item.Replace("a", string.Empty);
                    Console.WriteLine(remove);
                }
                else
                    Console.WriteLine(item);


            }
        }
    }
}
