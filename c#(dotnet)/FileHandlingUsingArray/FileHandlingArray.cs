using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingUsingArray
{
    class FileHandlingArray
    {
        public void HandlingArray()
        {
            FileStream fileHandling = new FileStream("D:\\DOTNET(Training)\\StudyMaterial\\networklog.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader streamFile = new StreamReader(fileHandling);
            Console.WriteLine("{0,60}", "Network Details In TabularFormat");
            Console.WriteLine(" ");
            Console.WriteLine("{0,-15} {1,-12} {2,-15}  {3,-12} {4,-15} {5,-5}",
                "Id", "Source", "Destination", "Date", "Status", "Network");
           
            string[] idArray = new string[15];
            string[] sourceArraya = new string[15];
            string[] desArray = new string[15];
            string[] dateArray = new string[15];
            string[] statusArray = new string[15];
            string[] networkArray = new string[15];
            int s = 0;
            int i = 0;
            while (streamFile.Peek() > 0)
            {
                string arrayReadFile = streamFile.ReadLine();
                if (arrayReadFile.Contains(":"))
                {
                    if (arrayReadFile.StartsWith("Id"))
                    {
                        string[] id = arrayReadFile.Split(':');
                        idArray[i] = id[1];

                    }
                    else if (arrayReadFile.StartsWith("Source"))
                    {
                        string[] source = arrayReadFile.Split(':');
                        sourceArraya[i] = source[1];
                    }
                    else if (arrayReadFile.StartsWith("Destination"))
                    {
                        string[] destination = arrayReadFile.Split(':');
                        desArray[i] = destination[1];
                    }
                    
                    else if (arrayReadFile.StartsWith("Date"))
                    {
                        string[] date = arrayReadFile.Split(':');
                        string[] dateA = date[1].Split(' ');
                        dateArray[i] = dateA[0];
                    }
                    else if (arrayReadFile.StartsWith("Status"))
                    {
                        string[] status = arrayReadFile.Split(':');
                        statusArray[i] = status[1];
                    }
                    else if (arrayReadFile.StartsWith("Network"))
                    {
                        string[] network = arrayReadFile.Split(':');
                        networkArray[i] = network[1];
                        i++;
                    }

                }
            }
            for (int j = 0; j < 12; j++)
            {
                Console.Write("{" + s + " ,-15}", idArray[j]);
                Console.Write("{" + s + " ,-15}", sourceArraya[j]);
                Console.Write("{" + s + " ,-15}", desArray[j]);
                Console.Write("{" + s + " ,-15}", dateArray[j]);
                Console.Write("{" + s + " ,-15}", statusArray[j]);
                Console.WriteLine("{" + s + " ,-15}", networkArray[j]);
            }

        }
    }

}

