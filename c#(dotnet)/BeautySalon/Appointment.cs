using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{

    static class Appointment
    {

        static List<DateTime> dateValue = new List<DateTime>();

        public static DateTime Schedule()
        {
        
            Console.Write("Enter Your appointment date:");
            DateTime dateuser = new DateTime();
            dateuser = Convert.ToDateTime(Console.ReadLine());
            return dateuser;

        }
        public static Boolean HasPassed( DateTime user)
        {
            dateValue.Add(user);
            return true;
        }
        

   
        public static Boolean  IsAfternoonAppointment(DateTime user)
        {
            string userDate = user.ToString("tt");
            if (userDate == "PM")
            
                return true;
            
            else
                return false;
         

        }
        public static void Description(DateTime user)
        {
            DateTime saveDate = user;
            if (HasPassed(saveDate) && IsAfternoonAppointment(saveDate))
            {
                Console.WriteLine("your Appointment date is " + saveDate);
            }
            else
            {
                Console.WriteLine("Soory, book another date");
            }

            AnniversaryDate(saveDate);
        }
        public static void AnniversaryDate(DateTime user)
        {
            string saveMonth = user.ToString("M");
          /*  Console.WriteLine(saveMonth);*/
          if(saveMonth== "15 September")
            {
                Console.WriteLine(" This is anniversary date, which is 15th September ");
            }
        }
    }
}











    

