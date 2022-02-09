using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemoHandson
{
    class UniqueElement
    {
        public void Unique()
        {
            Console.Write("Enter the size of an array : ");
            int  SizeArray = Convert.ToInt32(Console.ReadLine());
            int[] Display = new int[SizeArray];

            for (int i = 0; i < SizeArray; i++)
            {
                Console.Write("Enter the Array element" + (i + 1) + " : ");
                Display[i] = Convert.ToInt32(Console.ReadLine());
            }



            for (int i = 0; i < SizeArray; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < SizeArray; j++)
                {
                    if (Display[i] == Display[j])
                    {
                        isDuplicate = true;
                        break;
                    }

                }
                if (!isDuplicate)
                {
                    Console.WriteLine("The Unique vaule is " + Display[i]);

                }

                



            }

        }
    }
}

