using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideMethod
{
    class MethodHide
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }

    }
    class MyMemember : MethodHide
    {
        public new void member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
            "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }
}

