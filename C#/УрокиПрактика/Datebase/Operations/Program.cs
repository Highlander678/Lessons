using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCore;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                int col = db.Players.Count();
                Console.WriteLine("Кол-во элементов в таблице игроков: {0}",col);

                int col_1 = db.Players.Count(p => p.Name.Contains("ан"));
                Console.WriteLine("\n Игроки в имени ктороых есть ан - {0}:",col_1);
                var Выборка_1 = db.Players.Where(p=>p.Name.Contains("ан"));
                foreach (var item in Выборка_1)
                {
                    Console.WriteLine("{0}. {1}",item.Id,item.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
