using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{


    class FileClass
    {
        public void FileHandling()
        {


            FileStream FsObj = new FileStream("D:\\Dotnetprogram\\program.txt", FileMode.Create, FileAccess.Write);
            StreamWriter StWriterObj = new StreamWriter(FsObj);

            Console.Write("Enter the count of the data:");
            int count = Convert.ToInt32(Console.ReadLine());
    
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter the ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Source:");
                int source = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Desgination:");
                int desg = Convert.ToInt32(Console.ReadLine());
                DateTime dtime = new DateTime();
                
               /* Console.Write("Enter the date and time:");
                 string date = Console.ReadLine();*/
                Console.Write("Enter the status:");
                string status = Console.ReadLine();
                Console.Write("Enter the Network:");
                string network = Console.ReadLine();
                Console.WriteLine(" ");



                StWriterObj.WriteLine("Id : " + id);
                StWriterObj.WriteLine("source  : " + source);
                StWriterObj.WriteLine("Desigination " + desg);
                StWriterObj.WriteLine("Date and Time  : " + dtime);
                // StWriterObj.WriteLine("Date and Time  : " + date);
                StWriterObj.WriteLine("Status : " + status);
                StWriterObj.WriteLine("Network : " + network);
                StWriterObj.WriteLine(" ");
            }
                StWriterObj.Close();
                FsObj.Close();

        }
    }
}
