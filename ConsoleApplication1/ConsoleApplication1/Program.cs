using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new ConsoleApplication1.Person
            {
                FirstName = "Marcel",
                LastName = "Roesink",
                BirthDate = new DateTime(year: 1958, month: 1, day: 10)
            };
            Console.WriteLine(String.Format(format: "{0} {1} is {2} jaar oud", arg0: p.FirstName, arg1: p.LastName, arg2: p.Age));
            Console.ReadKey();
        }
    }
}
