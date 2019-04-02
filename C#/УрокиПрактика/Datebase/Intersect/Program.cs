using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCore;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                var Выборка_1 = db.Teams.Where(p => p.Id > 1).
                                Intersect(db.Teams.Where(p => p.Country.Equals("Россия")));
                Console.WriteLine("Выборка с использованием Intersect");
                foreach (var item in Выборка_1)
                {
                    Console.WriteLine("{0}. {1}", item.Id,item.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
