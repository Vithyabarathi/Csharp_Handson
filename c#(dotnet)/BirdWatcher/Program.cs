﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BirdCount.HasDayWithoutBirds());
            BirdCount.Today();
            Console.ReadLine();
        }
    }
}
