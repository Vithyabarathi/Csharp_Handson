using System;

namespace StructDemo 
{
    struct StudentDetails
    {
        public int id;
        public string name;
        public string address;
    };
      
        
    

    public class testStructure
    {
        public static void Main(string[] args)
        {
            StudentDetails student1;  /* Declare student1 of type StudentDetails */

            StudentDetails student2; /*Declare student1 of type StudentDetails*/


            /*  student1 specification */
            student1.id = 1;
            student1.name = "vithya";
            student1.address = "pollachi";

            /* student2 specification */
            student2.id = 2;
            student2.name = "bharathi";
            student2.address = "coimbatore";


            /* print student1 info */
          
            Console.WriteLine("Id : {0}  ", +student1.id);
            Console.WriteLine("name : {0}  ", student1.name);
            Console.WriteLine("address : {0}  ", student1.address);


            /* print student2 info */
            Console.WriteLine("Id : {0}  ", student2.id);
            Console.WriteLine("name : {0}  ", student2.name);
            Console.WriteLine("address : {0}  ", student2.address);

            Console.ReadKey();
        }
    }
}



