using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateday = Appointment.Schedule();
            Appointment.Description(dateday);
            
         

            Console.ReadKey();
        }
    }
}
