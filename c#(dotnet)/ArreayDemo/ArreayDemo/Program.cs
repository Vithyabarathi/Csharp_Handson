using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sum = new int[5];
            int result = 0;
            for(int i=0; i<5; i++)
            {
                Console.Write("Enter the array element : ");
                result = result + sum[i];
                Console.WriteLine("sum is" + result);
            }
        }
    }
}



//int a;
//Console.WriteLine("Enter size of index:");
//a = int.Parse(Console.ReadLine());
//int[] index = new int[a];
//for (int i = 0; i < index.Length; i++)
//{
//    Console.WriteLine("Enter number:");
//    index[i] = int.Parse(Console.ReadLine());
//}
