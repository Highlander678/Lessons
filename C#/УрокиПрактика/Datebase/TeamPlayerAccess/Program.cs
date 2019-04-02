using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCore;

namespace TeamPlayerAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {

                var Команда = db.Teams; // не отложенная операция, выполняется сразу
                //Запрос с помощью методов расширения LINQ (Linq to Object)
                var query = Команда.Where(tm => tm.Country == "Россия").
                            Select(tm => new { tm.Id, tm.Name });



                Console.WriteLine("Российские команды:");
                int Id = 0;
                foreach (var item in query)
                {
                    Console.WriteLine("{0}. {1}", Id, item.Name);
                    Id++;
                }
                Console.ReadKey();

                var Игроки = db.Players.ToList();

                var query_1 = Игроки.Where(pl => pl.Age >= 25).
                            Select(pl => new { pl.Id, pl.Name });

                Console.WriteLine("Игроки старше или равны 25 годам:");
                Id = 0;
                foreach (var item in query_1)
                {

                    Console.WriteLine("{0}. {1}", Id, item.Name);
                    Id++;
                }
                Console.ReadKey();

                //Linq to Objects
                var query_2 = Игроки.Where(pl => pl.Age >= 25).ToList().Where(pl => pl.Id > 3).
                                Select(pl=> new {pl.Id,pl.Name });

                foreach (var item in query_2)
                {
                    Console.WriteLine("{0}. {1}",item.Id,item.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
