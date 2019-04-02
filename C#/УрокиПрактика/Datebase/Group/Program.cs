using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCore;

namespace Group
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                var Выборка_1 = from p in db.Teams
                                group p by p.Country;
                foreach (var item in Выборка_1)
                {
                    Console.WriteLine(item.Key);

                    foreach (var g in item)
                    {
                        Console.WriteLine("{0}. {1}",g.Id,g.Name);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
