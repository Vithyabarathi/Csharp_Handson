using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEvenNumbers
{
    class NameCheck
    {
        public List<string> nameList = new List<string>() { "ROME","LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
           "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        public void display()
        {
            var resultName = from nameObj in nameList
                             where nameObj.StartsWith("A") && nameObj.EndsWith("M")
                             select nameObj;
            Console.WriteLine(" ");
            Console.WriteLine("The name starts with A and Ends With M ");
            Console.WriteLine(" ");
            foreach (var item in resultName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
