using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilehandlingAssignment
{
    class NetworkFile
    {
        public void NetworkFileHandling()
        {
                FileStream fileHandling = new FileStream("D:\\DOTNET(Training)\\StudyMaterial\\networklog.txt",
                FileMode.Open, FileAccess.Read);
                StreamReader streamFile = new StreamReader(fileHandling);
                Console.WriteLine("{0,60}", "Network Details In TabularFormat");
                Console.WriteLine(" ");
                Console.WriteLine("{0,-15} {1,-12} {2,-15}  {3,-12} {4,-15} {5,-5}",
                    "Id", "Source", "Destination", "Date", "Status", "Network");
                int i = 0;

                while (streamFile.Peek() > 0)
                {
                string readFile = streamFile.ReadLine();
                if (readFile.Contains(":"))
                {
                    if (readFile.StartsWith("Date"))
                    {
                        string[] result1 = readFile.Split(':');
                        string[] date = result1[1].Split(' ');
                        Console.Write("{" + i + " ,-15}", date[0]);
                    }
                    else if (readFile.StartsWith("Network"))
                    {
                        string[] result = readFile.Split(':');
                        Console.WriteLine("{" + i + " ,-15}", result[1]);
                    }
                    else
                    {
                        string[] result = readFile.Split(':');
                        Console.Write("{" + i + " ,-15}", result[1]);
                    }

                }
            }



            /*else if (readFile.StartsWith("Date"))
            {
                 string[] result1 = readFile.Split(':');
                string[] date = result1[1].Split(' ');
                Console.Write("{" + i + " ,-15}", date[0]);
                *//*Console.Write(result1[1]);*//*

               *//* Console.Write(result1[1].Split(' '));*/

            /*Console.Write("{" + i + " ,-15}", date[0]);*/
            /*}*/
        }

    }


}
























