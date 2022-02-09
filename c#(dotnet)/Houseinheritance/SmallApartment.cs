using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houseinheritance
{
    class SmallApartment : House
    {
        public int doorNo = 401;
        public void GetDoor()
        {
            Console.WriteLine("My Door No : " + doorNo);
        }
    }
}

