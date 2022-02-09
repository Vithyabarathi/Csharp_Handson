using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EvenNumber evenObject = new EvenNumber();
            evenObject.EvenNumberFinding();*/
           Console.Write("Input starting character for the string :") ;
            string firstLetter = Console.ReadLine();
            Console.Write("Input ending character for the string : ");
            string secondLetter = Console.ReadLine();

            NameCheck nameCheckObj = new NameCheck();
            nameCheckObj.display();
            Console.ReadLine();
        }    
           
    }
}
