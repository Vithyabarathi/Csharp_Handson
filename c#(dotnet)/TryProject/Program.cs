﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace SchoolDays

{

    class Program

    {

        static void Main(string[] args)

        {

            string input = "hello world";



            while (input.Length > 0)

            {

                Console.Write(input[0] + " : ");

                int count = 0;

                for (int j = 0; j < input.Length; j++)

                {

                    if (input[0] == input[j])

                    {

                        count++;

                    }

                }
                
                Console.WriteLine(count);

                input = input.Replace(input[0].ToString(), string.Empty);

            }

            Console.ReadLine();

        }

    }

}