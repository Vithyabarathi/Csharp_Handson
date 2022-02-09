using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEvenNumbers
{
    class EvenNumber
    {
        public List<int> number = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void EvenNumberFinding()
        {
            var display = from numberObj in number
                         where numberObj % 2 == 0
                         select numberObj;
            foreach (var item in display)
            {
                Console.WriteLine(item);
            }
        }




    }
}
