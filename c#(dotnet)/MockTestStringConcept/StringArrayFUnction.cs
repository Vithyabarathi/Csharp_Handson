using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestStringConcept
{
    class StringArrayFUnction
    {
        public void JoinIt(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Array Elements are  "  + (i + 1)  +  " : "   + input[i]);

            }
            var stringJoin = string.Join("~", input);
            Console.WriteLine("  ");
            Console.WriteLine("---Joining Array Elements ----");
            Console.WriteLine(stringJoin);
        }









        public void SplitIt(string inputName)
        {
            Console.Write("Enter the position:");
            int size = Convert.ToInt32(Console.ReadLine());
            if (inputName.Contains("~"))
            {
                string[] names = inputName.Split('~');
                Console.WriteLine("  ");
                Console.WriteLine("--String Splitting--");
                Console.WriteLine(names[size]);
                Console.WriteLine("---------------------------------");
            }

        }







        public void Reverse(string input)
        {
            string[] myString = input.Split(' ');
            Array.Reverse(myString);
            Console.WriteLine("Reversing the string");
            foreach (var item in myString)
            {

                Console.Write(item + " ");
            }
            Console.WriteLine("  ");
        }








        public void PadLeft(string name, int n, char a)
        {
            Console.WriteLine("  ");
            Console.WriteLine(" --Padding ToLeft---  ");

            Console.WriteLine(name.PadLeft(n, a));
        }
    }
}













