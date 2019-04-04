using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Mysql_Context db = new Mysql_Context())
            {
                db.Database.EnsureCreated();

                User player_1 = new User { Id = 1, FirstName = "Alex", LastName = "MIB" };
                User player_2 = new User { Id = 2, FirstName = "Петр", LastName = "25" };

                //db.Players.AddRange(new List<Player> { player_1, player_2 });
                db.Users.Add(player_1);
                db.SaveChanges();

                Console.WriteLine("Данные сохранены в базу");
                Console.ReadKey();
            }
        }
    }
}
