using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollection
{
    class PersonArrayList
    {
        public void ArrayListFunction()
        {
            ArrayList nameList = new ArrayList();
          
            Console.Write("Enter how many persons details to store:");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size ; i++)
            {
                Console.Write("Enter Your Name:");
                string nameEnter = Console.ReadLine();
                nameList.Add(nameEnter);
                Console.Write("Enter your age:");
                int ageEnter =Convert.ToInt32( Console.ReadLine());
                nameList.Add(ageEnter);

                
            }
            for (int j = 0; j < nameList.Count; j++)
            {
                Console.WriteLine(nameList[j] + " - " + nameList[j + 1]);
                j++;
            }




        }
    }
}
