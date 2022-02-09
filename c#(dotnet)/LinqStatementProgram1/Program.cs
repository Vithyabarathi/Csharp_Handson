using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStatementProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
			var people = new List<Person>()
			{
			new Person("Bill", "Smith", 41),
			new Person("Sarah", "Jones", 22),
			new Person("Stacy","Baker", 21),
			new Person("Vivianne","Dexter", 19 ),
			new Person("Bob","Smith", 49 ),
			new Person("Brett","Baker", 51 ),
			new Person("Mark","Parker", 19),
			new Person("Alice","Thompson", 18),
			new Person("Evelyn","Thompson", 58 ),
			new Person("Mort","Martin", 58),
			new Person("Eugene","deLauter", 84 ),
			new Person("Gail","Dawson", 19 ),

			};


			var people1 = from peopleObject in people
						  where peopleObject.LastName.StartsWith("D")
						  select peopleObject;
			int count = 0;
			Console.WriteLine("The name Starts with D are  : ");
			foreach (var item in people1)
			{
				Console.WriteLine(item.LastName);
                count++;
			}
			
			Console.WriteLine(" Total Number of people who's LASTNAME starts with  letter D is " + count + " Member");
	
		
			Console.WriteLine(" ");
			var people2= from personobj in people
						  where personobj.Age > 40
						  orderby personobj.FirstName descending
						  select personobj;



			Console.WriteLine("Person Older Than 40 in Descending Order by First Name ");
			foreach (var item in people2)
			{
				Console.WriteLine(item.FirstName);
			}
			Console.ReadKey();
		}
	}

	}

