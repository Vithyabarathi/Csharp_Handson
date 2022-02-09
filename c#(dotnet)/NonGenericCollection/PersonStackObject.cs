using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollection
{
    class PersonStackObject
    {
        public void StackFunction()
        {
            Stack  stackList = new Stack();
  
            Console.Write("Enter how many persons details to store:");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Your Name:");
                string nameEnter = Console.ReadLine();
                
                Console.Write("Enter your age:");
                int ageEnter = Convert.ToInt32(Console.ReadLine());
                stackList.Push(nameEnter + " - " +ageEnter);


            }
            /*for (int j = 0; j < stackList.Count; j++)
            {
               
                Console.WriteLine(stackList.Pop());
                j--;

            }
            
*/
            foreach (string display in stackList)
            {
                Console.WriteLine(display);
            }
        }
    }
}
