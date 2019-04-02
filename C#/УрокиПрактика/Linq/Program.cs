using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
                {
                new Person { Id = 1, Name = "Alex", Age = 20 },
                new Person { Id = 2, Name = "Anton", Age = 30 },
                new Person {Id =3, Name="Nata", Age = 18},
                };
            var AdultPeople = from emp in people
                              where emp.Age >= 20
                              //select emp;
                              select new
                              {
                                  emp.Id,
                                  emp.Name,
                                  emp.Age

                              };
            foreach (var item in AdultPeople)
            {
                Console.WriteLine("{0}: Имя {1} - {2} ", item.Id, item.Name, item.Age );

            }
            Console.ReadKey();
        }
    }
}
