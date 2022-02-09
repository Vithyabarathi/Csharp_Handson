using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestStringConcept
{
   class ReturnString
    {
       public string DisplayJoinIt(string[] inputA)
        {
            Console.WriteLine("  ");
            Console.WriteLine("---Joining Array Elements ----");
            var stringJoin = string.Join("~", inputA);
            return stringJoin;


        }
        public string StringDisplaySplitIT(string inputB)
        {
            Console.Write("Enter the position:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--String Splitting--");
            string namevalue="s";
            if (inputB.Contains("~"))
            {
                string[] names = inputB.Split('~');
                namevalue = names[size];

            }
           
            return namevalue;


        }

    }
    
}
