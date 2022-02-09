using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{  /* Implement the BirdCount.Today() method to return how many birds visited your garden today. 
    * The bird counts are ordered by day, with the first element being the count of the oldest day,
    * and the last element being today's count.
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.Today();
// => 1
*/
    static class BirdCount
    { 
        static int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
       
        public static void Today()  // task 2
        {
            int size = birdsPerDay.Length;
            Console.WriteLine(birdsPerDay[size - 1]);

        }
        public static void IncrementTodaysCount() { }
      public   static bool HasDayWithoutBirds()
        { // task 4
           
            int count = 0;
            foreach (int item in birdsPerDay)
            {
                if(item == 0)
                {
                    count++; 
                }
               
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
