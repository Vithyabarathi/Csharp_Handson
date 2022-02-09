using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollection
{
    class PersonQueue
    {
        public void PersonQueueFunction()
        {
            Queue queueName = new Queue();
          

            Console.Write("Enter how many persons details to store:");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Your Name:");
                string nameEnter = Console.ReadLine();

                Console.Write("Enter your age:");
                int ageEnter = Convert.ToInt32(Console.ReadLine());
                queueName.Enqueue(nameEnter + " - " + ageEnter);


            }

            for (int j = 0; j < queueName.Count; j++)
            {

                Console.WriteLine(queueName.Dequeue());
                j--;

            }
        }
    }
}
