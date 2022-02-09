using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestStringConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StringArrayFUnction stringObj = new StringArrayFUnction();*/
            /*string[] input = { "one", "two", "three" };
            stringObj.JoinIt(input);

            stringObj.SplitIt("one~two~three~four~five~six");
            stringObj.Reverse("one two three");
            stringObj.PadLeft("OneTwoThree", 15, '~');
            Console.ReadLine();*/

            ReturnString strObj = new ReturnString();
            string[] inputA = { "one", "two", "three" };
            Console.WriteLine(strObj.DisplayJoinIt(inputA));

            strObj.StringDisplaySplitIT("one~two~three~four~five~six");
            Console.WriteLine(namevalue);
            Console.ReadLine();
            

        }
    }
}
