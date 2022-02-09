using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAssemblyHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sucess rate from 0 to 10 :");
            int rateUser = Convert.ToInt32(Console.ReadLine());
            Assembly.SuccessRate(rateUser);
            Assembly.ProductionRatePerHour(rateUser);
            Assembly.WorkingItemsPerMinute(rateUser);
            Console.ReadKey();
        }
    }
}
