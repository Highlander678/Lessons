using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCore;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                var Выборка = db.Players.OrderByDescending(p => p.Age);

                foreach (var item in Выборка)
                {
                    Console.WriteLine("{0}. {1} - Возраст: {2}", item.Id, item.Name, item.Age);
                }
                Console.ReadKey();

                var Выборка_1 = from p1 in db.Players
                                orderby p1.Age
                                select p1;
                var Выборка_2 = db.Players.Where(p => p.Id > 2).
                    OrderBy(p => p.Age).
                    ThenBy(p => p.Id);
                Console.WriteLine("\nСортировка по возрасту, затем по имени:\n");
                foreach (var item in Выборка_2)
                {
                    Console.WriteLine("{0}. {1} Возраст: {2}",item.Id,item.Name,item.Age);
                }
                Console.ReadKey();

                Console.WriteLine("\nИспользование оператора Join\n");

                //var Выборка_3 = db.Players.Join(db.Teams, p => p.Id, c => c.Id,
                //    (p,c)=>new
                //    {
                //        p.Id,
                //        p.Name,
                //        _id=c.Id,
                //        _name=c.Name,
                //        c.Country
                //    });

                var Выборка_4 = from p in db.Players
                                join c in db.Teams on p.Id equals c.Id
                                select new { p.Id, p.Name, _id = c.Id, _name = c.Name, c.Country };

                foreach (var item in Выборка_4)
                {
                    Console.WriteLine("ID Игрока: {0}. Имя: {1} - ID Команды: {2} Название: {3} Страна: {4}",
                            item.Id, item.Name, item._id,item._name,item.Country);
                }
                Console.ReadKey();
            }
            

        }
    }
}
