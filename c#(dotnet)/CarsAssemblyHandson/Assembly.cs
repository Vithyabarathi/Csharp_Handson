using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAssemblyHandson
{
    static class Assembly
    {
        /*•	0: 0% success rate.
•	1 to 4: 100% success rate.
•	5 to 8: 90% success rate.
•	9: 80% success rate.
•	10: 77% success rate.*/

        public static void SuccessRate(int rateUser)
        {

            if (rateUser == 0)
            {
                double rate = 0d / 100;
                Console.WriteLine("your sucees rate is: " + rate);



            }
            else if (rateUser <= 4)
            {
                double rate = 100d / 100;
                Console.WriteLine("your sucees rate is: " + rate);
            }
            else if (rateUser <= 8)
            {
                double rate = 90d / 100;
                Console.WriteLine("your sucees rate is: " + rate);
            }
            else if (rateUser == 9)
            {
                double rate = 80d / 100;
                Console.WriteLine("your sucees rate is: " + rate);
            }
            else if (rateUser == 10)
            {
                double rate = 77d / 100;
                Console.WriteLine("your sucees rate is: " + rate);
            }



        }

        public static void ProductionRatePerHour(int rateUser)
        {
            double time = rateUser * 0.9 * 221;
            Console.WriteLine("Working cars are produced per minute : " + time);
        }
        public static void WorkingItemsPerMinute(int rateUser)
        {
            double result = rateUser * 0.9 * 221;
            int carMinute = Convert.ToInt32(result) / 60;
            Console.WriteLine("working cars are produced per minute:" +carMinute);
        }
    }
}
    

